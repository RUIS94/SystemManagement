namespace UI
{
    partial class SearchForm
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
            addBtn = new Button();
            cancelBtn = new Button();
            okBtn = new Button();
            searchResults = new DataGridView();
            searchBtn = new Button();
            searchBox = new TextBox();
            searchLabel = new Label();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchResults).BeginInit();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(addBtn);
            homePanel.Controls.Add(cancelBtn);
            homePanel.Controls.Add(okBtn);
            homePanel.Controls.Add(searchResults);
            homePanel.Controls.Add(searchBtn);
            homePanel.Controls.Add(searchBox);
            homePanel.Controls.Add(searchLabel);
            homePanel.Location = new Point(12, 11);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(480, 297);
            homePanel.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(10, 255);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(64, 39);
            addBtn.TabIndex = 9;
            addBtn.Text = "Add F4";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Visible = false;
            addBtn.Click += addBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(290, 256);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(64, 39);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(405, 256);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(64, 39);
            okBtn.TabIndex = 7;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // searchResults
            // 
            searchResults.AllowUserToAddRows = false;
            searchResults.AllowUserToDeleteRows = false;
            searchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchResults.Location = new Point(10, 55);
            searchResults.Name = "searchResults";
            searchResults.ReadOnly = true;
            searchResults.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            searchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchResults.Size = new Size(459, 196);
            searchResults.TabIndex = 6;
            searchResults.KeyDown += searchResults_KeyDown;
            searchResults.Leave += searchResults_Leave;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(237, 12);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(64, 20);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(63, 12);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(168, 23);
            searchBox.TabIndex = 4;
            searchBox.KeyDown += searchBox_KeyDown;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(10, 15);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(42, 15);
            searchLabel.TabIndex = 3;
            searchLabel.Text = "Search";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 319);
            Controls.Add(homePanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchForm";
            Text = "SearchForm";
            Load += SearchForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private DataGridView searchResults;
        private Button searchBtn;
        private TextBox searchBox;
        private Label searchLabel;
        private Button cancelBtn;
        private Button okBtn;
        private Button addBtn;
    }
}