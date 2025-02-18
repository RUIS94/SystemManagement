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
    public partial class MonthSelect : UserControl
    {
        public MonthSelect()
        {
            InitializeComponent();
        }
        private int? month;
        private string? selected;
        DateTime currentDate = DateTime.Now;
        private void MonthSelectcs_Load(object sender, EventArgs e)
        {
            yearL.Text = currentDate.Year.ToString();
        }
        DateTime tempD;
        private void leftL_Click(object sender, EventArgs e)
        {
            tempD = currentDate.AddYears(-1);
            currentDate = tempD;   
            yearL.Text = tempD.ToString("yyyy");
        }

        private void rightL_Click(object sender, EventArgs e)
        {
            tempD = currentDate.AddYears(1);
            currentDate = tempD;
            yearL.Text = tempD.ToString("yyyy");
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                month = GetMonth(btn.Name);
            }
            string year = yearL.Text;
            string monthS = month.ToString();
            selected = $"{monthS}/{year}";
            Parent.Controls.Remove(this);
        }
        private int GetMonth(string btnName)
        {
            switch (btnName)
            {
                case "btn1": return 1;
                case "btn2": return 2;
                case "btn3": return 3;
                case "btn4": return 4;
                case "btn5": return 5;
                case "btn6": return 6;
                case "btn7": return 7;
                case "btn8": return 8;
                case "btn9": return 9;
                case "btn10": return 10;
                case "btn11": return 11;
                case "btn12": return 12;
                default: return 0;
            }
        }
        public string SeleMonth()
        {
            return selected;
        }
    }
}
