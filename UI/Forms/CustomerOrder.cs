using System.Windows.Forms;
using Model;
using UI.Controls;
using UI.Forms;
using UI.Services;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static Model.DTO;

namespace UI
{
    public partial class CustomerOrder : Form
    {

        #region Generic class
        private readonly ApiService apiService;
        private readonly ShareFile shareFile;
        public CustomerOrder()
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
                idBox, nameBox, emailBox, addressBox1, addressBox2,
                orderNoBox, statusBox, orderDateBox, subTotalBox,
                gstBox, sumTotalBox, searchBox1, searchBox2
            });
        }
        //private MainForm main;
        private MainProgram main;
        private string GetUser()
        {
            //main = new MainForm();
            main = new MainProgram();
            return main.CurrentUser();
        }
        private void HandleItemSelect(string[] rowData, string formType)
        {
            if (formType == "Customer")
            {
                BindCustomerData(rowData);
            }
            else if (formType == "Product")
            {
                HandleProductSelection(rowData);
            }
        }
        private void BindCustomerData(string[] rowData)
        {
            var bindings = new Dictionary<string, TextBox>
            {
                { "code", idBox },
                { "name", nameBox },
                { "address1", addressBox1 },
                { "address2", addressBox2 },
                { "email", emailBox }
            };
            shareFile.BindRowDataToTextBoxes(bindings, new[] { "code", "name", "phone", "email", "address1", "address2" }, rowData);
            isSearchFormOpen = false;
        }
        private void HandleProductSelection(string[] rowData)
        {
            string code = rowData[0];
            string name = rowData[1];
            string cost = rowData[3];
            decimal price = Convert.ToDecimal(rowData[4]);
            int inventory = Convert.ToInt32(rowData[5]);

            if (inventory <= 0)
            {
                shareFile.ShowMessage($"Inventory for {code} is 0, cannot add to cart.");
                return;
            }

            if (inventory <= 10)
            {
                shareFile.ShowMessage($"Inventory for {code} is low.");
            }
            UpdateCart(code, name, price, inventory, cost);
        }
        private void UpdateCart(string code, string name, decimal price, int inventory, string cost)
        {
            bool productExists = false;

            foreach (DataGridViewRow r in cartList.Rows)
            {
                if (r.Cells["code"].Value != null && r.Cells["code"].Value.ToString() == code)
                {
                    productExists = true;
                    int currentQuantity = Convert.ToInt32(r.Cells["quantity"].Value);
                    int newQuantity = currentQuantity + 1;
                    r.Cells["quantity"].Value = newQuantity;
                    r.Cells["total"].Value = newQuantity * price;
                    break;
                }
            }
            if (!productExists)
            {
                shareFile.ShowMessage($"Cost of this product: ${cost}");
                UpdateSelectedRow(code, name, inventory, price);
            }
            cartList.EndEdit();
            isSearchFormOpen = false;

        }
        private void UpdateSelectedRow(string code, string name, int inventory, decimal price)
        {
            DataGridViewRow selectedRow = cartList.CurrentRow;
            if (selectedRow == null) return;
            selectedRow.Cells["code"].Value = code;
            selectedRow.Cells["name"].Value = name;
            selectedRow.Cells["status"].Value = inventory;
            selectedRow.Cells["price"].Value = price;
            selectedRow.Cells["quantity"].Value = 1;
            selectedRow.Cells["discount"].Value = 1;
            selectedRow.Cells["total"].Value = price;
            UpdateTotals();
            cartList.Focus();
            //DataGridViewTextBoxEditingControl
        }

        //private void AddNewItem(string code, string name, int inventory, decimal price)
        //{
        //    int rowIndex = cartList.Rows.Count;
        //    cartList.Rows.Add();
        //    DataGridViewRow row = cartList.Rows[rowIndex];
        //    row.Cells["sequence"].Value = rowIndex + 1;
        //    row.Cells["code"].Value = code;
        //    row.Cells["name"].Value = name;
        //    row.Cells["status"].Value = inventory;
        //    row.Cells["price"].Value = price;
        //    row.Cells["quantity"].Value = 1;
        //    row.Cells["discount"].Value = 1;
        //    row.Cells["total"].Value = price;
        //}
        private bool isopen;
        private void ShowSearchForm(string searchTerm, string formType)
        {
            SearchForm searchForm = new SearchForm(formType, apiService);
            try
            {
                searchForm.TopLevel = false;
                shareFile.SetForm(searchForm, homePanel);
                searchForm.OnItemSelect += (rowData) => HandleItemSelect(rowData, formType);
                searchForm.OnIsAddNew += (isadd) =>
                {
                    if (isadd)
                    {
                        isopen = true;
                    }
                };
                searchForm.FormClosed += (sender, e) =>
                {
                    homePanel.Enabled = true;
                    if (isopen)
                    {
                        OpenCreateForm();
                    }
                };
                searchForm.BringToFront();
                searchForm.LoadSearchResults(searchTerm);
                isSearchFormOpen = true;
            }
            catch (Exception ex)
            {
                shareFile.HandleException(ex);
            }
        }
        private void OpenCreateForm()
        {
            QuickAddForm qaf = new QuickAddForm();
            qaf.TopLevel = false;
            shareFile.SetForm(qaf, this.Parent);
            qaf.BringToFront();
        }

        private async void SetComboBox()
        {
            List<GetUsername> list = await apiService.AllUsernameAsync();
            foreach (GetUsername item in list) 
            {
                operatorBox.Items.Add(item.UserName);
            }
        }
        #endregion

        #region Buttons Action
        private void searchBtn1_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox1.Text.Trim();
            ShowSearchForm(searchTerm, "Customer");
        }

        private void searchBtn2_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox2.Text.Trim();
            ShowSearchForm(searchTerm, "Product");
        }

        private void deleprod_Click(object sender, EventArgs e)
        {
            if (cartList.CurrentRow != null && !cartList.SelectedRows.Contains(cartList.CurrentRow))
            {
                cartList.CurrentRow.Selected = true;
            }
            cartList.EndEdit();
            DataGridViewRow selectedRow = cartList.CurrentRow;
            shareFile.RemoveSelectedRows(cartList);
            shareFile.RewriteSequence(cartList);
        }
        private async void confirmOrder_Click(object sender, EventArgs e)
        {
            if (!shareFile.ConfirmAction("Do you want to confirm this order?", "Confirm Order"))
            {
                await apiService.InsertActionAsync(shareFile.RecodeAction($"{GetUser()} create order for CustomerID: {idBox.Text}, OrderID = {orderNoBox.Text}"));
                return;
            }

            if (string.IsNullOrWhiteSpace(idBox.Text))
            {
                MessageBox.Show("Customer ID is required.");
                return;
            }
            await ProcessOrder();
            shareFile.RewriteSequence(cartList);
        }
        private void cancelOrder_Click(object sender, EventArgs e)
        {
            if (shareFile.ConfirmAction("Do you want to cancel this order?", "Cancel Order"))
            {
                TextBoxClear();
                cartList.Rows.Clear();
            }
        }
        #endregion

        #region Process
        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
            DateTime orderDate = DateTime.Now;
            string orderID = orderDate.ToString("yyyyMMddHHmmss");
            string orderDateString = orderDate.ToString("yyyy-MM-ddTHH:mm:ss");
            orderDateBox.Text = orderDateString;
            orderNoBox.Text = orderID;
            statusBox.Text = "unpaid";
            searchBox1.Focus();
            SetComboBox();
            for (int i = 0; i < 100; i++)
            {
                cartList.Rows.Add();
                cartList.Rows[i].Cells["sequence"].Value = i + 1;
            }
            cartList.ClearSelection();
        }

        private async Task ProcessOrder()
        {
            string orderID = orderNoBox.Text.Trim();
            string customerID = idBox.Text.Trim();
            string? user = operatorBox.SelectedItem.ToString();
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
                Status = "Paid",
                Operator = user
            };
            //await apiService.InsertOrderAsync(newOrder);
            try
            {
                await apiService.InsertOrderAsync(newOrder);
                shareFile.ShowMessage("Order saved successfully.");
            }
            catch (Exception ex)
            {
                shareFile.HandleException(ex);
            }

            //SendOrderConfirmationEmail(orderID);
            TextBoxClear();
            cartList.Rows.Clear();
        }
        private async Task ProcessOrderDetail(DataGridViewRow row, string orderID)
        {
            string productCode = row.Cells["code"].Value?.ToString();
            int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
            decimal price = Convert.ToDecimal(row.Cells["price"].Value);
            double discount = Convert.ToDouble(row.Cells["discount"].Value);
            decimal total = Convert.ToDecimal(row.Cells["total"].Value);
            string orderDetailID = orderID + productCode;
            int inventory = Convert.ToInt32(row.Cells["status"].Value);
            int finalInventory = inventory - quantity;

            OrderDetail orderDetail = new OrderDetail
            {
                OrderDetailID = orderDetailID,
                OrderID = orderID,
                ProductCode = productCode,
                Quantity = quantity,
                UnitPrice = price,
                Discount = discount,
                Total = total
            };
            int newInvtChangId = await shareFile.GenerateId(apiService, "InventoryChange", "ID");
            InventoryChange invtchange = new InventoryChange
            {
                ID = newInvtChangId.ToString("D10"),
                ProductCode = productCode,
                Date = DateTime.Now.ToString("yyyy-MM-dd"),
                Qty = $"-{quantity}",
                Reason = "Sale"
            };
            await apiService.InsertOrderDetailAsync(orderDetail);
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
                    e.ColumnIndex == cartList.Columns["price"].Index ||
                    e.ColumnIndex == cartList.Columns["discount"].Index)
                {
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    double price = Convert.ToDouble(row.Cells["price"].Value);
                    double discount = Convert.ToDouble(row.Cells["discount"].Value);
                    double total = price * quantity * discount;
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

        private async Task SendOrderConfirmationEmail(string id)
        {
            string filepath = @"C:\StoreSystem\inv.pdf";
            EmailService emailService = new EmailService();
            string subject = "Order Confirmation";
            string custName = nameBox.Text.Trim();
            string orderID = orderNoBox.Text.Trim();
            string body = $"Dear {custName},<br><br>Your order has been successfully placed. Order ID: {orderID}.<br><br>Thank you for shopping!";
            string custEmail = emailBox.Text.Trim();
            try
            {
                emailService.SendEmail(custEmail, subject, body, filepath);
            }
            catch (Exception ex)
            {
                shareFile.HandleException(ex);
            }
        }
        #endregion

        #region User Friendly
        private void searchBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { searchBtn1.PerformClick(); }
            else
            { 
                shareFile.TextBox_KeyDown(sender, e, searchBox2, nameBox);
            }
        }
        private void searchBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { searchBtn1.PerformClick(); }
            else
            {
                shareFile.TextBox_KeyDown(sender, e, nameBox, searchBox1);
            }
        }
        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, searchBox2, addressBox1);
        }
        private void addressBox1_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, nameBox, addressBox2);
        }
        private void addressBox2_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, addressBox1, emailBox);
        }
        private void emailBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, addressBox2, orderNoBox);
        }
        private void orderNoBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, emailBox, statusBox);
        }
        private void statusBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, orderNoBox, orderDateBox);
        }
        private void orderDateBox_KeyDown(object sender, KeyEventArgs e)
        {
            shareFile.TextBox_KeyDown(sender, e, statusBox, cartList);
        }
        private void homePanel_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }
        private void cartList_Leave(object sender, EventArgs e)
        {
            cartList.ClearSelection();
        }
        //private void cartList_KeyDown(object sender, KeyEventArgs e)
        //{
        //    cartList.CurrentCell = cartList.CurrentCell;
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        e.Handled = true;
        //        cartList.EndEdit();
        //        //HandleEnterKey();
        //    }
        //    //else if (e.KeyCode == Keys.Down)
        //    //{
        //    //    shareFile.MoveToNextEditableCell(cartList);
        //    //}
        //    //else if (e.KeyCode == Keys.Up)
        //    //{
        //    //    shareFile.MoveToNextEditableCell(cartList);
        //    //}
        //    //else if (e.KeyCode == Keys.Left)
        //    //{
        //    //    shareFile.MoveToNextEditableCell(cartList);
        //    //}
        //    //else if (e.KeyCode == Keys.Right)
        //    //{
        //    //    shareFile.MoveToNextEditableCell(cartList);
        //    //}
        //}
        //private void HandleEnterKey()
        //{
        //    var currentCell = cartList.CurrentCell;
        //    if (currentCell != null)
        //    {
        //        string? searchTerm = Convert.ToString(currentCell.Value)?.Trim();
        //        if (string.IsNullOrEmpty(searchTerm))
        //        {
        //            shareFile.MoveToNextEditableCell(cartList);
        //        }
        //        else if (cartList.Columns[currentCell.ColumnIndex].Name == "code")
        //        {
        //            cartList.EndEdit();
        //            ShowSearchForm(searchTerm, "Product");
        //        }
        //        else
        //        {
        //            shareFile.MoveToNextEditableCell(cartList);
        //        }
        //    }
        //}
        //private void cartList_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    cartList.BeginEdit(true);
        //}
        //private void cartList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    cartList.CurrentCell = cartList.CurrentCell;
        //    var currentCell = cartList.CurrentCell;
        //    if (currentCell != null)
        //    {
        //        string? searchTerm = Convert.ToString(currentCell.Value)?.Trim();
        //        if (cartList.Columns[currentCell.ColumnIndex].Name == "code")
        //        {
        //            ShowSearchForm(searchTerm, "Product");
        //        }
        //    }
        //}
        //private void cartList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    e.CellStyle.BackColor = Color.Yellow;
        //    if (e.Control is TextBox textBox)
        //    {
        //        textBox.KeyDown -= TextBox_KeyDown;
        //        textBox.KeyDown += TextBox_KeyDown;
        //    }
        //}

        //private void TextBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    var currentCell = cartList.CurrentCell;
        //    if (currentCell != null)
        //    {
        //        if (e.KeyCode == Keys.Enter)
        //        {
        //            //cartList.EndEdit();
        //            string? searchTerm = Convert.ToString(currentCell.Value)?.Trim();
        //            if (cartList.Columns[currentCell.ColumnIndex].Name == "code")
        //            {
        //                ShowSearchForm(searchTerm, "Product");
        //            }
        //            //cartList.EndEdit();
        //        }
        //        else
        //        {

        //        }
        //        //e.Handled = true;
        //        //e.SuppressKeyPress = true;
        //        //cartList.EndEdit();
        //    }
        //}
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Enter)
        //    {
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        //private void cartList_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        e.Handled = true;
        //        if (cartList.IsCurrentCellInEditMode)
        //        {
        //            cartList.EndEdit();
        //        }
        //    }
        //}
        //private void cartList_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Down)
        //    {
        //        shareFile.MoveToAdjacentCell(cartList, 1);
        //    }
        //    else if (e.KeyCode == Keys.Up)
        //    {
        //        shareFile.MoveToAdjacentCell(cartList, -1);
        //    }
        //    else if (e.KeyCode == Keys.Left)
        //    {
        //        shareFile.MoveToAdjacentCell(cartList, 0, -1);
        //    }
        //    else if (e.KeyCode == Keys.Right)
        //    {
        //        shareFile.MoveToAdjacentCell(cartList, 0, 1);
        //    }
        //    e.Handled = true;
        //}
        private bool isSearchFormOpen = false;
        private void HandleEnterKey()
        {
            var currentCell = cartList.CurrentCell;
            if (currentCell != null)
            {
                string? searchTerm = Convert.ToString(currentCell.Value)?.Trim();
                if (string.IsNullOrEmpty(searchTerm))
                {
                    shareFile.MoveToNextEditableCell(cartList);
                }
                else if (cartList.Columns[currentCell.ColumnIndex].Name == "code")
                {
                    ShowSearchForm(searchTerm, "Product");
                    isSearchFormOpen=true;
                }
                else
                {
                    shareFile.MoveToNextEditableCell(cartList);
                }
            }
        }
        private void cartList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.CellStyle.BackColor = Color.Yellow;
        }

        private void cartList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cartList.BeginEdit(true);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (cartList.IsCurrentCellInEditMode)
                {
                    cartList.EndEdit();
                    HandleEnterKey();
                    cartList.CurrentCell = cartList.CurrentCell;
                    return true;
                }
                else if (this.ActiveControl != cartList)
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            else if (keyData == Keys.Left || keyData == Keys.Right)
            {
                if (cartList.IsCurrentCellInEditMode)
                {
                    shareFile.MoveToAdjacentCell(cartList, keyData, emailBox);
                    return true;
                }
                else if (this.ActiveControl != cartList)
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}
