namespace UI
{
    partial class QuickAddForm
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
            label6 = new Label();
            emailBox = new TextBox();
            notesBox = new TextBox();
            phoneBox = new TextBox();
            label5 = new Label();
            addressBox2 = new TextBox();
            label4 = new Label();
            addressBox1 = new TextBox();
            label3 = new Label();
            nameBox = new TextBox();
            label2 = new Label();
            cancelBtn = new Button();
            addBtn = new Button();
            idBox = new TextBox();
            label1 = new Label();
            homePanel.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(label6);
            homePanel.Controls.Add(emailBox);
            homePanel.Controls.Add(notesBox);
            homePanel.Controls.Add(phoneBox);
            homePanel.Controls.Add(label5);
            homePanel.Controls.Add(addressBox2);
            homePanel.Controls.Add(label4);
            homePanel.Controls.Add(addressBox1);
            homePanel.Controls.Add(label3);
            homePanel.Controls.Add(nameBox);
            homePanel.Controls.Add(label2);
            homePanel.Controls.Add(cancelBtn);
            homePanel.Controls.Add(addBtn);
            homePanel.Controls.Add(idBox);
            homePanel.Controls.Add(label1);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(404, 355);
            homePanel.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 212);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 14;
            label6.Text = "Notes";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(75, 172);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(242, 23);
            emailBox.TabIndex = 13;
            // 
            // notesBox
            // 
            notesBox.Location = new Point(75, 208);
            notesBox.Multiline = true;
            notesBox.Name = "notesBox";
            notesBox.Size = new Size(317, 91);
            notesBox.TabIndex = 12;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(75, 143);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(242, 23);
            phoneBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 175);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // addressBox2
            // 
            addressBox2.Location = new Point(75, 114);
            addressBox2.Name = "addressBox2";
            addressBox2.Size = new Size(242, 23);
            addressBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 151);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Phone";
            // 
            // addressBox1
            // 
            addressBox1.Location = new Point(75, 85);
            addressBox1.Name = "addressBox1";
            addressBox1.Size = new Size(242, 23);
            addressBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(75, 56);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(242, 23);
            nameBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 59);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(206, 305);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(90, 38);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel F9";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(302, 305);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(90, 38);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add F10";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // idBox
            // 
            idBox.Location = new Point(75, 27);
            idBox.Name = "idBox";
            idBox.Size = new Size(100, 23);
            idBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "CustCode";
            // 
            // QuickAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 355);
            Controls.Add(homePanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QuickAddForm";
            Text = "QuickAddForm";
            Load += this.QuickAddForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private TextBox notesBox;
        private TextBox phoneBox;
        private Label label5;
        private TextBox addressBox2;
        private Label label4;
        private TextBox addressBox1;
        private Label label3;
        private TextBox nameBox;
        private Label label2;
        private Button cancelBtn;
        private Button addBtn;
        private TextBox idBox;
        private Label label1;
        private Label label6;
        private TextBox emailBox;
    }
}