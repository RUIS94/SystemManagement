
using System.Data;
using Model;
using UI.Forms;
using UI.Services;

namespace UI
{
    public partial class SearchForm : Form
    {
        private readonly ApiService apiService;
        ShareFile shareFile = new ShareFile();
        private string entityType;
        public SearchForm(string entityType, ApiService apiService)
        {
            InitializeComponent();
            this.entityType = entityType;
            this.apiService = apiService;
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.Trim();
            LoadSearchResults(searchTerm);
        }
        //public bool IsAddNew(bool isadd)
        //{
        //    return isadd;
        //}
        public Action<bool> OnIsAddNew;
        public async void LoadSearchResults(string searchTerm)
        {
            searchBox.Text = searchTerm;
            if (entityType == "Customer")
            {
                List<Customer> results = await shareFile.ExecuteSearchAsync(searchTerm, apiService.SearchCustomersAsync);
                shareFile.UpdateSearchResults(searchResults, results);
                addBtn.Visible = true;
                if (results.Count == 0)
                {
                    bool addNew = shareFile.HandleSearchException("No customers found. Add new customer?");
                    if (addNew)
                    {
                        //CreateForm cre = new CreateForm("Customer", apiService);
                        //cre.TopLevel = false;
                        //shareFile.SetForm(cre, this.Parent);
                        //cre.BringToFront();
                        OnIsAddNew?.Invoke(true);
                    }
                    this.Close();
                }
            }
            else if (entityType == "Product")
            {
                List<Product> results = await shareFile.ExecuteSearchAsync(searchTerm, apiService.SearchProductsAsync);
                shareFile.UpdateSearchResults(searchResults, results);
            }
            else if (entityType == "Supplier")
            {
                List<Supplier> results = await shareFile.ExecuteSearchAsync(searchTerm, apiService.SearchSuppliersAsync);
                shareFile.UpdateSearchResults(searchResults, results);
            }
            else if (entityType == "User")
            {
                List<User> results = await shareFile.ExecuteSearchAsync(searchTerm, apiService.SearchUsersAsync);
                shareFile.UpdateSearchResults(searchResults, results);
            }
            searchResults.ClearSelection();
        }

        public Action<string[]> OnItemSelect;
        private void searchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = searchResults.Rows[e.RowIndex];
                int columnCount = selectedRow.Cells.Count;
                string[] rowData = new string[columnCount];
                for (int i = 0; i < columnCount; i++)
                {
                    rowData[i] = selectedRow.Cells[i].Value?.ToString() ?? string.Empty;
                }
                OnItemSelect?.Invoke(rowData);
                this.Close();
            }
        }

        public string[] GetColumnNames()
        {
            return searchResults.Columns.Cast<DataGridViewColumn>().Select(column => column.Name).ToArray();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (searchResults.CurrentRow != null)
            {
                var selectedRow = searchResults.CurrentRow;
                int columnCount = selectedRow.Cells.Count;
                string[] rowData = new string[columnCount];
                for (int i = 0; i < columnCount; i++)
                {
                    rowData[i] = selectedRow.Cells[i].Value?.ToString() ?? string.Empty;
                }
                OnItemSelect?.Invoke(rowData);
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                shareFile.MoveToAdjacentCell(searchResults, e.KeyCode, searchBox);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.ActiveControl == searchBox && keyData == Keys.Enter)
            {
                searchBtn.PerformClick();
                return true;
            }
            if (this.ActiveControl == searchResults && keyData == Keys.Enter)
            {
                okBtn.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Down)
            {
                searchResults.Focus();
            }
            else if (e.KeyCode == Keys.F3)
            {
                searchBtn_Click(sender, e);
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
            searchBox.Focus();
        }

        private void searchResults_Leave(object sender, EventArgs e)
        {
            searchResults.ClearSelection();
        }
        //private CreateForm crf;
        private void addBtn_Click(object sender, EventArgs e)
        {
            //CreateForm crf = new CreateForm("Customer", apiService);
            //crf.TopLevel = false;
            //shareFile.SetForm(crf, this.Parent.Parent);
            //crf.BringToFront();
            OnIsAddNew?.Invoke(true);
            this.Close();
        }
    }
}
