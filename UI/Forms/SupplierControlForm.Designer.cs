namespace UI
{
    partial class SupplierControlForm
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
            graphBtn = new Button();
            trackBar = new TrackBar();
            transBtn = new Button();
            emailBox = new TextBox();
            deleteBtn = new Button();
            emailLabel = new Label();
            addBtn = new Button();
            searchBtn = new Button();
            phoneBox = new TextBox();
            editBtn = new Button();
            phoneLabel = new Label();
            searchLabel = new Label();
            address2Box = new TextBox();
            idLabel = new Label();
            address1Box = new TextBox();
            searchBox = new TextBox();
            addressLabel = new Label();
            searBtn = new Button();
            nameBox = new TextBox();
            undoBtn = new Button();
            nameLabel = new Label();
            saveBtn = new Button();
            idBox = new TextBox();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(graphBtn);
            homePanel.Controls.Add(trackBar);
            homePanel.Controls.Add(transBtn);
            homePanel.Controls.Add(emailBox);
            homePanel.Controls.Add(deleteBtn);
            homePanel.Controls.Add(emailLabel);
            homePanel.Controls.Add(addBtn);
            homePanel.Controls.Add(searchBtn);
            homePanel.Controls.Add(phoneBox);
            homePanel.Controls.Add(editBtn);
            homePanel.Controls.Add(phoneLabel);
            homePanel.Controls.Add(searchLabel);
            homePanel.Controls.Add(address2Box);
            homePanel.Controls.Add(idLabel);
            homePanel.Controls.Add(address1Box);
            homePanel.Controls.Add(searchBox);
            homePanel.Controls.Add(addressLabel);
            homePanel.Controls.Add(searBtn);
            homePanel.Controls.Add(nameBox);
            homePanel.Controls.Add(undoBtn);
            homePanel.Controls.Add(nameLabel);
            homePanel.Controls.Add(saveBtn);
            homePanel.Controls.Add(idBox);
            homePanel.Location = new Point(12, 11);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(760, 439);
            homePanel.TabIndex = 0;
            homePanel.Click += homePanel_Click;
            // 
            // graphBtn
            // 
            graphBtn.Anchor = AnchorStyles.None;
            graphBtn.Location = new Point(9, 273);
            graphBtn.Name = "graphBtn";
            graphBtn.Size = new Size(76, 46);
            graphBtn.TabIndex = 6;
            graphBtn.Text = "Graphs (F7)";
            graphBtn.UseVisualStyleBackColor = true;
            graphBtn.Click += graphBtn_Click;
            // 
            // trackBar
            // 
            trackBar.AutoSize = false;
            trackBar.BackColor = Color.Silver;
            trackBar.Location = new Point(6, 408);
            trackBar.Maximum = 1;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(76, 23);
            trackBar.TabIndex = 2;
            trackBar.TickStyle = TickStyle.None;
            trackBar.Scroll += trackBar_Scroll_1;
            // 
            // transBtn
            // 
            transBtn.Anchor = AnchorStyles.None;
            transBtn.Location = new Point(9, 221);
            transBtn.Name = "transBtn";
            transBtn.Size = new Size(76, 46);
            transBtn.TabIndex = 5;
            transBtn.Text = "Trans (F6)";
            transBtn.UseVisualStyleBackColor = true;
            transBtn.Click += transBtn_Click;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(158, 131);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(232, 23);
            emailBox.TabIndex = 15;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.None;
            deleteBtn.Location = new Point(9, 169);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(76, 46);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete (F5)";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(91, 133);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email";
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.None;
            addBtn.Location = new Point(9, 117);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(76, 46);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add (F4)";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.None;
            searchBtn.Location = new Point(9, 65);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(76, 46);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search (F3)";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(158, 105);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(232, 23);
            phoneBox.TabIndex = 13;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.None;
            editBtn.Location = new Point(9, 13);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(76, 46);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit (F2)";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(91, 108);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(41, 15);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Phone";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchLabel.Location = new Point(91, 13);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(61, 21);
            searchLabel.TabIndex = 0;
            searchLabel.Text = "Search";
            // 
            // address2Box
            // 
            address2Box.Location = new Point(158, 182);
            address2Box.Name = "address2Box";
            address2Box.Size = new Size(232, 23);
            address2Box.TabIndex = 11;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(91, 53);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(45, 15);
            idLabel.TabIndex = 1;
            idLabel.Text = "SuppID";
            // 
            // address1Box
            // 
            address1Box.Location = new Point(158, 156);
            address1Box.Name = "address1Box";
            address1Box.Size = new Size(232, 23);
            address1Box.TabIndex = 10;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(158, 13);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(100, 23);
            searchBox.TabIndex = 2;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(91, 160);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(39, 15);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Postal";
            // 
            // searBtn
            // 
            searBtn.Location = new Point(264, 15);
            searBtn.Name = "searBtn";
            searBtn.Size = new Size(60, 20);
            searBtn.TabIndex = 3;
            searBtn.Text = "Search";
            searBtn.UseVisualStyleBackColor = true;
            searBtn.Click += searBtn_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(158, 79);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(232, 23);
            nameBox.TabIndex = 8;
            // 
            // undoBtn
            // 
            undoBtn.Location = new Point(330, 15);
            undoBtn.Name = "undoBtn";
            undoBtn.Size = new Size(60, 20);
            undoBtn.TabIndex = 4;
            undoBtn.Text = "Undo";
            undoBtn.UseVisualStyleBackColor = true;
            undoBtn.Click += undoBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(91, 82);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(396, 16);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(60, 20);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // idBox
            // 
            idBox.Location = new Point(158, 50);
            idBox.Name = "idBox";
            idBox.Size = new Size(100, 23);
            idBox.TabIndex = 6;
            // 
            // SupplierControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 460);
            Controls.Add(homePanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "SupplierControlForm";
            Text = "Supplier Control";
            Load += SupplierControlForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private TextBox address2Box;
        private TextBox address1Box;
        private Label addressLabel;
        private TextBox nameBox;
        private Label nameLabel;
        private TextBox idBox;
        private Button saveBtn;
        private Button undoBtn;
        private Button searBtn;
        private TextBox searchBox;
        private Label idLabel;
        private Label searchLabel;
        private Button graphBtn;
        private Button transBtn;
        private Button deleteBtn;
        private Button addBtn;
        private Button searchBtn;
        private Button editBtn;
        private TextBox emailBox;
        private Label emailLabel;
        private TextBox phoneBox;
        private Label phoneLabel;
        private TrackBar trackBar;
    }
}