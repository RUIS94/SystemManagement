using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Controls;

namespace UI.Forms
{
    public partial class MainForm : Form
    {
        ShareFile sf = new ShareFile();
        public MainForm()
        {
            InitializeComponent();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            SettingForm setform = new SettingForm();
            setform.TopLevel = true;
            setform.FormClosed += (s, args) => this.Enabled = true;
            setform.ShowDialog();
        }
        private static SupplementForm? suf;
        private void newform_Click(object sender, EventArgs e)
        {
            if (suf == null || suf.IsDisposed) 
            {
                suf = new SupplementForm();
                suf.FormClosed += (s, args) => suf = null;
                suf.Show();
            }
            else
            {
                suf.Activate();
            }
        }
        private MainProgram main;
        private void newtab_Click(object sender, EventArgs e)
        {
            int currentWidth = titlePanel.Width;
            if (tabControl.TabPages.Count < 3)
            {
                TabPage newTab = new TabPage("New Page");
                main = new MainProgram();
                newTab.Controls.Add(main);
                tabControl.TabPages.Add(newTab);
                tabControl.SelectedTab = newTab;
                deleBtn.Visible = true;
                titlePanel.Width = currentWidth - 70;
                titlePanel.Location = new Point(titlePanel.Location.X + 70, titlePanel.Location.Y);
            }
            else
            {
                sf.ShowMessage("You can open 3 tabs only!");
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            main = new MainProgram();
            homePage.Controls.Add(main);
            //sf.SetForm(main, homePage);
        }

        private void deleBtn_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl.SelectedTab;
            if (selectedTab == null)
            {
                sf.ShowMessage("Please select a page");
                return;
            }
            if (tabControl.TabPages.Count <= 1)
            {
                sf.ShowMessage("Cannot delete the last page.");
                return;
            }
            if (CanDeleteTab(selectedTab))
            {
                RemoveSelectedTab(selectedTab);
            }
            else
            {
                sf.ShowMessage("Can not delete this page");
            }
        }
        private bool CanDeleteTab(TabPage tab)
        {
            return tab.Text != "Home Page";
        }
        private void RemoveSelectedTab(TabPage tab)
        {
            tabControl.TabPages.Remove(tab);
            titlePanel.Width += 70;
            titlePanel.Location = new Point(titlePanel.Location.X - 70, titlePanel.Location.Y);
            if (tabControl.TabPages.Count == 1 && tabControl.TabPages[0].Text == "Home Page")
            {
                deleBtn.Visible = false;
            }
        }
    }
}
