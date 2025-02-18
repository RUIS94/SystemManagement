namespace UI.Controls
{
    partial class CalendarDays
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
            lbdays = new Label();
            eventLabel = new Label();
            SuspendLayout();
            // 
            // lbdays
            // 
            lbdays.AutoSize = true;
            lbdays.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbdays.Location = new Point(0, 0);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(32, 22);
            lbdays.TabIndex = 2;
            lbdays.Text = "00";
            // 
            // eventLabel
            // 
            eventLabel.AutoSize = true;
            eventLabel.BackColor = Color.FromArgb(255, 128, 0);
            eventLabel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventLabel.ForeColor = Color.Black;
            eventLabel.Location = new Point(3, 32);
            eventLabel.Name = "eventLabel";
            eventLabel.Size = new Size(41, 16);
            eventLabel.TabIndex = 3;
            eventLabel.Text = "label1";
            // 
            // CalendarDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(eventLabel);
            Controls.Add(lbdays);
            Name = "CalendarDays";
            Size = new Size(106, 79);
            Click += CalendarDays_Click;
            DoubleClick += CalendarDays_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
        private Label eventLabel;
    }
}
