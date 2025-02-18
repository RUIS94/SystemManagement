namespace UI.Controls
{
    partial class Lock
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
            lockPanel = new Panel();
            titlePanel = new Panel();
            okBtn = new Button();
            outLabel = new Label();
            passwordLabel = new Label();
            passwordBox = new TextBox();
            infoLabel = new Label();
            lockPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lockPanel
            // 
            lockPanel.BackColor = Color.FromArgb(64, 64, 64);
            lockPanel.Controls.Add(titlePanel);
            lockPanel.Controls.Add(okBtn);
            lockPanel.Controls.Add(outLabel);
            lockPanel.Controls.Add(passwordLabel);
            lockPanel.Controls.Add(passwordBox);
            lockPanel.Controls.Add(infoLabel);
            lockPanel.Dock = DockStyle.Fill;
            lockPanel.Location = new Point(0, 0);
            lockPanel.Name = "lockPanel";
            lockPanel.Size = new Size(280, 160);
            lockPanel.TabIndex = 1;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.FromArgb(0, 0, 192);
            titlePanel.Location = new Point(3, 3);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(274, 20);
            titlePanel.TabIndex = 5;
            // 
            // okBtn
            // 
            okBtn.BackColor = Color.FromArgb(64, 64, 64);
            okBtn.ForeColor = Color.White;
            okBtn.Location = new Point(190, 122);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 4;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = false;
            okBtn.Click += okBtn_Click;
            // 
            // outLabel
            // 
            outLabel.AutoSize = true;
            outLabel.BackColor = Color.Transparent;
            outLabel.Font = new Font("Arial", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            outLabel.ForeColor = Color.White;
            outLabel.Location = new Point(25, 126);
            outLabel.Name = "outLabel";
            outLabel.Size = new Size(54, 15);
            outLabel.TabIndex = 3;
            outLabel.Text = "Sign Out";
            outLabel.Click += outLabel_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(25, 84);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(63, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(94, 81);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(151, 23);
            passwordBox.TabIndex = 1;
            // 
            // infoLabel
            // 
            infoLabel.BackColor = Color.Transparent;
            infoLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infoLabel.ForeColor = Color.Blue;
            infoLabel.Location = new Point(25, 34);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(158, 27);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "Locked by";
            infoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lockPanel);
            Name = "Lock";
            Size = new Size(280, 160);
            lockPanel.ResumeLayout(false);
            lockPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel lockPanel;
        private Panel titlePanel;
        private Button okBtn;
        private Label outLabel;
        private Label passwordLabel;
        private TextBox passwordBox;
        private Label infoLabel;
    }
}
