using UI.Services;

namespace UI
{
    public partial class SupplierOrder : Form
    {
        ShareFile sf = new ShareFile();
        private readonly ApiService apiService;
        public SupplierOrder()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
        }
        #region
        private void TextBoxClear()
        {
            sf.ClearTextBoxes(new Control[]
            {
                searchBox1, searchBox2, idBox, nameBox, addressBox1, addressBox2,
                orderNoBox, orderDateBox, subTotalBox, gstBox, sumTotalBox
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
                { "id", idBox },
                { "name", nameBox },
                { "address1", addressBox1 },
                { "address2", addressBox2 }
            };
            sf.BindRowDataToTextBoxes(bindings, new[] { "id", "name", "phone", "email", "address1", "address2" }, rowData);

        }
        private void HandleProductSelection(string[] rowData)
        {
            string code = rowData[0];
            string name = rowData[1];
            string barcode = rowData[2];
            string cost = rowData[3];
            string inventory = rowData[5];
            UpdateList(code, name, barcode, cost, inventory);
        }
        private void UpdateList(string code, string name, string barcode, string cost, string inventory)
        {
            int qty = 1;
            decimal priceD = Convert.ToDecimal(cost);
            DataGridViewRow selectRow = cartList.CurrentRow;
            if (selectRow == null)
            {
                return;
            }
            selectRow.Cells["code"].Value = code;
            selectRow.Cells["name"].Value = name;
            selectRow.Cells["barcode"].Value = barcode;
            selectRow.Cells["status"].Value = inventory;
            selectRow.Cells["quantity"].Value = 1;
            selectRow.Cells["price"].Value = priceD;
            selectRow.Cells["total"].Value = qty * priceD;
            UpdateTotals();
        }
        private void UpdateTotals()
        {
            double sumtotal = 0;
            foreach (DataGridViewRow r in cartList.Rows)
            {
                if (!r.IsNewRow && r.Cells["total"].Value != null)
                {
                    sumtotal += Convert.ToDouble(r.Cells["total"].Value);
                }
            }
            sumTotalBox.Text = sumtotal.ToString();
            gstBox.Text = (sumtotal * 0.1).ToString();
            subTotalBox.Text = (sumtotal- (sumtotal * 0.1)).ToString();
        }
        private void ShowSearchForm(string term, string type)
        {
            SearchForm searf = new SearchForm(type, apiService);
            try
            {
                searf.TopLevel = false;
                sf.SetForm(searf, this);
                searf.OnItemSelect += (rowData) => HandleItemSelect(rowData, type);
            }
            catch (Exception ex)
            {
                sf.HandleException(ex);
            }
        }
        #endregion
        private void searchBtn1_Click(object sender, EventArgs e)
        {
            string term = searchBox1.Text.Trim();
            ShowSearchForm(term, "Supplier");
        }

        private void searchBtn2_Click(object sender, EventArgs e)
        {
            string term = searchBox2.Text.Trim();
            ShowSearchForm(term, "Product");
        }

        private void deleprod_Click(object sender, EventArgs e)
        {
            if (cartList.CurrentRow != null && !cartList.SelectedRows.Contains(cartList.CurrentRow))
            {
                cartList.CurrentRow.Selected = true;
            }
            cartList.EndEdit();
            DataGridViewRow selectedRow = cartList.CurrentRow;
            sf.RemoveSelectedRows(cartList);
            sf.RewriteSequence(cartList);
        }

        private void confirm_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (sf.ConfirmAction("Do you want to cancel this order?", "Cancel Order"))
            {
                TextBoxClear();
                cartList.Rows.Clear();
            }
            this.Close();
        }

        private void SupplierOrder_Load(object sender, EventArgs e)
        {
            sf.BindTextBoxEvent(this);
            DateTime td = DateTime.Now;
            string ordDate = td.ToString("dd/MM/yyyy");
            orderDateBox.Text = ordDate;
            searchBox1.Focus();
            sf.RewriteSequence(cartList);
            cartList.ClearSelection();
        }
    }
}
