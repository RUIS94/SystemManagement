namespace UI.Forms
{
    public partial class EventsForm
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
            calendar = new MonthCalendar();
            addeventBtn = new Button();
            weekLabel = new Label();
            userBox = new ComboBox();
            calendarBtn = new Button();
            yearLabel = new Label();
            monthLabel = new Label();
            rightLabel = new Label();
            leftLabel = new Label();
            dayLabel = new Label();
            addBtn = new Button();
            cancelBtn = new Button();
            noteBox = new TextBox();
            summaryLabel = new Label();
            summaryBox = new TextBox();
            dateLabel = new Label();
            okBtn = new Button();
            dateBox = new TextBox();
            eventList = new DataGridView();
            sequence = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            summary = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            text = new DataGridViewTextBoxColumn();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eventList).BeginInit();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(calendar);
            homePanel.Controls.Add(addeventBtn);
            homePanel.Controls.Add(weekLabel);
            homePanel.Controls.Add(userBox);
            homePanel.Controls.Add(calendarBtn);
            homePanel.Controls.Add(yearLabel);
            homePanel.Controls.Add(monthLabel);
            homePanel.Controls.Add(rightLabel);
            homePanel.Controls.Add(leftLabel);
            homePanel.Controls.Add(dayLabel);
            homePanel.Controls.Add(addBtn);
            homePanel.Controls.Add(cancelBtn);
            homePanel.Controls.Add(noteBox);
            homePanel.Controls.Add(summaryLabel);
            homePanel.Controls.Add(summaryBox);
            homePanel.Controls.Add(dateLabel);
            homePanel.Controls.Add(okBtn);
            homePanel.Controls.Add(dateBox);
            homePanel.Controls.Add(eventList);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(584, 561);
            homePanel.TabIndex = 0;
            // 
            // calendar
            // 
            calendar.Location = new Point(289, 31);
            calendar.Margin = new Padding(9, 8, 9, 8);
            calendar.Name = "calendar";
            calendar.TabIndex = 18;
            calendar.Visible = false;
            calendar.DateSelected += calendar_DateSelected;
            // 
            // addeventBtn
            // 
            addeventBtn.Location = new Point(492, 19);
            addeventBtn.Name = "addeventBtn";
            addeventBtn.Size = new Size(79, 37);
            addeventBtn.TabIndex = 17;
            addeventBtn.Text = "Add Event";
            addeventBtn.UseVisualStyleBackColor = true;
            addeventBtn.Click += addeventBtn_Click;
            // 
            // weekLabel
            // 
            weekLabel.AutoSize = true;
            weekLabel.Location = new Point(187, 12);
            weekLabel.Name = "weekLabel";
            weekLabel.Size = new Size(36, 15);
            weekLabel.TabIndex = 16;
            weekLabel.Text = "Week";
            weekLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // userBox
            // 
            userBox.FormattingEnabled = true;
            userBox.Location = new Point(474, 76);
            userBox.Name = "userBox";
            userBox.Size = new Size(97, 23);
            userBox.TabIndex = 15;
            // 
            // calendarBtn
            // 
            calendarBtn.Location = new Point(445, 76);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Size = new Size(23, 23);
            calendarBtn.TabIndex = 14;
            calendarBtn.Text = "C";
            calendarBtn.UseVisualStyleBackColor = true;
            calendarBtn.Click += calendarBtn_Click;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(202, 46);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(35, 15);
            yearLabel.TabIndex = 13;
            yearLabel.Text = "YYYY";
            yearLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthLabel.Location = new Point(177, 28);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(60, 18);
            monthLabel.TabIndex = 12;
            monthLabel.Text = "MMMM";
            monthLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rightLabel.Location = new Point(253, 27);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(30, 32);
            rightLabel.TabIndex = 11;
            rightLabel.Text = ">";
            rightLabel.Click += rightLabel_Click;
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftLabel.Location = new Point(11, 27);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(30, 32);
            leftLabel.TabIndex = 10;
            leftLabel.Text = "<";
            leftLabel.Click += leftLabel_Click;
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dayLabel.Location = new Point(47, 19);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(82, 42);
            dayLabel.TabIndex = 9;
            dayLabel.Text = "Day";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(289, 153);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(142, 37);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add Note (F5)";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(389, 512);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(79, 37);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel(F9)";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(289, 196);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(282, 288);
            noteBox.TabIndex = 6;
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Location = new Point(289, 110);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(58, 15);
            summaryLabel.TabIndex = 5;
            summaryLabel.Text = "Summary";
            // 
            // summaryBox
            // 
            summaryBox.Location = new Point(358, 107);
            summaryBox.Name = "summaryBox";
            summaryBox.Size = new Size(213, 23);
            summaryBox.TabIndex = 4;
            summaryBox.TextChanged += summaryBox_TextChanged;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(289, 80);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(63, 15);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Event Date";
            // 
            // okBtn
            // 
            okBtn.Location = new Point(492, 512);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(79, 37);
            okBtn.TabIndex = 2;
            okBtn.Text = "OK(F10)";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // dateBox
            // 
            dateBox.Location = new Point(358, 77);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(81, 23);
            dateBox.TabIndex = 1;
            // 
            // eventList
            // 
            eventList.AllowUserToAddRows = false;
            eventList.AllowUserToDeleteRows = false;
            eventList.AllowUserToResizeColumns = false;
            eventList.AllowUserToResizeRows = false;
            eventList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventList.Columns.AddRange(new DataGridViewColumn[] { sequence, id, summary, date, text });
            eventList.Location = new Point(11, 81);
            eventList.Name = "eventList";
            eventList.RowHeadersWidth = 20;
            eventList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            eventList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            eventList.Size = new Size(272, 403);
            eventList.TabIndex = 0;
            eventList.CellDoubleClick += eventList_CellDoubleClick;
            // 
            // sequence
            // 
            sequence.FillWeight = 39.30131F;
            sequence.HeaderText = "Lne";
            sequence.Name = "sequence";
            sequence.ReadOnly = true;
            sequence.Width = 30;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // summary
            // 
            summary.FillWeight = 206.254776F;
            summary.HeaderText = "Summary";
            summary.Name = "summary";
            summary.ReadOnly = true;
            summary.Width = 159;
            // 
            // date
            // 
            date.FillWeight = 54.44392F;
            date.HeaderText = "Date";
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 62;
            // 
            // text
            // 
            text.HeaderText = "Text";
            text.Name = "text";
            text.ReadOnly = true;
            text.Visible = false;
            // 
            // EventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(homePanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EventsForm";
            Text = "EventsForm";
            Load += EventsForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eventList).EndInit();
            ResumeLayout(false);
        }

        private void RightLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel homePanel;
        private Button cancelBtn;
        private TextBox noteBox;
        private Label summaryLabel;
        private TextBox summaryBox;
        private Label dateLabel;
        private Button okBtn;
        private TextBox dateBox;
        private DataGridView eventList;
        private Button addBtn;
        private Label rightLabel;
        private Label leftLabel;
        private Label dayLabel;
        private Button calendarBtn;
        private Label yearLabel;
        private Label monthLabel;
        private ComboBox userBox;
        private Label weekLabel;
        private Button addeventBtn;
        private MonthCalendar calendar;
        private DataGridViewTextBoxColumn sequence;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn summary;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn text;
    }
}