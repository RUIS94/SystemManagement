using Model;
using UI.Services;
using static Model.DTO;

namespace UI
{
    public partial class GoodsReceived : Form
    {
        #region Generic
        private readonly ApiService apiService;
        private readonly ShareFile shareFile;
        public GoodsReceived()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
            shareFile = new ShareFile();
        }
        private void TextBoxClear()
        {
            ShareFile shareFile = new ShareFile();
            shareFile.ClearTextBoxes(new Control[]
            {
                idBox, nameBox, addressBox1, addressBox2,
                orderNoBox, batchBox, userBox, subTotalBox,
                gstBox, sumTotalBox, searchBox1, searchBox2
            });
        }
        private void HandleItemSelect(string[] rowData, string formType)
        {
            if (formType == "Supplier")
            {
                BindSupplierData(rowData);
            }
            else if (formType == "Product")
            {
                HandleProductSelection(rowData);
            }
        }
        private void BindSupplierData(string[] rowData)
        {
            var bindings = new Dictionary<string, TextBox>
            {
                { "code", idBox },
                { "name", nameBox },
                { "address1", addressBox1 },
                { "address2", addressBox2 }
            };
            shareFile.BindRowDataToTextBoxes(bindings, new[] { "code", "name", "phone", "email", "address1", "address2" }, rowData);
        }
        private void HandleProductSelection(string[] rowData)
        {
            string code = rowData[0];
            string name = rowData[1];
            string barcode = rowData[2];
            decimal cost = Convert.ToDecimal(rowData[3]);
            decimal price = Convert.ToDecimal(rowData[4]);
            int inventory = Convert.ToInt32(rowData[5]);
            UpdateCart(code, name, barcode, cost,inventory);
        }
        private void UpdateCart(string code, string name, string barcode, decimal cost, int inventory)
        {
            bool productExists = false;

            foreach (DataGridViewRow r in cartList.Rows)
            {
                if (r.Cells["code"].Value.ToString() == code)
                {
                    productExists = true;
                    int currentQuantity = Convert.ToInt32(r.Cells["quantity"].Value);
                    int newQuantity = currentQuantity + 1;
                    r.Cells["quantity"].Value = newQuantity;
                    r.Cells["total"].Value = newQuantity * cost;
                    break;
                }
            }

            if (!productExists)
            {
                AddNewItem(code, name, barcode, cost, inventory);
            }
        }
        private void AddNewItem(string code, string name, string barcode, decimal cost, int inventory)
        {
            int rowIndex = cartList.Rows.Count;
            cartList.Rows.Add();
            DataGridViewRow row = cartList.Rows[rowIndex];
            row.Cells["sequence"].Value = rowIndex + 1;
            row.Cells["code"].Value = code;
            row.Cells["name"].Value = name;
            row.Cells["barcode"].Value = barcode;
            row.Cells["status"].Value = inventory;
            row.Cells["quantity"].Value = 1;
            row.Cells["price"].Value = cost;           
            row.Cells["total"].Value = cost;
        }
        private void ShowSearchForm(string searchTerm, string formType)
        {
            SearchForm searchForm = new SearchForm(formType, apiService);
            try
            {
                searchForm.TopLevel = false;
                shareFile.SetForm(searchForm, homePanel);
                searchForm.OnItemSelect += (rowData) => HandleItemSelect(rowData, formType);
                searchForm.BringToFront();
                searchForm.LoadSearchResults(searchTerm);
            }
            catch (Exception ex)
            {
                shareFile.HandleException(ex);
            }
        }
        #endregion

