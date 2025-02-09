namespace UI
{
    partial class HelpForm
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
            hdLabel = new Label();
            rvLabel = new Label();
            cuLabel = new Label();
            tabControl = new TabControl();
            articlesTab = new TabPage();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            helpTab = new TabPage();
            docsList = new DataGridView();
            sequence = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            type = new DataGridViewImageColumn();
            link = new DataGridViewLinkColumn();
            clearLabel = new Label();
            searchBox = new TextBox();
            searchLabel = new Label();
            chatL = new Label();
            homePanel.SuspendLayout();
            tabControl.SuspendLayout();
            articlesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            helpTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)docsList).BeginInit();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(chatL);
            homePanel.Controls.Add(hdLabel);
            homePanel.Controls.Add(rvLabel);
            homePanel.Controls.Add(cuLabel);
            homePanel.Controls.Add(tabControl);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(584, 522);
            homePanel.TabIndex = 0;
            // 
            // hdLabel
            // 
            hdLabel.AutoSize = true;
            hdLabel.Font = new Font("Arial", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            hdLabel.Location = new Point(167, 485);
            hdLabel.Name = "hdLabel";
            hdLabel.Size = new Size(105, 24);
            hdLabel.TabIndex = 3;
            hdLabel.Text = "Help Desk";
            hdLabel.Click += hdLabel_Click;
            // 
            // rvLabel
            // 
            rvLabel.AutoSize = true;
            rvLabel.Font = new Font("Arial", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            rvLabel.Location = new Point(314, 485);
            rvLabel.Name = "rvLabel";
            rvLabel.Size = new Size(147, 24);
            rvLabel.TabIndex = 2;
            rvLabel.Text = "Request Video";
            rvLabel.Click += rvLabel_Click;
            // 
            // cuLabel
            // 
            cuLabel.AutoSize = true;
            cuLabel.Font = new Font("Arial", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            cuLabel.Location = new Point(16, 485);
            cuLabel.Name = "cuLabel";
            cuLabel.Size = new Size(114, 24);
            cuLabel.TabIndex = 1;
            cuLabel.Text = "Contact Us";
            cuLabel.Click += cuLabel_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(articlesTab);
            tabControl.Controls.Add(helpTab);
            tabControl.Location = new Point(12, 14);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(560, 468);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // articlesTab
            // 
            articlesTab.Controls.Add(pictureBox4);
            articlesTab.Controls.Add(pictureBox3);
            articlesTab.Controls.Add(pictureBox2);
            articlesTab.Controls.Add(pictureBox1);
            articlesTab.Location = new Point(4, 26);
            articlesTab.Name = "articlesTab";
            articlesTab.Padding = new Padding(3);
            articlesTab.Size = new Size(552, 438);
            articlesTab.TabIndex = 0;
            articlesTab.Text = "New Articles";
            articlesTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Location = new Point(383, 277);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(163, 153);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(193, 277);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(163, 153);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(6, 277);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(163, 153);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(6, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // helpTab
            // 
            helpTab.Controls.Add(docsList);
            helpTab.Controls.Add(clearLabel);
            helpTab.Controls.Add(searchBox);
            helpTab.Controls.Add(searchLabel);
            helpTab.Location = new Point(4, 26);
            helpTab.Name = "helpTab";
            helpTab.Padding = new Padding(3);
            helpTab.Size = new Size(552, 438);
            helpTab.TabIndex = 1;
            helpTab.Text = "Help&Features";
            helpTab.UseVisualStyleBackColor = true;
            // 
            // docsList
            // 
            docsList.AllowUserToAddRows = false;
            docsList.AllowUserToDeleteRows = false;
            docsList.AllowUserToResizeColumns = false;
            docsList.AllowUserToResizeRows = false;
            docsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            docsList.Columns.AddRange(new DataGridViewColumn[] { sequence, name, type, link });
            docsList.Location = new Point(6, 62);
            docsList.Name = "docsList";
            docsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            docsList.Size = new Size(540, 367);
            docsList.TabIndex = 0;
            docsList.CellContentClick += videosList_CellContentClick;
            // 
            // sequence
            // 
            sequence.HeaderText = "Lne";
            sequence.Name = "sequence";
            sequence.ReadOnly = true;
            sequence.Width = 40;
            // 
            // name
            // 
            name.HeaderText = "Feature";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 330;
            // 
            // type
            // 
            type.HeaderText = "Type";
            type.ImageLayout = DataGridViewImageCellLayout.Stretch;
            type.Name = "type";
            type.ReadOnly = true;
            type.Width = 50;
            // 
            // link
            // 
            link.HeaderText = "View";
            link.Name = "link";
            link.ReadOnly = true;
            link.Text = "";
            // 
            // clearLabel
            // 
            clearLabel.AutoSize = true;
            clearLabel.Font = new Font("Ink Free", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearLabel.ForeColor = Color.Red;
            clearLabel.Location = new Point(258, 16);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(21, 26);
            clearLabel.TabIndex = 3;
            clearLabel.Text = "X";
            clearLabel.Click += clearLabel_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(74, 16);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(178, 23);
            searchBox.TabIndex = 2;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(6, 20);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(68, 17);
            searchLabel.TabIndex = 1;
            searchLabel.Text = "Search(F3)";
            // 
            // chatL
            // 
            chatL.AutoSize = true;
            chatL.Font = new Font("Arial", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            chatL.Location = new Point(490, 485);
            chatL.Name = "chatL";
            chatL.Size = new Size(78, 24);
            chatL.TabIndex = 4;
            chatL.Text = "Chat AI";
            chatL.Click += chatL_Click;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 522);
            Controls.Add(homePanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HelpForm";
            Text = "HelpForm";
            Load += HelpForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            tabControl.ResumeLayout(false);
            articlesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            helpTab.ResumeLayout(false);
            helpTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)docsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private TabControl tabControl;
        private TabPage articlesTab;
        private TabPage helpTab;
        private Label cuLabel;
        private DataGridView docsList;
        private DataGridViewTextBoxColumn sequence;
        private DataGridViewTextBoxColumn name;
        private DataGridViewImageColumn type;
        private DataGridViewLinkColumn link;
        private Label clearLabel;
        private TextBox searchBox;
        private Label searchLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label hdLabel;
        private Label rvLabel;
        private Label chatL;
    }
}