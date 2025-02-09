namespace Test
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lastMonth = new Button();
            sun = new Label();
            mon = new Label();
            wed = new Label();
            tues = new Label();
            fri = new Label();
            thu = new Label();
            sat = new Label();
            nextMonth = new Button();
            displayMonth = new Label();
            daycontainer = new FlowLayoutPanel();
            today = new Label();
            addevent = new Label();
            SuspendLayout();
            // 
            // lastMonth
            // 
            lastMonth.Location = new Point(15, 12);
            lastMonth.Name = "lastMonth";
            lastMonth.Size = new Size(80, 30);
            lastMonth.TabIndex = 1;
            lastMonth.Text = "<<<";
            lastMonth.UseVisualStyleBackColor = true;
            lastMonth.Click += lastMonth_Click;
            // 
            // sun
            // 
            sun.AutoSize = true;
            sun.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sun.Location = new Point(39, 59);
            sun.Name = "sun";
            sun.Size = new Size(56, 27);
            sun.TabIndex = 2;
            sun.Text = "Sun";
            // 
            // mon
            // 
            mon.AutoSize = true;
            mon.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mon.Location = new Point(150, 59);
            mon.Name = "mon";
            mon.Size = new Size(58, 27);
            mon.TabIndex = 3;
            mon.Text = "Mon";
            // 
            // wed
            // 
            wed.AutoSize = true;
            wed.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wed.Location = new Point(372, 59);
            wed.Name = "wed";
            wed.Size = new Size(62, 27);
            wed.TabIndex = 5;
            wed.Text = "Wed";
            // 
            // tues
            // 
            tues.AutoSize = true;
            tues.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tues.Location = new Point(259, 59);
            tues.Name = "tues";
            tues.Size = new Size(64, 27);
            tues.TabIndex = 4;
            tues.Text = "Tues";
            // 
            // fri
            // 
            fri.AutoSize = true;
            fri.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fri.Location = new Point(603, 59);
            fri.Name = "fri";
            fri.Size = new Size(40, 27);
            fri.TabIndex = 7;
            fri.Text = "Fri";
            // 
            // thu
            // 
            thu.AutoSize = true;
            thu.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thu.Location = new Point(484, 59);
            thu.Name = "thu";
            thu.Size = new Size(54, 27);
            thu.TabIndex = 6;
            thu.Text = "Thu";
            // 
            // sat
            // 
            sat.AutoSize = true;
            sat.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sat.Location = new Point(712, 59);
            sat.Name = "sat";
            sat.Size = new Size(48, 27);
            sat.TabIndex = 9;
            sat.Text = "Sat";
            // 
            // nextMonth
            // 
            nextMonth.Location = new Point(712, 12);
            nextMonth.Name = "nextMonth";
            nextMonth.Size = new Size(80, 30);
            nextMonth.TabIndex = 10;
            nextMonth.Text = ">>>";
            nextMonth.UseVisualStyleBackColor = true;
            nextMonth.Click += nextMonth_Click;
            // 
            // displayMonth
            // 
            displayMonth.AutoSize = true;
            displayMonth.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayMonth.Location = new Point(326, 9);
            displayMonth.Name = "displayMonth";
            displayMonth.Size = new Size(79, 27);
            displayMonth.TabIndex = 11;
            displayMonth.Text = "Month";
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(12, 89);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(790, 520);
            daycontainer.TabIndex = 0;
            // 
            // today
            // 
            today.AutoSize = true;
            today.Font = new Font("Arial", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            today.Location = new Point(39, 625);
            today.Name = "today";
            today.Size = new Size(75, 27);
            today.TabIndex = 12;
            today.Text = "Today";
            today.Click += today_Click;
            // 
            // addevent
            // 
            addevent.AutoSize = true;
            addevent.Font = new Font("Arial", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            addevent.Location = new Point(637, 625);
            addevent.Name = "addevent";
            addevent.Size = new Size(123, 27);
            addevent.TabIndex = 13;
            addevent.Text = "Add Event";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 661);
            Controls.Add(addevent);
            Controls.Add(today);
            Controls.Add(displayMonth);
            Controls.Add(nextMonth);
            Controls.Add(sat);
            Controls.Add(fri);
            Controls.Add(thu);
            Controls.Add(wed);
            Controls.Add(tues);
            Controls.Add(mon);
            Controls.Add(sun);
            Controls.Add(lastMonth);
            Controls.Add(daycontainer);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button lastMonth;
        private Label sun;
        private Label mon;
        private Label wed;
        private Label tues;
        private Label fri;
        private Label thu;
        private Label sat;
        private Button nextMonth;
        private Label displayMonth;
        private FlowLayoutPanel daycontainer;
        private Label today;
        private Label addevent;
    }
}