        #region Buttons Action
        private void searchBtn1_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox1.Text.Trim();
            ShowSearchForm(searchTerm, "Supplier");
        }
        private void searchBtn2_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox2.Text.Trim();
            //List<Product> results = await apiService.SearchProductsAsync(searchTerm);
            //if (results.Count == 0)
            //{
            //    if (shareFile.ConfirmAction("No Products found. Do you want to add a new product?", "Add Product"))
            //    {
            //        CreateForm cre = new CreateForm("Product", apiService);
            //        cre.TopLevel = false;
            //        cre.OnDataSubmitted += (code, name) =>
            //        {
            //            idBox.Text = code;
            //            nameBox.Text = name;
            //        };
            //        shareFile.SetForm(cre, goodsInPanel);
            //        cre.BringToFront();
            //    }
            //}
            //else
            //{
            //    ShowSearchForm(searchTerm, "Product");
            //}
            ShowSearchForm(searchTerm, "Product");
        }
        private void deleprod_Click(object sender, EventArgs e)
        {
            shareFile.RemoveSelectedRows(cartList);
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            if (shareFile.ConfirmAction("Do you want to cancel?", "Cancel"))
            {
                TextBoxClear();
                cartList.Rows.Clear();
            }
        }
        private void goodsInPanel_Click(object sender, EventArgs e)
        {
            if (monthCalendar.Visible)
            {
                monthCalendar.Visible = false;
            }
            this.BringToFront();
        }
        private void calendarBtn_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = true;
        }
        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateBox.Text = e.Start.ToString("yyyy-MM-dd");
            monthCalendar.Visible = false;
        }
        private async void confirm_Click(object sender, EventArgs e)
        {
            if (!shareFile.ConfirmAction("Do you want to confirm this goodsIn?", "Confirm GoodsIn"))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(idBox.Text))
            {
                MessageBox.Show("Supplier ID is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(batchBox.Text))
            {
                MessageBox.Show("BatchNumber is required.");
                return;
            }
            await ProcessOrder();
        }
        #endregion

        #region Process
        private void GoodsReceived_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
            TextBoxClear();
            cartList.Rows.Clear();
            DateTime orderDate = DateTime.Now;
            string orderID = orderDate.ToString("yyyyMMddHHmmss");
            orderNoBox.Text = orderID;
        }
        private async Task ProcessOrder()
        {
            string orderID = orderNoBox.Text.Trim();
            foreach (DataGridViewRow row in cartList.Rows)
            {
                if (row.IsNewRow) continue;
                await ProcessGoodsIn(row, orderID);
            }
            cartList.Rows.Clear();
        }
        private async Task ProcessGoodsIn(DataGridViewRow row, string orderID)
        {
            string productCode = row.Cells["code"].Value?.ToString();
            string name = row.Cells["name"].Value?.ToString();
            string barcode = row.Cells["barcode"].Value?.ToString();
            decimal cost = Convert.ToDecimal(row.Cells["price"].Value);
            string batch = batchBox.Text.Trim();
            int inventory = Convert.ToInt32(row.Cells["status"].Value);
            int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
            string suppId = idBox.Text.Trim();
            decimal total = Convert.ToDecimal(row.Cells["total"].Value);
            string id = orderID + productCode;
            string date = dateBox.Text.Trim();
            int finalInventory = inventory + quantity;

            GoodsIn goodsIn = new GoodsIn
            {
                GoodsInCode = id,
                ProductCode = productCode,
                ProductName = name,
                ProductBarcode = barcode,
                ProductCost = cost,
                ProductBatch = batch,
                ProductQuantity = quantity,
                SupplierCode = suppId,
                Total = total,
                Date = date
            };
            int newInvtChangId = await shareFile.GenerateId(apiService, "InventoryChange", "ID");
            InventoryChange invtchange = new InventoryChange
            {
                ID = newInvtChangId.ToString("D10"),
                ProductCode = productCode,
                Date = dateBox.Text.Trim(),
                Qty = quantity.ToString(),
                Reason = "Purchase"
            };
            await apiService.InsertGoodsInAsync(goodsIn);
            await apiService.InsertInventoryChangeAsync(invtchange);
            var updateinvt = new InventoryUpdate
            {
                ProductCode = productCode,
                Inventory = finalInventory
            };
            await apiService.UpdateInventoryAsync(updateinvt);
        }
        private void cartList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = cartList.Rows[e.RowIndex];
                if (e.ColumnIndex == cartList.Columns["quantity"].Index ||
                    e.ColumnIndex == cartList.Columns["price"].Index)
                {
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    double price = Convert.ToDouble(row.Cells["price"].Value);
                    double total = price * quantity;
                    row.Cells["total"].Value = total;
                    UpdateTotals();
                }
            }
        }
        private void UpdateTotals()
        {
            double sumTotal = 0;
            foreach (DataGridViewRow r in cartList.Rows)
            {
                if (!r.IsNewRow && r.Cells["total"].Value != null)
                {
                    sumTotal += Convert.ToDouble(r.Cells["total"].Value);
                }
            }
            sumTotalBox.Text = sumTotal.ToString();
            double gstRate = 0.1;
            double gst = sumTotal * gstRate;
            double subTotal = sumTotal - (sumTotal * gstRate);
            subTotalBox.Text = subTotal.ToString("F2");
            gstBox.Text = gst.ToString("F2");
        }
        #endregion
    }
}
/*
 #region Generic class

        #region Process
        private async Task ProcessOrder()
        {-
            string orderID = orderNoBox.Text.Trim();
            string customerID = idBox.Text.Trim();

            decimal sumTotal = Convert.ToDecimal(sumTotalBox.Text);
            var balance = await apiService.GetBalanceAsync(customerID);
            decimal finalbalance = Convert.ToDecimal(balance) - sumTotal;
            if (finalbalance <= 0)
            {
                MessageBox.Show("The belence is not enough");
                return;
            }
            foreach (DataGridViewRow row in cartList.Rows)
            {
                if (row.IsNewRow) continue;
                await ProcessOrderDetail(row, orderID);
            }
            var updatebala = new BalanceUpdate
            {
                CustomerID = customerID,
                AccountBalance = finalbalance
            };
            await apiService.UpdateAccountBalance(updatebala);
            Order newOrder = new Order
            {
                OrderID = orderID,
                CustomerID = customerID,
                OrderDate = orderDateBox.Text,
                TotalAmount = sumTotal,
                Status = "Paid"
            };
            try
            {
                await apiService.InsertOrderAsync(newOrder);
                shareFile.ShowMessage("Order saved successfully.");
            }
            catch (Exception ex)
            {
                shareFile.HandleException(ex);
            }
            SendOrderConfirmationEmail(orderID);
            TextBoxClear();
            cartList.Rows.Clear();
        }
                      
        #endregion

 */

