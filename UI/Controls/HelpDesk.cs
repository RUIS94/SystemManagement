using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Controls
{
    public partial class HelpDesk : UserControl
    {
        ShareFile sf = new ShareFile();
        public HelpDesk()
        {
            InitializeComponent();
        }

        private void webBtn_Click(object sender, EventArgs e)
        {
            sf.AccessBrowser("https://peachv12.com.au/");
        }

        private void toolDBtn_Click(object sender, EventArgs e)
        {
            sf.AccessBrowser("https://sos.splashtop.com/en/sos-download");
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            closeBtn.PerformClick();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
