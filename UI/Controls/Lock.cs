using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms;

namespace UI.Controls
{
    public partial class Lock : UserControl
    {
        ShareFile sf = new ShareFile();
        private string correctPassword;
        public event EventHandler LogoutRequested;
        public Lock(string storedPassword, string username)
        {
            InitializeComponent();
            sf.BindTextBoxEvent(this);
            correctPassword = storedPassword;
            infoLabel.Text = $"Lockecd By {username}";
        }
        //private MainForm main;
        private void outLabel_Click(object sender, EventArgs e)
        {
            LogoutRequested?.Invoke(this, EventArgs.Empty);
            Parent.Controls.Remove(this);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string password = passwordBox.Text;
            if (password == correctPassword)
            {
                Parent.Controls.Remove(this);
            }
            else
            {
                sf.ShowMessage("Password is incorrect");
                return;
            }
        }
    }
}
