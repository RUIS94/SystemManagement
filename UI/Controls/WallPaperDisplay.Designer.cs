﻿namespace UI.Controls
{
    partial class WallPaperDisplay
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            imagename = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(268, 159);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // imagename
            // 
            imagename.AutoSize = true;
            imagename.Location = new Point(4, 169);
            imagename.Name = "imagename";
            imagename.Size = new Size(77, 19);
            imagename.TabIndex = 1;
            imagename.Text = "checkBox";
            imagename.UseVisualStyleBackColor = true;
            imagename.CheckedChanged += imagename_CheckedChanged;
            // 
            // WallPaperDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(imagename);
            Controls.Add(pictureBox);
            Name = "WallPaperDisplay";
            Size = new Size(274, 190);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private CheckBox imagename;
    }
}
