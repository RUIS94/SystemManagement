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

namespace UI
{
    public partial class SupplierOrder : Form
    {
        ShareFile shareFile = new ShareFile();
        private readonly ApiService apiService;
        public SupplierOrder()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
        }

        private void searchBtn1_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn2_Click(object sender, EventArgs e)
        {

        }

        private void deleprod_Click(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        private void SupplierOrder_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
        }
    }
}
