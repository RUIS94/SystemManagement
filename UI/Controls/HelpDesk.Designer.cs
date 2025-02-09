namespace UI.Controls
{
    partial class HelpDesk
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
            closeLabel = new Label();
            closeBtn = new Button();
            webBtn = new Button();
            toolDBtn = new Button();
            titleLabel = new Label();
            homePanel.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(toolDBtn);
            homePanel.Controls.Add(webBtn);
            homePanel.Controls.Add(closeBtn);
            homePanel.Controls.Add(panel);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(350, 200);
            homePanel.TabIndex = 0;
            // 
            // panel
            // 
            panel.BackColor = Color.MidnightBlue;
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(closeLabel);
            panel.Location = new Point(3, 3);
            panel.Name = "panel";
            panel.Size = new Size(344, 24);
            panel.TabIndex = 1;
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeLabel.ForeColor = Color.Red;
            closeLabel.Location = new Point(318, 0);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(23, 24);
            closeLabel.TabIndex = 2;
            closeLabel.Text = "X";
            closeLabel.Click += closeLabel_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Black;
            closeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(269, 166);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 31);
            closeBtn.TabIndex = 3;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // webBtn
            // 
            webBtn.BackColor = Color.MediumBlue;
            webBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            webBtn.ForeColor = Color.White;
            webBtn.Location = new Point(69, 53);
            webBtn.Name = "webBtn";
            webBtn.Size = new Size(207, 40);
            webBtn.TabIndex = 4;
            webBtn.Text = "Help WebSite";
            webBtn.UseVisualStyleBackColor = false;
            webBtn.Click += webBtn_Click;
            // 
            // toolDBtn
            // 
            toolDBtn.BackColor = Color.MediumBlue;
            toolDBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolDBtn.ForeColor = Color.White;
            toolDBtn.Location = new Point(69, 99);
            toolDBtn.Name = "toolDBtn";
            toolDBtn.Size = new Size(207, 40);
            toolDBtn.TabIndex = 5;
            toolDBtn.Text = "Download tool";
            toolDBtn.UseVisualStyleBackColor = false;
            toolDBtn.Click += toolDBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(3, 6);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(60, 15);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Help Desk";
            // 
            // HelpDesk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(homePanel);
            Name = "HelpDesk";
            Size = new Size(350, 200);
            homePanel.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private Button webBtn;
        private Button closeBtn;
        private Panel panel;
        private Label closeLabel;
        private Button toolDBtn;
        private Label titleLabel;
    }
}
