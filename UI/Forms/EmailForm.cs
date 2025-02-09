
using UI.Services;

namespace UI
{
    public partial class EmailForm : Form
    {
        ShareFile shareFile = new ShareFile();
        private string entityType;
        public EmailForm(string entityType)
        {
            InitializeComponent();
            this.entityType = entityType;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            SendEmail();
            shareFile.ShowMessage("Sent");
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void WriteEmail(string emailaddress, string subject, string body)
        {
            if (entityType == "Help")
            {
                toBox.Text = emailaddress;
                subjectBox.Text = subject;
                bodyBox.Text = body;
            }
            else if (entityType == "Request Video")
            {
                toBox.Text = emailaddress;
                subjectBox.Text = subject;
                bodyBox.Text = body;
            }
            else
            {
                toBox.Text = null;
                subjectBox.Text = null;
                bodyBox.Text = null;
            }
        }
        private void SendEmail()
        {
            EmailService emailService = new EmailService();
            string subject = subjectBox.Text.Trim();
            string body = bodyBox.Text;
            string toEmail = toBox.Text.Trim();
            try
            {
                emailService.SendEmail(toEmail, subject, body, null);
            }
            catch (Exception ex)
            {
                shareFile.HandleException(ex);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F9:
                    cancelBtn.PerformClick();
                    return true;
                case Keys.F10:
                    sendBtn.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void EmailForm_Load(object sender, EventArgs e)
        {
            shareFile.BindTextBoxEvent(this);
        }
    }
}