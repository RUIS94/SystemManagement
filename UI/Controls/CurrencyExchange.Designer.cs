namespace UI.Controls
{
    partial class CurrencyExchange
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
            label1 = new Label();
            fromBox = new ComboBox();
            toBox = new ComboBox();
            label2 = new Label();
            fromTextBox = new TextBox();
            toTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // fromBox
            // 
            fromBox.FormattingEnabled = true;
            fromBox.Location = new Point(3, 18);
            fromBox.Name = "fromBox";
            fromBox.Size = new Size(64, 23);
            fromBox.TabIndex = 1;
            // 
            // toBox
            // 
            toBox.FormattingEnabled = true;
            toBox.Location = new Point(3, 68);
            toBox.Name = "toBox";
            toBox.Size = new Size(64, 23);
            toBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 2;
            label2.Text = "To";
            // 
            // fromTextBox
            // 
            fromTextBox.Location = new Point(73, 18);
            fromTextBox.Name = "fromTextBox";
            fromTextBox.Size = new Size(59, 23);
            fromTextBox.TabIndex = 4;
            fromTextBox.TextChanged += formTextBox_TextChanged;
            // 
            // toTextBox
            // 
            toTextBox.Location = new Point(73, 68);
            toTextBox.Name = "toTextBox";
            toTextBox.ReadOnly = true;
            toTextBox.Size = new Size(59, 23);
            toTextBox.TabIndex = 5;
            // 
            // CurrencyExchange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(toTextBox);
            Controls.Add(fromTextBox);
            Controls.Add(toBox);
            Controls.Add(label2);
            Controls.Add(fromBox);
            Controls.Add(label1);
            Name = "CurrencyExchange";
            Size = new Size(135, 94);
            Load += CurrencyExchange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox fromBox;
        private ComboBox toBox;
        private Label label2;
        private TextBox fromTextBox;
        private TextBox toTextBox;
    }
}
