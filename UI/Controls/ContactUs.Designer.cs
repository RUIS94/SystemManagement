namespace UI
{
    partial class ContactUs
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
            homePanel = new Panel();
            panel = new Panel();
            closeBtn1 = new Button();
            emailLabel = new Label();
            webLinkLabel = new LinkLabel();
            briPhLabel = new Label();
            melPhLabel = new Label();
            sydPhLabel = new Label();
            closeBtn2 = new Button();
            titleLabel = new Label();
            homePanel.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(panel);
            homePanel.Controls.Add(emailLabel);
            homePanel.Controls.Add(webLinkLabel);
            homePanel.Controls.Add(briPhLabel);
            homePanel.Controls.Add(melPhLabel);
            homePanel.Controls.Add(sydPhLabel);
            homePanel.Controls.Add(closeBtn2);
            homePanel.Controls.Add(titleLabel);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(400, 400);
            homePanel.TabIndex = 0;
            // 
            // panel
            // 
            panel.BackColor = Color.MidnightBlue;
            panel.Controls.Add(closeBtn1);
            panel.Location = new Point(3, 3);
            panel.Name = "panel";
            panel.Size = new Size(394, 26);
            panel.TabIndex = 8;
            // 
            // closeBtn1
            // 
            closeBtn1.BackColor = Color.Red;
            closeBtn1.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            closeBtn1.ForeColor = Color.White;
            closeBtn1.Location = new Point(371, 3);
            closeBtn1.Name = "closeBtn1";
            closeBtn1.Size = new Size(20, 20);
            closeBtn1.TabIndex = 0;
            closeBtn1.Text = "X";
            closeBtn1.TextAlign = ContentAlignment.TopCenter;
            closeBtn1.UseVisualStyleBackColor = false;
            closeBtn1.Click += closeBtn1_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            emailLabel.Location = new Point(54, 306);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(157, 15);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "email address will show here";
            emailLabel.Click += emailLabel_Click;
            // 
            // webLinkLabel
            // 
            webLinkLabel.AutoSize = true;
            webLinkLabel.Location = new Point(54, 337);
            webLinkLabel.Name = "webLinkLabel";
            webLinkLabel.Size = new Size(124, 15);
            webLinkLabel.TabIndex = 6;
            webLinkLabel.TabStop = true;
            webLinkLabel.Text = "web url will show here";
            webLinkLabel.LinkClicked += webLinkLabel_LinkClicked;
            // 
            // briPhLabel
            // 
            briPhLabel.AutoSize = true;
            briPhLabel.Location = new Point(54, 190);
            briPhLabel.Name = "briPhLabel";
            briPhLabel.Size = new Size(167, 15);
            briPhLabel.TabIndex = 5;
            briPhLabel.Text = "Brisbane             000-000-0000  ";
            // 
            // melPhLabel
            // 
            melPhLabel.AutoSize = true;
            melPhLabel.Location = new Point(54, 150);
            melPhLabel.Name = "melPhLabel";
            melPhLabel.Size = new Size(168, 15);
            melPhLabel.TabIndex = 4;
            melPhLabel.Text = "Melbourne         000-000-0000  ";
            // 
            // sydPhLabel
            // 
            sydPhLabel.AutoSize = true;
            sydPhLabel.Location = new Point(54, 113);
            sydPhLabel.Name = "sydPhLabel";
            sydPhLabel.Size = new Size(166, 15);
            sydPhLabel.TabIndex = 3;
            sydPhLabel.Text = "Sydney               000-000-0000  ";
            // 
            // closeBtn2
            // 
            closeBtn2.BackColor = Color.FromArgb(64, 64, 64);
            closeBtn2.ForeColor = Color.White;
            closeBtn2.Location = new Point(317, 367);
            closeBtn2.Name = "closeBtn2";
            closeBtn2.Size = new Size(80, 30);
            closeBtn2.TabIndex = 2;
            closeBtn2.Text = "Close";
            closeBtn2.UseVisualStyleBackColor = false;
            closeBtn2.Click += closeBtn2_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 18F);
            titleLabel.Location = new Point(23, 57);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(177, 27);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Support Centre";
            // 
            // ContactUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(homePanel);
            Name = "ContactUs";
            Size = new Size(400, 400);
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private Label titleLabel;
        private Button closeBtn1;
        private Button closeBtn2;
        private Label sydPhLabel;
        private LinkLabel webLinkLabel;
        private Label briPhLabel;
        private Label melPhLabel;
        private Label emailLabel;
        private Panel panel;
    }
}
