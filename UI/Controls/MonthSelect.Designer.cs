namespace UI.Controls
{
    partial class MonthSelect
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
            monthsContainer = new FlowLayoutPanel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            btn11 = new Button();
            btn12 = new Button();
            yearL = new Label();
            leftL = new Label();
            rightL = new Label();
            monthsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // monthsContainer
            // 
            monthsContainer.Controls.Add(btn1);
            monthsContainer.Controls.Add(btn2);
            monthsContainer.Controls.Add(btn3);
            monthsContainer.Controls.Add(btn4);
            monthsContainer.Controls.Add(btn5);
            monthsContainer.Controls.Add(btn6);
            monthsContainer.Controls.Add(btn7);
            monthsContainer.Controls.Add(btn8);
            monthsContainer.Controls.Add(btn9);
            monthsContainer.Controls.Add(btn10);
            monthsContainer.Controls.Add(btn11);
            monthsContainer.Controls.Add(btn12);
            monthsContainer.Location = new Point(3, 36);
            monthsContainer.Name = "monthsContainer";
            monthsContainer.Size = new Size(384, 139);
            monthsContainer.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 40);
            btn1.TabIndex = 0;
            btn1.Text = "Jan";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Button_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(99, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(90, 40);
            btn2.TabIndex = 1;
            btn2.Text = "Feb";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Button_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(195, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 40);
            btn3.TabIndex = 2;
            btn3.Text = "Mar";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Button_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(291, 3);
            btn4.Name = "btn4";
            btn4.Size = new Size(90, 40);
            btn4.TabIndex = 3;
            btn4.Text = "Apr";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Button_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(3, 49);
            btn5.Name = "btn5";
            btn5.Size = new Size(90, 40);
            btn5.TabIndex = 4;
            btn5.Text = "May";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Button_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(99, 49);
            btn6.Name = "btn6";
            btn6.Size = new Size(90, 40);
            btn6.TabIndex = 5;
            btn6.Text = "Jun";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Button_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(195, 49);
            btn7.Name = "btn7";
            btn7.Size = new Size(90, 40);
            btn7.TabIndex = 6;
            btn7.Text = "Jul";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Button_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(291, 49);
            btn8.Name = "btn8";
            btn8.Size = new Size(90, 40);
            btn8.TabIndex = 7;
            btn8.Text = "Aug";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Button_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(3, 95);
            btn9.Name = "btn9";
            btn9.Size = new Size(90, 40);
            btn9.TabIndex = 8;
            btn9.Text = "Sep";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Button_Click;
            // 
            // btn10
            // 
            btn10.Location = new Point(99, 95);
            btn10.Name = "btn10";
            btn10.Size = new Size(90, 40);
            btn10.TabIndex = 9;
            btn10.Text = "Oct";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += Button_Click;
            // 
            // btn11
            // 
            btn11.Location = new Point(195, 95);
            btn11.Name = "btn11";
            btn11.Size = new Size(90, 40);
            btn11.TabIndex = 10;
            btn11.Text = "Nov";
            btn11.UseVisualStyleBackColor = true;
            btn11.Click += Button_Click;
            // 
            // btn12
            // 
            btn12.Location = new Point(291, 95);
            btn12.Name = "btn12";
            btn12.Size = new Size(90, 40);
            btn12.TabIndex = 11;
            btn12.Text = "Dec";
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += Button_Click;
            // 
            // yearL
            // 
            yearL.AutoSize = true;
            yearL.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yearL.Location = new Point(168, 8);
            yearL.Name = "yearL";
            yearL.Size = new Size(52, 25);
            yearL.TabIndex = 1;
            yearL.Text = "yyyy";
            // 
            // leftL
            // 
            leftL.AutoSize = true;
            leftL.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leftL.Location = new Point(6, 8);
            leftL.Name = "leftL";
            leftL.Size = new Size(22, 25);
            leftL.TabIndex = 2;
            leftL.Text = "<";
            leftL.Click += leftL_Click;
            // 
            // rightL
            // 
            rightL.AutoSize = true;
            rightL.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rightL.Location = new Point(362, 8);
            rightL.Name = "rightL";
            rightL.Size = new Size(22, 25);
            rightL.TabIndex = 3;
            rightL.Text = ">";
            rightL.Click += rightL_Click;
            // 
            // MonthSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(rightL);
            Controls.Add(leftL);
            Controls.Add(yearL);
            Controls.Add(monthsContainer);
            Name = "MonthSelect";
            Size = new Size(392, 178);
            Load += MonthSelectcs_Load;
            monthsContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel monthsContainer;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private Label yearL;
        private Label leftL;
        private Label rightL;
    }
}
