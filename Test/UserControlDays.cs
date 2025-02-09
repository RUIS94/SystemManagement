using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class UserControlDays : UserControl
    {
        private bool isSelected = false;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbdays.Text = numday.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            isSelected = !isSelected;
            UpdateHighlight();
        }
        private void UpdateHighlight()
        {
            if (isSelected)
            {
                this.BackColor = Color.LightBlue;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
        public void Select()
        {
            this.BackColor = Color.LightBlue;
            isSelected = true;
        }

        public void Deselect()
        {
            this.BackColor = Color.White;
            isSelected = false;
        }
    }
}
