namespace UI
{
    partial class SignForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            homePanel = new Panel();
            passwordBox = new TextBox();
            label2 = new Label();
            cancelBrn = new Button();
            externalBtn = new RadioButton();
            internalBtn = new RadioButton();
            okBtn = new Button();
            usernameBox = new TextBox();
            label1 = new Label();
            comboBox = new ComboBox();
            homePanel.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(passwordBox);
            homePanel.Controls.Add(label2);
            homePanel.Controls.Add(cancelBrn);
            homePanel.Controls.Add(externalBtn);
            homePanel.Controls.Add(internalBtn);
            homePanel.Controls.Add(okBtn);
            homePanel.Controls.Add(usernameBox);
            homePanel.Controls.Add(label1);
            homePanel.Controls.Add(comboBox);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(284, 261);
            homePanel.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(91, 123);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(160, 23);
            passwordBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // cancelBrn
            // 
            cancelBrn.Location = new Point(89, 206);
            cancelBrn.Name = "cancelBrn";
            cancelBrn.Size = new Size(74, 32);
            cancelBrn.TabIndex = 6;
            cancelBrn.Text = "Cancel";
            cancelBrn.UseVisualStyleBackColor = true;
            cancelBrn.Click += cancelBrn_Click;
            // 
            // externalBtn
            // 
            externalBtn.AutoSize = true;
            externalBtn.Location = new Point(184, 166);
            externalBtn.Name = "externalBtn";
            externalBtn.Size = new Size(67, 19);
            externalBtn.TabIndex = 5;
            externalBtn.TabStop = true;
            externalBtn.Text = "External";
            externalBtn.UseVisualStyleBackColor = true;
            // 
            // internalBtn
            // 
            internalBtn.AutoSize = true;
            internalBtn.Location = new Point(89, 166);
            internalBtn.Name = "internalBtn";
            internalBtn.Size = new Size(65, 19);
            internalBtn.TabIndex = 4;
            internalBtn.TabStop = true;
            internalBtn.Text = "Internal";
            internalBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(198, 206);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(74, 32);
            okBtn.TabIndex = 3;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(91, 73);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(160, 23);
            usernameBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(12, 12);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(260, 23);
            comboBox.TabIndex = 0;
            // 
            // SignForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(homePanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignForm";
            Text = "SignForm";
            Load += SignForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private RadioButton internalBtn;
        private Button okBtn;
        private TextBox usernameBox;
        private Label label1;
        private ComboBox comboBox;
        private RadioButton externalBtn;
        private TextBox passwordBox;
        private Label label2;
        private Button cancelBrn;
    }
}