using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using UI.Services;

namespace UI
{
    public partial class TransactionForm : Form
    {
        private string entityType;
        private string searchId;
        ShareFile shareFile = new ShareFile();
        public TransactionForm(string entityType, string searchId)
        {
            InitializeComponent();
            this.entityType = entityType;
            this.searchId = searchId;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string orderID = orderIDBox.Text.Trim();
            string startdate = dateBox1.Text.Trim();
            string enddate = dateBox2.Text.Trim();

            if (summaryList.DataSource is List<Order> orders)
            {
                DateTime? startDate = null;
                DateTime? endDate = null;
                if (DateTime.TryParse(startdate, out DateTime parsedStart))
                {
                    startDate = parsedStart.Date;
                }
                if (DateTime.TryParse(enddate, out DateTime parsedEnd))
                {
                    endDate = parsedEnd.Date;
                }
                var filteredOrders = orders
                    .Where(order =>
                    {
                        bool matchesOrderID = string.IsNullOrEmpty(orderID) || order.OrderID.Contains(orderID);
                        bool matchesDateRange = true;

                        if (DateTime.TryParse(order.OrderDate, out DateTime parsedOrderDate))
                        {
                            DateTime orderOnlyDate = parsedOrderDate.Date;
                            matchesDateRange = (!startDate.HasValue || orderOnlyDate >= startDate) &&
                                               (!endDate.HasValue || orderOnlyDate <= endDate);
                        }

                        return matchesOrderID && matchesDateRange;
                    })
                    .ToList();
                summaryList.DataSource = null;
                summaryList.DataSource = filteredOrders;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            LoadSearchResults(searchId);
            tabControl.SelectedTab = summaryTab;
        }

        private void calendarBtn1_Click(object sender, EventArgs e)
        {
            calendar1.Visible = true;
        }

        private void calendarBtn2_Click(object sender, EventArgs e)
        {
            calendar2.Visible = true;
        }
        private void ClearTextBox()
        {
            transIDBox.Text = string.Empty;
            orderIDBox.Text = string.Empty;
            referBox.Text = string.Empty;
            prodIDBox.Text = string.Empty;
            dateBox1.Text = string.Empty;
            dateBox2.Text = string.Empty;
        }
        private void calendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var startDate = calendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            dateBox1.Text = startDate;
            calendar1.Visible = false;
        }

        private void calendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            var endDate = calendar2.SelectionRange.End.ToString("yyyy-MM-dd");
            dateBox2.Text = endDate;
            calendar2.Visible = false;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
            if (entityType == "Customer")
            {
                Text = "Customer Transactions:";
            }
        }

        public async void LoadSearchResults(string custId)
        {
            ApiService apiService = new ApiService(new HttpClient());
            if (entityType == "Customer")
            {
                List<Order> orders = await apiService.SearchOrderAsync(custId);
                summaryList.DataSource = orders;
            }
        }

        private async void summaryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (entityType == "Customer")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = summaryList.Rows[e.RowIndex];
                    string orderID = row.Cells["OrderID"].Value.ToString();
                    ApiService apiService = new ApiService(new HttpClient());

                    try
                    {
                        List<OrderDetail> orderDetails = await apiService.SearchOrderDetailsAsync(orderID);
                        detailList.DataSource = orderDetails;
                        tabControl.SelectedTab = detailTab;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }
        private void transPage_Click(object sender, EventArgs e)
        {
            if (calendar1.Visible || calendar2.Visible)
            {
                calendar1.Visible = false;
                calendar2.Visible = false;
            }
        }
    }
}
