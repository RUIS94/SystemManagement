namespace UI.Forms
{
    partial class CreateForm
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
            panel1 = new Panel();
            cancelBtn = new Button();
            nameBox = new TextBox();
            label2 = new Label();
            okBtn = new Button();
            idBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(okBtn);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 121);
            panel1.TabIndex = 0;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(122, 92);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(50, 26);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "C";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(122, 52);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(170, 23);
            nameBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 55);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "name";
            // 
            // okBtn
            // 
            okBtn.Location = new Point(242, 92);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(50, 26);
            okBtn.TabIndex = 5;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // idBox
            // 
            idBox.Location = new Point(121, 22);
            idBox.Name = "idBox";
            idBox.Size = new Size(171, 23);
            idBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 25);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 3;
            label1.Text = "id";
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(374, 142);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateForm";
            Text = "CreateForm";
            Load += CreateForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button cancelBtn;
        private TextBox nameBox;
        private Label label2;
        private Button okBtn;
        private TextBox idBox;
        private Label label1;
    }
}