namespace UI
{
    partial class CustomerOrder
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
            nameBox = new TextBox();
            nameLabel = new Label();
            emailBox = new TextBox();
            emailLabel = new Label();
            orderNoBox = new TextBox();
            ordNoLabel = new Label();
            sumTotalBox = new TextBox();
            sumTotalLabel = new Label();
            gstBox = new TextBox();
            gstLabel = new Label();
            subTotalBox = new TextBox();
            subTotalLabel = new Label();
            cancelOrder = new Button();
            confirmOrder = new Button();
            deleprod = new Button();
            cartList = new DataGridView();
            sequence = new DataGridViewTextBoxColumn();
            code = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            addressBox2 = new TextBox();
            userLabel = new Label();
            orderDateBox = new TextBox();
            ordDateLabel = new Label();
            statusBox = new TextBox();
            statusLabel = new Label();
            addressBox1 = new TextBox();
            addressLabel = new Label();
            idBox = new TextBox();
            idLabel = new Label();
            searchBtn2 = new Button();
            searchBox2 = new TextBox();
            searchLabel2 = new Label();
            searchBtn1 = new Button();
            searchBox1 = new TextBox();
            searchLabel1 = new Label();
            operatorBox = new ComboBox();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartList).BeginInit();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Anchor = AnchorStyles.None;
            homePanel.Controls.Add(operatorBox);
            homePanel.Controls.Add(nameBox);
            homePanel.Controls.Add(nameLabel);
            homePanel.Controls.Add(emailBox);
            homePanel.Controls.Add(emailLabel);
            homePanel.Controls.Add(orderNoBox);
            homePanel.Controls.Add(ordNoLabel);
            homePanel.Controls.Add(sumTotalBox);
            homePanel.Controls.Add(sumTotalLabel);
            homePanel.Controls.Add(gstBox);
            homePanel.Controls.Add(gstLabel);
            homePanel.Controls.Add(subTotalBox);
            homePanel.Controls.Add(subTotalLabel);
            homePanel.Controls.Add(cancelOrder);
            homePanel.Controls.Add(confirmOrder);
            homePanel.Controls.Add(deleprod);
            homePanel.Controls.Add(cartList);
            homePanel.Controls.Add(addressBox2);
            homePanel.Controls.Add(userLabel);
            homePanel.Controls.Add(orderDateBox);
            homePanel.Controls.Add(ordDateLabel);
            homePanel.Controls.Add(statusBox);
            homePanel.Controls.Add(statusLabel);
            homePanel.Controls.Add(addressBox1);
            homePanel.Controls.Add(addressLabel);
            homePanel.Controls.Add(idBox);
            homePanel.Controls.Add(idLabel);
            homePanel.Controls.Add(searchBtn2);
            homePanel.Controls.Add(searchBox2);
            homePanel.Controls.Add(searchLabel2);
            homePanel.Controls.Add(searchBtn1);
            homePanel.Controls.Add(searchBox1);
            homePanel.Controls.Add(searchLabel1);
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(794, 389);
            homePanel.TabIndex = 0;
            homePanel.Click += homePanel_Click;
            // 
            // nameBox
            // 
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Location = new Point(133, 70);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(218, 23);
            nameBox.TabIndex = 36;
            nameBox.KeyDown += nameBox_KeyDown;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(13, 71);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(94, 15);
            nameLabel.TabIndex = 35;
            nameLabel.Text = "Customer Name";
            // 
            // emailBox
            // 
            emailBox.BorderStyle = BorderStyle.FixedSingle;
            emailBox.Location = new Point(419, 44);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(100, 23);
            emailBox.TabIndex = 34;
            emailBox.KeyDown += emailBox_KeyDown;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(357, 47);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 33;
            emailLabel.Text = "Email";
            // 
            // orderNoBox
            // 
            orderNoBox.BorderStyle = BorderStyle.FixedSingle;
            orderNoBox.Location = new Point(626, 44);
            orderNoBox.Name = "orderNoBox";
            orderNoBox.Size = new Size(100, 23);
            orderNoBox.TabIndex = 32;
            orderNoBox.KeyDown += orderNoBox_KeyDown;
            // 
            // ordNoLabel
            // 
            ordNoLabel.AutoSize = true;
            ordNoLabel.Location = new Point(551, 47);
            ordNoLabel.Name = "ordNoLabel";
            ordNoLabel.Size = new Size(59, 15);
            ordNoLabel.TabIndex = 31;
            ordNoLabel.Text = "Order No.";
            // 
            // sumTotalBox
            // 
            sumTotalBox.Location = new Point(682, 358);
            sumTotalBox.Name = "sumTotalBox";
            sumTotalBox.ReadOnly = true;
            sumTotalBox.Size = new Size(100, 23);
            sumTotalBox.TabIndex = 30;
            // 
            // sumTotalLabel
            // 
            sumTotalLabel.AutoSize = true;
            sumTotalLabel.Location = new Point(613, 361);
            sumTotalLabel.Name = "sumTotalLabel";
            sumTotalLabel.Size = new Size(59, 15);
            sumTotalLabel.TabIndex = 29;
            sumTotalLabel.Text = "Sum Total";
            // 
            // gstBox
            // 
            gstBox.Location = new Point(682, 333);
            gstBox.Name = "gstBox";
            gstBox.ReadOnly = true;
            gstBox.Size = new Size(100, 23);
            gstBox.TabIndex = 28;
            // 
            // gstLabel
            // 
            gstLabel.AutoSize = true;
            gstLabel.Location = new Point(613, 335);
            gstLabel.Name = "gstLabel";
            gstLabel.Size = new Size(27, 15);
            gstLabel.TabIndex = 27;
            gstLabel.Text = "GST";
            // 
            // subTotalBox
            // 
            subTotalBox.Location = new Point(682, 307);
            subTotalBox.Name = "subTotalBox";
            subTotalBox.ReadOnly = true;
            subTotalBox.Size = new Size(100, 23);
            subTotalBox.TabIndex = 26;
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new Point(613, 310);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new Size(55, 15);
            subTotalLabel.TabIndex = 25;
            subTotalLabel.Text = "Sub Total";
            // 
            // cancelOrder
            // 
            cancelOrder.Anchor = AnchorStyles.None;
            cancelOrder.Location = new Point(185, 310);
            cancelOrder.Name = "cancelOrder";
            cancelOrder.Size = new Size(80, 71);
            cancelOrder.TabIndex = 24;
            cancelOrder.Text = "Cancel Order";
            cancelOrder.UseVisualStyleBackColor = true;
            cancelOrder.Click += cancelOrder_Click;
            // 
            // confirmOrder
            // 
            confirmOrder.Anchor = AnchorStyles.None;
            confirmOrder.Location = new Point(99, 310);
            confirmOrder.Name = "confirmOrder";
            confirmOrder.Size = new Size(80, 71);
            confirmOrder.TabIndex = 23;
            confirmOrder.Text = "Confirm Order";
            confirmOrder.UseVisualStyleBackColor = true;
            confirmOrder.Click += confirmOrder_Click;
            // 
            // deleprod
            // 
            deleprod.Anchor = AnchorStyles.None;
            deleprod.Location = new Point(13, 310);
            deleprod.Name = "deleprod";
            deleprod.Size = new Size(80, 71);
            deleprod.TabIndex = 22;
            deleprod.Text = "Delete Select Product";
            deleprod.UseVisualStyleBackColor = true;
            deleprod.Click += deleprod_Click;
            // 
            // cartList
            // 
            cartList.AllowUserToAddRows = false;
            cartList.AllowUserToDeleteRows = false;
            cartList.Anchor = AnchorStyles.None;
            cartList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartList.Columns.AddRange(new DataGridViewColumn[] { sequence, code, name, status, quantity, price, discount, total });
            cartList.EditMode = DataGridViewEditMode.EditProgrammatically;
            cartList.Location = new Point(12, 146);
            cartList.Name = "cartList";
            cartList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            cartList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cartList.Size = new Size(770, 155);
            cartList.TabIndex = 21;
            cartList.UseWaitCursor = true;
            cartList.CellEnter += cartList_CellEnter;
            cartList.CellValueChanged += cartList_CellValueChanged;
            cartList.EditingControlShowing += cartList_EditingControlShowing;
            cartList.Leave += cartList_Leave;
            // 
            // sequence
            // 
            sequence.HeaderText = "No.";
            sequence.Name = "sequence";
            sequence.ReadOnly = true;
            sequence.Resizable = DataGridViewTriState.False;
            sequence.Width = 50;
            // 
            // code
            // 
            code.HeaderText = "ProductCode";
            code.Name = "code";
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Inventory";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.HeaderText = "Qty.";
            quantity.Name = "quantity";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
            // 
            // discount
            // 
            discount.HeaderText = "Discount";
            discount.Name = "discount";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // addressBox2
            // 
            addressBox2.BorderStyle = BorderStyle.FixedSingle;
            addressBox2.Location = new Point(133, 121);
            addressBox2.Name = "addressBox2";
            addressBox2.Size = new Size(218, 23);
            addressBox2.TabIndex = 20;
            addressBox2.KeyDown += addressBox2_KeyDown;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(551, 124);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(54, 15);
            userLabel.TabIndex = 16;
            userLabel.Text = "Operator";
            // 
            // orderDateBox
            // 
            orderDateBox.BorderStyle = BorderStyle.FixedSingle;
            orderDateBox.Location = new Point(626, 95);
            orderDateBox.Name = "orderDateBox";
            orderDateBox.Size = new Size(156, 23);
            orderDateBox.TabIndex = 15;
            orderDateBox.KeyDown += orderDateBox_KeyDown;
            // 
            // ordDateLabel
            // 
            ordDateLabel.AutoSize = true;
            ordDateLabel.Location = new Point(551, 98);
            ordDateLabel.Name = "ordDateLabel";
            ordDateLabel.Size = new Size(31, 15);
            ordDateLabel.TabIndex = 14;
            ordDateLabel.Text = "Date";
            // 
            // statusBox
            // 
            statusBox.BorderStyle = BorderStyle.FixedSingle;
            statusBox.Location = new Point(626, 70);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(156, 23);
            statusBox.TabIndex = 13;
            statusBox.KeyDown += statusBox_KeyDown;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(551, 71);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 15);
            statusLabel.TabIndex = 12;
            statusLabel.Text = "Status";
            // 
            // addressBox1
            // 
            addressBox1.BorderStyle = BorderStyle.FixedSingle;
            addressBox1.Location = new Point(133, 95);
            addressBox1.Name = "addressBox1";
            addressBox1.Size = new Size(218, 23);
            addressBox1.TabIndex = 11;
            addressBox1.KeyDown += addressBox1_KeyDown;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(11, 98);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(104, 15);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "Customer Address";
            // 
            // idBox
            // 
            idBox.BorderStyle = BorderStyle.FixedSingle;
            idBox.Location = new Point(133, 44);
            idBox.Name = "idBox";
            idBox.ReadOnly = true;
            idBox.Size = new Size(100, 23);
            idBox.TabIndex = 7;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(13, 48);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(70, 15);
            idLabel.TabIndex = 6;
            idLabel.Text = "CustomerID";
            // 
            // searchBtn2
            // 
            searchBtn2.Location = new Point(503, 335);
            searchBtn2.Name = "searchBtn2";
            searchBtn2.Size = new Size(64, 20);
            searchBtn2.TabIndex = 5;
            searchBtn2.Text = "Search";
            searchBtn2.UseVisualStyleBackColor = true;
            searchBtn2.Click += searchBtn2_Click;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(397, 335);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(100, 23);
            searchBox2.TabIndex = 4;
            searchBox2.KeyDown += searchBox2_KeyDown;
            // 
            // searchLabel2
            // 
            searchLabel2.AutoSize = true;
            searchLabel2.Location = new Point(295, 338);
            searchLabel2.Name = "searchLabel2";
            searchLabel2.Size = new Size(87, 15);
            searchLabel2.TabIndex = 3;
            searchLabel2.Text = "Search Product";
            // 
            // searchBtn1
            // 
            searchBtn1.Location = new Point(239, 19);
            searchBtn1.Name = "searchBtn1";
            searchBtn1.Size = new Size(64, 20);
            searchBtn1.TabIndex = 2;
            searchBtn1.Text = "Search";
            searchBtn1.UseVisualStyleBackColor = true;
            searchBtn1.Click += searchBtn1_Click;
            // 
            // searchBox1
            // 
            searchBox1.BorderStyle = BorderStyle.FixedSingle;
            searchBox1.Location = new Point(133, 19);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(100, 23);
            searchBox1.TabIndex = 1;
            searchBox1.KeyDown += searchBox1_KeyDown;
            // 
            // searchLabel1
            // 
            searchLabel1.AutoSize = true;
            searchLabel1.Location = new Point(12, 21);
            searchLabel1.Name = "searchLabel1";
            searchLabel1.Size = new Size(97, 15);
            searchLabel1.TabIndex = 0;
            searchLabel1.Text = "Search Customer";
            // 
            // operatorBox
            // 
            operatorBox.FormattingEnabled = true;
            operatorBox.Location = new Point(626, 121);
            operatorBox.Name = "operatorBox";
            operatorBox.Size = new Size(156, 23);
            operatorBox.TabIndex = 37;
            // 
            // CustomerOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 389);
            Controls.Add(homePanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "CustomerOrder";
            Text = "Customer Order";
            Load += CustomerOrder_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cartList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private Label searchLabel1;
        private Button searchBtn2;
        private TextBox searchBox2;
        private Label searchLabel2;
        private Button searchBtn1;
        private TextBox searchBox1;
        private TextBox addressBox2;
        private Label userLabel;
        private TextBox orderDateBox;
        private Label ordDateLabel;
        private TextBox statusBox;
        private Label statusLabel;
        private TextBox addressBox1;
        private Label addressLabel;
        private TextBox idBox;
        private Label idLabel;
        private TextBox sumTotalBox;
        private Label sumTotalLabel;
        private TextBox gstBox;
        private Label gstLabel;
        private TextBox subTotalBox;
        private Label subTotalLabel;
        private Button cancelOrder;
        private Button confirmOrder;
        private Button deleprod;
        private DataGridView cartList;
        private TextBox orderNoBox;
        private Label ordNoLabel;
        private TextBox nameBox;
        private Label nameLabel;
        private TextBox emailBox;
        private Label emailLabel;
        private DataGridViewTextBoxColumn sequence;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn total;
        private ComboBox operatorBox;
    }
}