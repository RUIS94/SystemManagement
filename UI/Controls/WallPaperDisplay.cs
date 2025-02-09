using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Controls
{
    public partial class WallPaperDisplay : UserControl
    {
        public WallPaperDisplay()
        {
            InitializeComponent();
        }
        public CheckBox CheckBox { get; set; }
        public void SetWallpaperName(string name)
        {
            imagename.Text = name;
            CheckBox = imagename;
        }
        public void SetWallpaperImage(string imagePath)
        {
            try
            {
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}");
            }
        }
        public bool isSelected { get; set; }
        private void imagename_CheckedChanged(object sender, EventArgs e)
        {
            if (imagename.Checked) 
            { 
                isSelected = true; 
                //MessageBox.Show($"Selected {imagename.Text}"); 
            }
            else if (!imagename.Checked) 
            { 
                isSelected = false; 
                //MessageBox.Show($"Cancle selected {imagename.Text}"); 
            } 
            else 
            { 
                MessageBox.Show("UnKnow issue"); 
            }
        }

        private void WallPaperDisplay_Load(object sender, EventArgs e)
        {
            if (isSelected) 
            { 
                imagename.Checked = true; 
            }
        }
    }
}