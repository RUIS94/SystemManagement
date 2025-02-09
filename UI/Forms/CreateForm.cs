using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Services;

namespace UI.Forms
{
    public partial class CreateForm : Form
    {
        private string entityType;
        private readonly ApiService apiService;
        ShareFile shareFile = new ShareFile();
        public CreateForm(string entityType, ApiService apiService)
        {
            InitializeComponent();
            this.entityType = entityType;
            this.apiService = apiService;
            SetUpForm();
        }
        private async void SetUpForm()
        {
            if (entityType == "Customer")
            {
                Text = "Create a new customer";
                label1.Text = "Cust Code";
                int newId = await shareFile.GenerateId(apiService, "Customers", "CustomerID");
                idBox.Text = newId.ToString("D5");
                label2.Text = "Cust Name";

            }
            else if (entityType == "Product")
            {
                Text = "Create a new product";
                label1.Text = "Prod Code";
                int newId = await shareFile.GenerateId(apiService, "Products", "ProductCode");
                idBox.Text = newId.ToString("D10");
                label2.Text = "Prod Name";
            }
            else if (entityType == "Supplier")
            {
                Text = "Create a new supplier";
                label1.Text = "Supp Code";
                int newId = await shareFile.GenerateId(apiService, "Suppliers", "SupplierCode");
                idBox.Text = newId.ToString("D5");
                label2.Text = "Supp Name";
            }
            else if (entityType == "User")
            {
                Text = "Create a new User";
                label1.Text = "User Code";
                int newId = await shareFile.GenerateId(apiService, "Users", "UserID");
                idBox.Text = newId.ToString("D5");
                label2.Text = "User Name";
            }
        }
        public Action<string, string> OnDataSubmitted;
        private QuickAddForm qaf;
        private void okBtn_Click(object sender, EventArgs e)
        {
            string code = idBox.Text.Trim();
            string name = nameBox.Text.Trim();
            OnDataSubmitted?.Invoke(code, name);
            //if (!isCustOpen())
            //{
            //    qaf = new QuickAddForm();
            //    qaf.TopLevel = false;
            //    shareFile.SetForm(qaf, this.Parent.Parent);
            //}
            this.Close();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
        }
    }
}
