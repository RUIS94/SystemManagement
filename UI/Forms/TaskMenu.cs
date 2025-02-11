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

namespace UI.Forms
{
    public partial class TaskMenu : Form
    {
        private readonly ApiService apiService;
        ShareFile sf = new ShareFile();
        private string RootP() { return sf.RP(); }
        public TaskMenu()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
        }

        private void dbBackupBtn_Click(object sender, EventArgs e)
        {
            string folderpath = $"{RootP()}dbBackupFolder";
            string databasePath = $"{RootP()}Model//Database.mdf";
            sf.BackuoDatabase(databasePath, folderpath);
        }

        private async void logViewBtn_Click(object sender, EventArgs e)
        {
            string folderpath = $"{RootP()}logFolder";
            List<OperationLog> logs = await apiService.GetAlllogsAsync();
            sf.ExportToCsv(logs, folderpath, "userOperationLogs");
        }
        
        private void exportFileBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
