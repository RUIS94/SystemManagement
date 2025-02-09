namespace UI.Forms
{
    partial class CalendarForm
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
            addevent = new Label();
            today = new Label();
            displayMonth = new Label();
            nextMonth = new Button();
            sat = new Label();
            fri = new Label();
            thu = new Label();
            wed = new Label();
            tues = new Label();
            mon = new Label();
            sun = new Label();
            lastMonth = new Button();
            daycontainer = new FlowLayoutPanel();
            homePanel = new Panel();
            homePanel.SuspendLayout();
            SuspendLayout();
            // 
            // addevent
            // 
            addevent.AutoSize = true;
            addevent.Font = new Font("Arial", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            addevent.Location = new Point(634, 625);
            addevent.Name = "addevent";
            addevent.Size = new Size(123, 27);
            addevent.TabIndex = 26;
            addevent.Text = "Add Event";
            addevent.Click += addEvent_Click;
            // 
            // today
            // 
            today.AutoSize = true;
            today.Font = new Font("Arial", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            today.Location = new Point(33, 625);
            today.Name = "today";
            today.Size = new Size(75, 27);
            today.TabIndex = 25;
            today.Text = "Today";
            today.Click += today_Click;
            // 
            // displayMonth
            // 
            displayMonth.AutoSize = true;
            displayMonth.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayMonth.Location = new Point(324, 11);
            displayMonth.Name = "displayMonth";
            displayMonth.Size = new Size(79, 27);
            displayMonth.TabIndex = 24;
            displayMonth.Text = "Month";
            // 
            // nextMonth
            // 
            nextMonth.Location = new Point(719, 12);
            nextMonth.Name = "nextMonth";
            nextMonth.Size = new Size(80, 30);
            nextMonth.TabIndex = 23;
            nextMonth.Text = ">>>";
            nextMonth.UseVisualStyleBackColor = true;
            nextMonth.Click += nextMonth_Click;
            // 
            // sat
            // 
            sat.AutoSize = true;
            sat.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sat.Location = new Point(709, 59);
            sat.Name = "sat";
            sat.Size = new Size(48, 27);
            sat.TabIndex = 22;
            sat.Text = "Sat";
            // 
            // fri
            // 
            fri.AutoSize = true;
            fri.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fri.Location = new Point(602, 59);
            fri.Name = "fri";
            fri.Size = new Size(40, 27);
            fri.TabIndex = 21;
            fri.Text = "Fri";
            // 
            // thu
            // 
            thu.AutoSize = true;
            thu.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thu.Location = new Point(483, 59);
            thu.Name = "thu";
            thu.Size = new Size(54, 27);
            thu.TabIndex = 20;
            thu.Text = "Thu";
            // 
            // wed
            // 
            wed.AutoSize = true;
            wed.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wed.Location = new Point(369, 59);
            wed.Name = "wed";
            wed.Size = new Size(62, 27);
            wed.TabIndex = 19;
            wed.Text = "Wed";
            // 
            // tues
            // 
            tues.AutoSize = true;
            tues.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tues.Location = new Point(258, 59);
            tues.Name = "tues";
            tues.Size = new Size(64, 27);
            tues.TabIndex = 18;
            tues.Text = "Tues";
            // 
            // mon
            // 
            mon.AutoSize = true;
            mon.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mon.Location = new Point(145, 59);
            mon.Name = "mon";
            mon.Size = new Size(58, 27);
            mon.TabIndex = 17;
            mon.Text = "Mon";
            // 
            // sun
            // 
            sun.AutoSize = true;
            sun.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sun.Location = new Point(33, 59);
            sun.Name = "sun";
            sun.Size = new Size(56, 27);
            sun.TabIndex = 16;
            sun.Text = "Sun";
            // 
            // lastMonth
            // 
            lastMonth.Location = new Point(9, 12);
            lastMonth.Name = "lastMonth";
            lastMonth.Size = new Size(80, 30);
            lastMonth.TabIndex = 15;
            lastMonth.Text = "<<<";
            lastMonth.UseVisualStyleBackColor = true;
            lastMonth.Click += lastMonth_Click;
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(9, 89);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(790, 520);
            daycontainer.TabIndex = 14;
            // 
            // homePanel
            // 
            homePanel.Controls.Add(addevent);
            homePanel.Controls.Add(lastMonth);
            homePanel.Controls.Add(today);
            homePanel.Controls.Add(displayMonth);
            homePanel.Controls.Add(daycontainer);
            homePanel.Controls.Add(sat);
            homePanel.Controls.Add(nextMonth);
            homePanel.Controls.Add(fri);
            homePanel.Controls.Add(sun);
            homePanel.Controls.Add(thu);
            homePanel.Controls.Add(mon);
            homePanel.Controls.Add(wed);
            homePanel.Controls.Add(tues);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(814, 661);
            homePanel.TabIndex = 27;
            // 
            // CalendarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 661);
            Controls.Add(homePanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalendarForm";
            Text = "CalendarForm";
            Load += CalendarForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label addevent;
        private Label today;
        private Label displayMonth;
        private Button nextMonth;
        private Label sat;
        private Label fri;
        private Label thu;
        private Label wed;
        private Label tues;
        private Label mon;
        private Label sun;
        private Button lastMonth;
        private FlowLayoutPanel daycontainer;
        private Panel homePanel;
    }
}