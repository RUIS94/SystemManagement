using UI.Controls;
using UI.Services;

namespace UI.Forms
{
    public partial class SupplementForm : Form
    {
        ShareFile sf = new ShareFile();
        public SupplementForm()
        {
            InitializeComponent();
        }
        private MainProgram main;
        private void SupplementForm_Load(object sender, EventArgs e)
        {
            main = new MainProgram();
            sf.SetForm(main, mainPanel);
        }
    }
}
