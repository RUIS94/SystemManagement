namespace UI
{
    partial class EmailForm
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
            bodyBox = new TextBox();
            cancelBtn = new Button();
            subjectBox = new TextBox();
            label3 = new Label();
            ccBox = new TextBox();
            label2 = new Label();
            sendBtn = new Button();
            toBox = new TextBox();
            label1 = new Label();
            homePanel.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(bodyBox);
            homePanel.Controls.Add(cancelBtn);
            homePanel.Controls.Add(subjectBox);
            homePanel.Controls.Add(label3);
            homePanel.Controls.Add(ccBox);
            homePanel.Controls.Add(label2);
            homePanel.Controls.Add(sendBtn);
            homePanel.Controls.Add(toBox);
            homePanel.Controls.Add(label1);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(384, 361);
            homePanel.TabIndex = 0;
            // 
            // bodyBox
            // 
            bodyBox.Location = new Point(12, 173);
            bodyBox.Multiline = true;
            bodyBox.Name = "bodyBox";
            bodyBox.Size = new Size(360, 140);
            bodyBox.TabIndex = 8;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(209, 319);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(80, 30);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel F9";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // subjectBox
            // 
            subjectBox.Location = new Point(69, 119);
            subjectBox.Name = "subjectBox";
            subjectBox.Size = new Size(303, 23);
            subjectBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Subject:";
            // 
            // ccBox
            // 
            ccBox.Location = new Point(44, 66);
            ccBox.Name = "ccBox";
            ccBox.Size = new Size(328, 23);
            ccBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "CC:";
            // 
            // sendBtn
            // 
            sendBtn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sendBtn.Location = new Point(295, 319);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(80, 30);
            sendBtn.TabIndex = 2;
            sendBtn.Text = "Send F10";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // toBox
            // 
            toBox.Location = new Point(44, 37);
            toBox.Name = "toBox";
            toBox.Size = new Size(328, 23);
            toBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 0;
            label1.Text = "TO:";
            // 
            // EmailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(homePanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmailForm";
            Text = "Email";
            Load += EmailForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private TextBox ccBox;
        private Label label2;
        private Button sendBtn;
        private TextBox toBox;
        private Label label1;
        private TextBox bodyBox;
        private Button cancelBtn;
        private TextBox subjectBox;
        private Label label3;
    }
}