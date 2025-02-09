namespace UI.Controls
{
    partial class Calculator
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
            resultBox = new TextBox();
            historyBox = new TextBox();
            BtnC = new Button();
            BtnDivide = new Button();
            BtnEqual = new Button();
            Btn0 = new Button();
            BtnMultiply = new Button();
            Btn3 = new Button();
            Btn2 = new Button();
            Btn1 = new Button();
            BtnSubtract = new Button();
            Btn6 = new Button();
            Btn5 = new Button();
            Btn4 = new Button();
            BtnAdd = new Button();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn7 = new Button();
            SuspendLayout();
            // 
            // resultBox
            // 
            resultBox.Location = new Point(3, 3);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(129, 23);
            resultBox.TabIndex = 0;
            // 
            // historyBox
            // 
            historyBox.Location = new Point(2, 156);
            historyBox.Multiline = true;
            historyBox.Name = "historyBox";
            historyBox.Size = new Size(129, 69);
            historyBox.TabIndex = 34;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(34, 125);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(25, 25);
            BtnC.TabIndex = 33;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += Button_Click;
            // 
            // BtnDivide
            // 
            BtnDivide.Location = new Point(96, 125);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(25, 25);
            BtnDivide.TabIndex = 32;
            BtnDivide.Text = "/";
            BtnDivide.UseVisualStyleBackColor = true;
            BtnDivide.Click += Button_Click;
            // 
            // BtnEqual
            // 
            BtnEqual.Location = new Point(65, 125);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(25, 25);
            BtnEqual.TabIndex = 31;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = true;
            BtnEqual.Click += Button_Click;
            // 
            // Btn0
            // 
            Btn0.Location = new Point(3, 125);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(25, 25);
            Btn0.TabIndex = 30;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += Button_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.Location = new Point(96, 94);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(25, 25);
            BtnMultiply.TabIndex = 29;
            BtnMultiply.Text = "*";
            BtnMultiply.UseVisualStyleBackColor = true;
            BtnMultiply.Click += Button_Click;
            // 
            // Btn3
            // 
            Btn3.Location = new Point(65, 94);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(25, 25);
            Btn3.TabIndex = 28;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Button_Click;
            // 
            // Btn2
            // 
            Btn2.Location = new Point(34, 94);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(25, 25);
            Btn2.TabIndex = 27;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Button_Click;
            // 
            // Btn1
            // 
            Btn1.Location = new Point(3, 94);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(25, 25);
            Btn1.TabIndex = 26;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Button_Click;
            // 
            // BtnSubtract
            // 
            BtnSubtract.Location = new Point(96, 63);
            BtnSubtract.Name = "BtnSubtract";
            BtnSubtract.Size = new Size(25, 25);
            BtnSubtract.TabIndex = 25;
            BtnSubtract.Text = "-";
            BtnSubtract.UseVisualStyleBackColor = true;
            BtnSubtract.Click += Button_Click;
            // 
            // Btn6
            // 
            Btn6.Location = new Point(65, 63);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(25, 25);
            Btn6.TabIndex = 24;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += Button_Click;
            // 
            // Btn5
            // 
            Btn5.Location = new Point(34, 63);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(25, 25);
            Btn5.TabIndex = 23;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += Button_Click;
            // 
            // Btn4
            // 
            Btn4.Location = new Point(3, 63);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(25, 25);
            Btn4.TabIndex = 22;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += Button_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(96, 32);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(25, 25);
            BtnAdd.TabIndex = 21;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += Button_Click;
            // 
            // Btn9
            // 
            Btn9.Location = new Point(65, 32);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(25, 25);
            Btn9.TabIndex = 20;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += Button_Click;
            // 
            // Btn8
            // 
            Btn8.Location = new Point(34, 32);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(25, 25);
            Btn8.TabIndex = 19;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += Button_Click;
            // 
            // Btn7
            // 
            Btn7.Location = new Point(3, 32);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(25, 25);
            Btn7.TabIndex = 18;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += Button_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(historyBox);
            Controls.Add(BtnC);
            Controls.Add(BtnDivide);
            Controls.Add(BtnEqual);
            Controls.Add(Btn0);
            Controls.Add(BtnMultiply);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(BtnSubtract);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(BtnAdd);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(resultBox);
            Name = "Calculator";
            Size = new Size(135, 228);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox resultBox;
        private TextBox historyBox;
        private Button BtnC;
        private Button BtnDivide;
        private Button BtnEqual;
        private Button Btn0;
        private Button BtnMultiply;
        private Button Btn3;
        private Button Btn2;
        private Button Btn1;
        private Button BtnSubtract;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button BtnAdd;
        private Button Btn9;
        private Button Btn8;
        private Button Btn7;
    }
}
