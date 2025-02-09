namespace UI.Controls
{
    partial class ChatAI
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
            chatBox = new RichTextBox();
            sendBtn = new Button();
            inputBox = new TextBox();
            titlePanel = new Panel();
            caCloseL = new Label();
            titleLabel = new Label();
            homePanel.SuspendLayout();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.BackColor = Color.Black;
            homePanel.Controls.Add(chatBox);
            homePanel.Controls.Add(sendBtn);
            homePanel.Controls.Add(inputBox);
            homePanel.Controls.Add(titlePanel);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(300, 371);
            homePanel.TabIndex = 0;
            // 
            // chatBox
            // 
            chatBox.Location = new Point(3, 36);
            chatBox.Name = "chatBox";
            chatBox.Size = new Size(294, 287);
            chatBox.TabIndex = 4;
            chatBox.Text = "";
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(236, 338);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(61, 20);
            sendBtn.TabIndex = 3;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // inputBox
            // 
            inputBox.Location = new Point(3, 338);
            inputBox.Multiline = true;
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(227, 21);
            inputBox.TabIndex = 2;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.FromArgb(0, 0, 192);
            titlePanel.Controls.Add(caCloseL);
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Location = new Point(3, 4);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(294, 26);
            titlePanel.TabIndex = 0;
            // 
            // caCloseL
            // 
            caCloseL.AutoSize = true;
            caCloseL.Font = new Font("Informal Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            caCloseL.ForeColor = Color.FromArgb(192, 0, 0);
            caCloseL.Location = new Point(265, 2);
            caCloseL.Name = "caCloseL";
            caCloseL.Size = new Size(26, 22);
            caCloseL.TabIndex = 2;
            caCloseL.Text = "X";
            caCloseL.Click += caCloseL_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(80, 23);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Chat Us";
            // 
            // ChatAI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(homePanel);
            Name = "ChatAI";
            Size = new Size(300, 371);
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private Panel titlePanel;
        private Label titleLabel;
        private Button sendBtn;
        private TextBox inputBox;
        private Label caCloseL;
        private RichTextBox chatBox;
    }
}
