namespace UI
{
    partial class UserControlForm
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
            technician = new RadioButton();
            deleteBtn = new Button();
            emailBox = new TextBox();
            addBtn = new Button();
            accountant = new RadioButton();
            searchBtn = new Button();
            salesman = new RadioButton();
            editBtn = new Button();
            emailLabel = new Label();
            manager = new RadioButton();
            roleLabel = new Label();
            phoneBox = new TextBox();
            passwordBox = new TextBox();
            passwordLabel = new Label();
            phoneLabel = new Label();
            securityLabel = new Label();
            address2Box = new TextBox();
            searchLabel = new Label();
            address1Box = new TextBox();
            idLabel = new Label();
            addressLabel = new Label();
            searchBox = new TextBox();
            nameBox = new TextBox();
            searBtn = new Button();
            nameLabel = new Label();
            undoBtn = new Button();
            idBox = new TextBox();
            saveBtn = new Button();
            roleBox = new TextBox();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(roleBox);
            homePanel.Controls.Add(graphBtn);
            homePanel.Controls.Add(trackBar);
            homePanel.Controls.Add(transBtn);
            homePanel.Controls.Add(technician);
            homePanel.Controls.Add(deleteBtn);
            homePanel.Controls.Add(emailBox);
            homePanel.Controls.Add(addBtn);
            homePanel.Controls.Add(accountant);
            homePanel.Controls.Add(searchBtn);
            homePanel.Controls.Add(salesman);
            homePanel.Controls.Add(editBtn);
            homePanel.Controls.Add(emailLabel);
            homePanel.Controls.Add(manager);
            homePanel.Controls.Add(roleLabel);
            homePanel.Controls.Add(phoneBox);
            homePanel.Controls.Add(passwordBox);
            homePanel.Controls.Add(passwordLabel);
            homePanel.Controls.Add(phoneLabel);
            homePanel.Controls.Add(securityLabel);
            homePanel.Controls.Add(address2Box);
            homePanel.Controls.Add(searchLabel);
            homePanel.Controls.Add(address1Box);
            homePanel.Controls.Add(idLabel);
            homePanel.Controls.Add(addressLabel);
            homePanel.Controls.Add(searchBox);
            homePanel.Controls.Add(nameBox);
            homePanel.Controls.Add(searBtn);
            homePanel.Controls.Add(nameLabel);
            homePanel.Controls.Add(undoBtn);
            homePanel.Controls.Add(idBox);
            homePanel.Controls.Add(saveBtn);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(784, 521);
            homePanel.TabIndex = 1;
            homePanel.Click += homePanel_Click;
            // 
            // graphBtn
            // 
            graphBtn.Anchor = AnchorStyles.None;
            graphBtn.Location = new Point(6, 316);
            graphBtn.Name = "graphBtn";
            graphBtn.Size = new Size(76, 52);
            graphBtn.TabIndex = 6;
            graphBtn.Text = "Graphs";
            graphBtn.UseVisualStyleBackColor = true;
            graphBtn.Click += graphBtn_Click;
            // 
            // trackBar
            // 
            trackBar.AutoSize = false;
            trackBar.BackColor = Color.Silver;
            trackBar.Location = new Point(6, 458);
            trackBar.Maximum = 1;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(76, 26);
            trackBar.TabIndex = 2;
            trackBar.TickStyle = TickStyle.None;
            trackBar.Scroll += trackBar_Scroll;
            // 
            // transBtn
            // 
            transBtn.Anchor = AnchorStyles.None;
            transBtn.Location = new Point(6, 258);
            transBtn.Name = "transBtn";
            transBtn.Size = new Size(76, 52);
            transBtn.TabIndex = 5;
            transBtn.Text = "Trans";
            transBtn.UseVisualStyleBackColor = true;
            transBtn.Click += transBtn_Click;
            // 
            // technician
            // 
            technician.AutoSize = true;
            technician.Location = new Point(159, 403);
            technician.Name = "technician";
            technician.Size = new Size(86, 21);
            technician.TabIndex = 15;
            technician.TabStop = true;
            technician.Text = "Technician";
            technician.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.None;
            deleteBtn.Location = new Point(6, 199);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(76, 52);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(159, 143);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(232, 23);
            emailBox.TabIndex = 15;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.None;
            addBtn.Location = new Point(6, 140);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(76, 52);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // accountant
            // 
            accountant.AutoSize = true;
            accountant.Location = new Point(159, 376);
            accountant.Name = "accountant";
            accountant.Size = new Size(90, 21);
            accountant.TabIndex = 14;
            accountant.TabStop = true;
            accountant.Text = "Accountant";
            accountant.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.None;
            searchBtn.Location = new Point(6, 81);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(76, 52);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // salesman
            // 
            salesman.AutoSize = true;
            salesman.Location = new Point(159, 349);
            salesman.Name = "salesman";
            salesman.Size = new Size(81, 21);
            salesman.TabIndex = 13;
            salesman.TabStop = true;
            salesman.Text = "Salesman";
            salesman.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.None;
            editBtn.Location = new Point(6, 22);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(76, 52);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(92, 145);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 17);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email";
            // 
            // manager
            // 
            manager.AutoSize = true;
            manager.Location = new Point(160, 323);
            manager.Name = "manager";
            manager.Size = new Size(79, 21);
            manager.TabIndex = 12;
            manager.TabStop = true;
            manager.Text = "Manager";
            manager.UseVisualStyleBackColor = true;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(93, 324);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(34, 17);
            roleLabel.TabIndex = 11;
            roleLabel.Text = "Role";
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(159, 113);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(232, 23);
            phoneBox.TabIndex = 13;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(159, 289);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(232, 23);
            passwordBox.TabIndex = 10;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(93, 294);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(64, 17);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(92, 117);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(44, 17);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Phone";
            // 
            // securityLabel
            // 
            securityLabel.AutoSize = true;
            securityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            securityLabel.Location = new Point(92, 245);
            securityLabel.Name = "securityLabel";
            securityLabel.Size = new Size(72, 21);
            securityLabel.TabIndex = 1;
            securityLabel.Text = "Security";
            // 
            // address2Box
            // 
            address2Box.Location = new Point(159, 201);
            address2Box.Name = "address2Box";
            address2Box.Size = new Size(232, 23);
            address2Box.TabIndex = 11;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchLabel.Location = new Point(92, 9);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(61, 21);
            searchLabel.TabIndex = 0;
            searchLabel.Text = "Search";
            // 
            // address1Box
            // 
            address1Box.Location = new Point(159, 171);
            address1Box.Name = "address1Box";
            address1Box.Size = new Size(232, 23);
            address1Box.TabIndex = 10;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(92, 54);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(48, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "UserID";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(92, 176);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(43, 17);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Postal";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(159, 9);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(100, 23);
            searchBox.TabIndex = 2;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(159, 84);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(232, 23);
            nameBox.TabIndex = 8;
            // 
            // searBtn
            // 
            searBtn.Location = new Point(265, 11);
            searBtn.Name = "searBtn";
            searBtn.Size = new Size(60, 23);
            searBtn.TabIndex = 3;
            searBtn.Text = "Search";
            searBtn.UseVisualStyleBackColor = true;
            searBtn.Click += searBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(92, 87);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(43, 17);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name";
            // 
            // undoBtn
            // 
            undoBtn.Location = new Point(331, 11);
            undoBtn.Name = "undoBtn";
            undoBtn.Size = new Size(60, 23);
            undoBtn.TabIndex = 4;
            undoBtn.Text = "Undo";
            undoBtn.UseVisualStyleBackColor = true;
            undoBtn.Click += undoBtn_Click;
            // 
            // idBox
            // 
            idBox.Location = new Point(159, 51);
            idBox.Name = "idBox";
            idBox.Size = new Size(100, 23);
            idBox.TabIndex = 6;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(397, 12);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(60, 23);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // roleBox
            // 
            roleBox.Location = new Point(159, 430);
            roleBox.Name = "roleBox";
            roleBox.ReadOnly = true;
            roleBox.Size = new Size(100, 23);
            roleBox.TabIndex = 16;
            roleBox.Visible = false;
            // 
            // UserControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 521);
            Controls.Add(homePanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "UserControlForm";
            Text = "UserControlForm";
            Load += UserControlForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
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
        private RadioButton technician;
        private RadioButton accountant;
        private RadioButton salesman;
        private RadioButton manager;
        private Label roleLabel;
        private TextBox passwordBox;
        private Label passwordLabel;
        private Label securityLabel;
        private TrackBar trackBar;
        private TextBox roleBox;
    }
}