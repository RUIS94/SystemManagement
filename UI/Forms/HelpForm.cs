using Model;
using UI.Controls;
using UI.Services;

namespace UI
{
    public partial class HelpForm : Form
    {
        private readonly ApiService apiService;
        ShareFile sf = new ShareFile();
        public HelpForm()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            apiService = new ApiService(httpClient);
        }
        private ContactUs cu;
        private void cuLabel_Click(object sender, EventArgs e)
        {
            cu = new ContactUs();
            homePanel.Enabled = false;
            this.ControlRemoved += (s, args) => homePanel.Enabled = true;
            sf.SetForm(cu, this);
        }
        private HelpDesk hd;
        private void hdLabel_Click(object sender, EventArgs e)
        {
            hd = new HelpDesk();
            homePanel.Enabled = false;
            this.ControlRemoved += (s, args) => homePanel.Enabled = true;
            sf.SetForm(hd, this);
        }
        private EmailForm email;
        private string emailaddress = "surui1119@gmail.com";
        private string subject = "Video Request From: TEST SYSTEM";
        private string body = "Hi Support,\r\n\r\nCan you create a video about: ";
        private void rvLabel_Click(object sender, EventArgs e)
        {
            if (email == null || email.IsDisposed)
            {
                email = new EmailForm("Request Video");
                email.TopLevel = false;
                sf.SetForm(email, this.Parent);
                email.WriteEmail(emailaddress, subject, body);
            }
            else
            {
                email.BringToFront();
            }
        }
        private void HelpForm_Load(object sender, EventArgs e)
        {
            string rootpath = sf.RP();
            string imagefilepath = $"{rootpath}toolsImage\\";
            LoadVideoList();
            sf.BindTextBoxEvent(this);
            pictureBox1.Image = Image.FromFile($"{imagefilepath}1.png");
            pictureBox2.Image = Image.FromFile($"{imagefilepath}2.png");
            pictureBox3.Image = Image.FromFile($"{imagefilepath}3.png");
            pictureBox4.Image = Image.FromFile($"{imagefilepath}4.png");
        }
        private async void LoadVideoList()
        {
            List<HelpDocs> results = await apiService.GetAllHelpDocs();
            foreach (HelpDocs docs in results) 
            {
                docsList.Rows.Add();
                int lastRowIndex = docsList.Rows.Count - 1;
                docsList.Rows[lastRowIndex].Cells["name"].Value = docs.Name;
                docsList.Rows[lastRowIndex].Cells["type"].Value = GetDocImage(docs.Type);
                DataGridViewLinkCell linkCell = (DataGridViewLinkCell)docsList.Rows[lastRowIndex].Cells["link"];
                linkCell.Value = docs.Link;
            }
            sf.RewriteSequence(docsList);
            //string rootpath = sf.RP();
            //string filePath = $"{rootpath}helpVideos.txt";
            //string imagefilepath = $"{rootpath}toolsImage\\";
            //if (File.Exists(filePath))
            //{
            //    string json = File.ReadAllText(filePath);
            //    allDocs = JsonConvert.DeserializeObject<List<HelpDocs>>(json);
            //    docsList.Rows.Clear();
            //    docsList.Columns["type"].DefaultCellStyle.NullValue = null;

            //    foreach (var doc in allDocs)
            //    {
            //        docsList.Rows.Add();
            //        int lastRowIndex = docsList.Rows.Count - 1;
            //        docsList.Rows[lastRowIndex].Cells["name"].Value = doc.Name;
            //        docsList.Rows[lastRowIndex].Cells["type"].Value = GetDocImage(doc.Type);
            //        DataGridViewLinkCell linkCell = (DataGridViewLinkCell)docsList.Rows[lastRowIndex].Cells["link"];
            //        linkCell.Value = doc.Link;
            //    }
            //    sf.RewriteSequence(docsList);
            //}
        }

        private void videosList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linkColumnIndex = 3;
            if (e.ColumnIndex == linkColumnIndex && e.RowIndex >= 0)
            {
                string link = docsList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                sf.AccessBrowser(link);
            }
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
        }
        //private List<HelpDocs> allDocs;
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                LoadVideoList();
                return;
            }
            FilterDocsList(searchText);
        }
        private async void FilterDocsList(string searchText)
        {
            docsList.Rows.Clear();
            //var filteredDocs = allDocs
            //    .Where(doc => doc.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
            //    .ToList();
            var filteredDocs = await apiService.GetHelpDocsByTerm(searchText);
            foreach (var doc in filteredDocs)
            {
                docsList.Rows.Add();
                int lastRowIndex = docsList.Rows.Count - 1;
                docsList.Rows[lastRowIndex].Cells["name"].Value = doc.Name;
                docsList.Rows[lastRowIndex].Cells["type"].Value = GetDocImage(doc.Type);
                DataGridViewLinkCell linkCell = (DataGridViewLinkCell)docsList.Rows[lastRowIndex].Cells["link"];
                linkCell.Value = doc.Link;
            }
        }
        private Image GetDocImage(string docType)
        {
            string imagefilepath = $"{sf.RP()}toolsImage\\";
            switch (docType)
            {
                case "video":
                    return Image.FromFile($"{imagefilepath}video.png");
                case "text":
                    return Image.FromFile($"{imagefilepath}doc.png");
                case "web":
                    return Image.FromFile($"{imagefilepath}web.png");
                default:
                    return null;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sf.AccessBrowser("https://www.youtube.com/watch?v=GcFJjpMFJvI");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sf.AccessBrowser("https://www.youtube.com/watch?v=GSr7BpoMKBg");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sf.AccessBrowser("https://www.youtube.com/watch?v=ravLFzIguCM");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sf.AccessBrowser("https://www.w3schools.com/css/default.asp");
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                searchBox.Focus();
            }
        }
        private ChatAI chatai;
        private void chatL_Click(object sender, EventArgs e)
        {
            chatai = new ChatAI();
            homePanel.Enabled = false;
            this.ControlRemoved += (s, args) => homePanel.Enabled = true;
            sf.SetForm(chatai, this);
        }
    }
}