/*
        private List<Product> products = new List<Product>();
        private async void fileBtn_Click(object sender, EventArgs e)
        {
            string filePath = fileUrlBox.Text;
            if (File.Exists(filePath))
            {
                products = await ReadCsvFileAsync(filePath);
                fileContentDisplay.DataSource = products;
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }
        private async Task<List<Product>> ReadCsvFileAsync(string filePath)
        {

            var productList = new List<Product>();
            try
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines.Skip(1))
                {
                    var columns = line.Split(',');
                    if (columns.Length == 6)
                    {
                        var product = new Product()
                        {
                            ProductCode = columns[0],
                            Name = columns[1],
                            Barcode = columns[2],
                            Cost = Convert.ToDouble(columns[3]),
                            Price = Convert.ToDouble(columns[4]),
                            Inventory = Convert.ToInt32(columns[5])
                        };
                        productList.Add(product);                       
                    }
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            return productList;
        }

        private async void uploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var potentialDuplicates = new List<Product>();
                foreach (var product in products)
                {
                    bool pkExists = await apiService.CheckExistsAsync("Products", "ProductCode", product.ProductCode);
                    //bool nameExists = await apiService.CheckExistsAsync("Products", "Name", product.Name);
                    //bool barcodeExists = await apiService.CheckExistsAsync("Products", "Barcode", product.Barcode);
                    if (pkExists)
                    {
                        var existingProduct = await apiService.SearchProductsAsync(product.ProductCode);
                        bool allInfoMatches = existingProduct.Any(p => p.Name == product.Name &&  p.Barcode == product.Barcode);
                        bool barcodeMatches = existingProduct.Any(p => p.Barcode == product.Barcode && p.Name != product.Name);
                        if (allInfoMatches)
                        { 
                            var dialogResult = MessageBox.Show(
                                $"Product with \n code: {product.ProductCode} \n Name: {product.Name} \n Barcode: {product.Barcode} \n exists. \n Do you want to update it?",
                                "Product Update",
                            MessageBoxButtons.YesNo
                            );
                            if (dialogResult == DialogResult.Yes)
                            {
                                await apiService.UpdateProductAsync(product);
                            }
                        }
                        else
                        {
                            if (barcodeMatches)
                            {
                                potentialDuplicates.Add(product);
                                MessageBox.Show($"Product with same barcode but different name \n Name: {product.Name} \n Barcode: {product.Barcode} \n could be duplicate \n will skip.");
                            }
                            else
                            {
                                product.ProductCode = await apiService.GenerateNewProductCodeAsync();
                                await apiService.InsertProductAsync(product);
                                MessageBox.Show($"Product with \n Code: {product.ProductCode} \n Name: {product.Name} \n Added.");
                            }
                        }
                    }
                    else
                    {
                        var existingProduct = await apiService.SearchProductsAsync(product.Barcode);
                        bool nameWithBarcodeMatches = existingProduct.Any(p => p.Name == product.Name);
                        bool barcodeMatches = existingProduct.Any(p => p.Name != product.Name);
                        if (nameWithBarcodeMatches)
                        {
                            var previousCode = await apiService.GetProductCodeAsync(product.Barcode);
                            var dialogResult = MessageBox.Show(
                                $"Product with \n Name: {product.Name} \n Barcode: {product.Barcode} \n exists. \n Do you want to update it and keep previous ProductCode?",
                                "Product Update",
                            MessageBoxButtons.YesNo
                            );
                            if (dialogResult == DialogResult.Yes)
                            {
                                product.ProductCode = previousCode;
                                await apiService.UpdateProductAsync(product);
                            }
                            else
                            {
                                potentialDuplicates.Add(product);
                                MessageBox.Show($"Product with \n Name: {product.Name} \n Barcode: {product.Barcode} \n will add to duplicate list, will skip.");
                            }
                        }
                        else
                        {
                            if (barcodeMatches)
                            {
                                potentialDuplicates.Add(product);
                                MessageBox.Show($"Product with \n Barcode: {product.Barcode}\n could be duplicate, will skip.");
                            }
                            else
                            { 
                                product.ProductCode = await apiService.GenerateNewProductCodeAsync();
                                await apiService.InsertProductAsync(product);
                                MessageBox.Show($"Product with \n Code: {product.ProductCode} \n Name: {product.Name} \n Added.");
                            }
                        }
                    }
                }
                if (potentialDuplicates.Count > 0)
                {
                    failToUploadDispaly.DataSource = potentialDuplicates;
                }
                MessageBox.Show("Upload complete.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = @"C:\StoreSystem";
                string fileName = $"DataGridViewExport_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                string filePath = Path.Combine(folderPath, fileName);

                StringBuilder csvContent = new StringBuilder();

                for (int i = 0; i < failToUploadDispaly.Columns.Count; i++)
                {
                    csvContent.Append(failToUploadDispaly.Columns[i].HeaderText);
                    if (i < failToUploadDispaly.Columns.Count - 1)
                        csvContent.Append(",");
                }
                csvContent.AppendLine();
                foreach (DataGridViewRow row in failToUploadDispaly.Rows)
                {
                    for (int i = 0; i < failToUploadDispaly.Columns.Count; i++)
                    {
                        string cellValue = row.Cells[i].Value?.ToString() ?? string.Empty;
                        cellValue = cellValue.Contains(",") ? $"\"{cellValue}\"" : cellValue;
                        csvContent.Append(cellValue);
                        if (i < failToUploadDispaly.Columns.Count - 1)
                            csvContent.Append(",");
                    }
                    csvContent.AppendLine();
                }
                File.WriteAllText(filePath, csvContent.ToString());
                MessageBox.Show($"Data exported successfully to {filePath}");

                failToUploadDispaly.DataSource = null;
                failToUploadDispaly.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
 */