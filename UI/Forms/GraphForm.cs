using System.Windows.Forms.DataVisualization.Charting;
using Model;
using UI.Services;

namespace UI
{
    public partial class GraphForm : Form
    {
        private readonly ApiService apiService;
        ShareFile shareFile = new ShareFile();
        private string entityType;
        private string productId;
        public GraphForm(string entityType, string id, ApiService apiService)
        {
            InitializeComponent();
            this.entityType = entityType;
            this.productId = id;
            this.apiService = apiService;
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            LoadResults(productId);
        }

        public async void LoadResults(string id)
        {
            chart.Series.Clear(); 

            if (entityType == "Product")
            {
                List<InventoryChange> results = await shareFile.ExecuteSearchAsync<InventoryChange>(id, apiService.GetAllByIDAsync);
                if (results.Count == 0)
                {
                    MessageBox.Show("No inventory changes found.");
                    return; 
                }
                var series = new Series
                {
                    Name = "Inventory Changes",
                    ChartType = SeriesChartType.Spline,
                    XValueType = ChartValueType.DateTime 
                };
                chart.Series.Add(series); 
                int currentStock = 0;
                foreach (var change in results)
                {
                    if (DateTime.TryParse(change.Date, out DateTime dateTime) && int.TryParse(change.Qty, out int qtyChange))
                    {
                        currentStock += qtyChange;
                        series.Points.AddXY(dateTime.ToOADate(), currentStock);
                    }
                }
                DateTime firstDate = results.Min(r => DateTime.Parse(r.Date));
                DateTime lastDate = results.Max(r => DateTime.Parse(r.Date));
                if (firstDate.Month == lastDate.Month && firstDate.Year == lastDate.Year)
                {
                    chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MMM"; 
                    chart.ChartAreas[0].AxisX.Interval = 1;
                    //chart.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
                }
                else
                {
                    chart.ChartAreas[0].AxisX.LabelStyle.Format = "MMM/yyyy"; 
                    chart.ChartAreas[0].AxisX.Interval = 30;
                }
                chart.ChartAreas[0].AxisY.Title = "Stock";
                chart.Invalidate(); 
            }
        }
    }
}
