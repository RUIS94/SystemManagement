using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Net.WebRequestMethods;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UI
{
    public partial class ContactUs : UserControl
    {
        ShareFile sf = new ShareFile();
        public ContactUs()
        {
            InitializeComponent();
        }

        private void closeBtn1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void closeBtn2_Click(object sender, EventArgs e)
        {
            closeBtn1.PerformClick();
        }

        private string emailaddress = "surui1119@gmail.com";
        private string subject = "Help: System";
        private string body = "Hi Support,\r\n\r\nHelp me with:";

        private EmailForm email;
        private void emailLabel_Click(object sender, EventArgs e)
        {
            if (email == null || email.IsDisposed)
            {
                email = new EmailForm("Help");
                email.TopLevel = false;
                sf.SetForm(email, this.Parent.Parent);
                email.WriteEmail(emailaddress, subject, body);
            }
            else
            {
                email.BringToFront();
            }
        }

        private void webLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = "https://www.google.com.au/";
            webLinkLabel.Text = target;
            sf.AccessBrowser(target);
        }
    }
}