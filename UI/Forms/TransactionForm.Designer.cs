namespace UI
{
    partial class TransactionForm
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
            calendar2 = new MonthCalendar();
            calendar1 = new MonthCalendar();
            tabControl = new TabControl();
            summaryTab = new TabPage();
            summaryList = new DataGridView();
            detailTab = new TabPage();
            detailList = new DataGridView();
            resetBtn = new Button();
            calendarBtn2 = new Button();
            calendarBtn1 = new Button();
            dateBox2 = new TextBox();
            label6 = new Label();
            dateBox1 = new TextBox();
            label5 = new Label();
            prodIDBox = new TextBox();
            label4 = new Label();
            referBox = new TextBox();
            label3 = new Label();
            orderIDBox = new TextBox();
            label2 = new Label();
            searchBtn = new Button();
            transIDBox = new TextBox();
            label1 = new Label();
            homePanel.SuspendLayout();
            tabControl.SuspendLayout();
            summaryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)summaryList).BeginInit();
            detailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)detailList).BeginInit();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(calendar2);
            homePanel.Controls.Add(calendar1);
            homePanel.Controls.Add(tabControl);
            homePanel.Controls.Add(resetBtn);
            homePanel.Controls.Add(calendarBtn2);
            homePanel.Controls.Add(calendarBtn1);
            homePanel.Controls.Add(dateBox2);
            homePanel.Controls.Add(label6);
            homePanel.Controls.Add(dateBox1);
            homePanel.Controls.Add(label5);
            homePanel.Controls.Add(prodIDBox);
            homePanel.Controls.Add(label4);
            homePanel.Controls.Add(referBox);
            homePanel.Controls.Add(label3);
            homePanel.Controls.Add(orderIDBox);
            homePanel.Controls.Add(label2);
            homePanel.Controls.Add(searchBtn);
            homePanel.Controls.Add(transIDBox);
            homePanel.Controls.Add(label1);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(644, 301);
            homePanel.TabIndex = 0;
            homePanel.Click += transPage_Click;
            // 
            // calendar2
            // 
            calendar2.Location = new Point(412, 106);
            calendar2.Margin = new Padding(9, 8, 9, 8);
            calendar2.Name = "calendar2";
            calendar2.ShowToday = false;
            calendar2.TabIndex = 18;
            calendar2.Visible = false;
            calendar2.DateSelected += calendar2_DateSelected;
            // 
            // calendar1
            // 
            calendar1.Location = new Point(412, 105);
            calendar1.Margin = new Padding(9, 8, 9, 8);
            calendar1.Name = "calendar1";
            calendar1.ShowToday = false;
            calendar1.TabIndex = 0;
            calendar1.Visible = false;
            calendar1.DateSelected += calendar1_DateSelected;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(summaryTab);
            tabControl.Controls.Add(detailTab);
            tabControl.Location = new Point(12, 82);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(455, 208);
            tabControl.TabIndex = 17;
            // 
            // summaryTab
            // 
            summaryTab.Controls.Add(summaryList);
            summaryTab.Location = new Point(4, 24);
            summaryTab.Name = "summaryTab";
            summaryTab.Padding = new Padding(3);
            summaryTab.Size = new Size(447, 180);
            summaryTab.TabIndex = 0;
            summaryTab.Text = "Summary";
            summaryTab.UseVisualStyleBackColor = true;
            // 
            // summaryList
            // 
            summaryList.AllowUserToAddRows = false;
            summaryList.AllowUserToDeleteRows = false;
            summaryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            summaryList.Location = new Point(6, 5);
            summaryList.Name = "summaryList";
            summaryList.ReadOnly = true;
            summaryList.Size = new Size(435, 171);
            summaryList.TabIndex = 1;
            summaryList.CellClick += summaryList_CellClick;
            // 
            // detailTab
            // 
            detailTab.Controls.Add(detailList);
            detailTab.Location = new Point(4, 24);
            detailTab.Name = "detailTab";
            detailTab.Padding = new Padding(3);
            detailTab.Size = new Size(447, 180);
            detailTab.TabIndex = 1;
            detailTab.Text = "Detail";
            detailTab.UseVisualStyleBackColor = true;
            // 
            // detailList
            // 
            detailList.AllowUserToAddRows = false;
            detailList.AllowUserToDeleteRows = false;
            detailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailList.Location = new Point(6, 5);
            detailList.Name = "detailList";
            detailList.ReadOnly = true;
            detailList.Size = new Size(435, 171);
            detailList.TabIndex = 0;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(574, 31);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(58, 46);
            resetBtn.TabIndex = 16;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // calendarBtn2
            // 
            calendarBtn2.Location = new Point(420, 56);
            calendarBtn2.Name = "calendarBtn2";
            calendarBtn2.Size = new Size(47, 20);
            calendarBtn2.TabIndex = 15;
            calendarBtn2.Text = "C";
            calendarBtn2.UseVisualStyleBackColor = true;
            calendarBtn2.Click += calendarBtn2_Click;
            // 
            // calendarBtn1
            // 
            calendarBtn1.Location = new Point(420, 31);
            calendarBtn1.Name = "calendarBtn1";
            calendarBtn1.Size = new Size(47, 20);
            calendarBtn1.TabIndex = 14;
            calendarBtn1.Text = "C";
            calendarBtn1.UseVisualStyleBackColor = true;
            calendarBtn1.Click += calendarBtn1_Click;
            // 
            // dateBox2
            // 
            dateBox2.Location = new Point(284, 56);
            dateBox2.Name = "dateBox2";
            dateBox2.Size = new Size(130, 23);
            dateBox2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(222, 59);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 12;
            label6.Text = "To";
            // 
            // dateBox1
            // 
            dateBox1.Location = new Point(284, 31);
            dateBox1.Name = "dateBox1";
            dateBox1.Size = new Size(130, 23);
            dateBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 34);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 10;
            label5.Text = "From";
            // 
            // prodIDBox
            // 
            prodIDBox.Location = new Point(284, 5);
            prodIDBox.Name = "prodIDBox";
            prodIDBox.Size = new Size(183, 23);
            prodIDBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 8);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Part No.";
            // 
            // referBox
            // 
            referBox.Location = new Point(86, 56);
            referBox.Name = "referBox";
            referBox.Size = new Size(130, 23);
            referBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 6;
            label3.Text = "Refer";
            // 
            // orderIDBox
            // 
            orderIDBox.Location = new Point(86, 31);
            orderIDBox.Name = "orderIDBox";
            orderIDBox.Size = new Size(130, 23);
            orderIDBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Order No.";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(492, 31);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(58, 46);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // transIDBox
            // 
            transIDBox.Location = new Point(86, 5);
            transIDBox.Name = "transIDBox";
            transIDBox.Size = new Size(130, 23);
            transIDBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Trans ID";
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 301);
            Controls.Add(homePanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TransactionForm";
            Text = "TransactionForm";
            Load += TransactionForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            tabControl.ResumeLayout(false);
            summaryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)summaryList).EndInit();
            detailTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)detailList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private Button resetBtn;
        private Button calendarBtn2;
        private Button calendarBtn1;
        private TextBox dateBox2;
        private Label label6;
        private TextBox dateBox1;
        private Label label5;
        private TextBox prodIDBox;
        private Label label4;
        private TextBox referBox;
        private Label label3;
        private TextBox orderIDBox;
        private Label label2;
        private Button searchBtn;
        private TextBox transIDBox;
        private Label label1;
        private TabControl tabControl;
        private TabPage summaryTab;
        private TabPage detailTab;
        private MonthCalendar calendar1;
        private MonthCalendar calendar2;
        private DataGridView summaryList;
        private DataGridView detailList;
    }
}