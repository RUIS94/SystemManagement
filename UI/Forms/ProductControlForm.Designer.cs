namespace UI
{
    partial class ProductControlForm
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
            pictureBox = new PictureBox();
            graphBtn = new Button();
            trackBar = new TrackBar();
            transBtn = new Button();
            groupBox = new TextBox();
            deleteBtn = new Button();
            latestOrderCostBox = new TextBox();
            addBtn = new Button();
            groupLabel = new Label();
            searchBtn = new Button();
            latestOrderIDBox = new TextBox();
            editBtn = new Button();
            barcodeBox = new TextBox();
            recCostLabel = new Label();
            barcodeLabel = new Label();
            nameBox = new TextBox();
            currentCostBox = new TextBox();
            nameLabel = new Label();
            latOrdLabel = new Label();
            idBox = new TextBox();
            currCostLabel = new Label();
            saveBtn = new Button();
            latestUpdateQuantityBox = new TextBox();
            undoBtn = new Button();
            priceBox = new TextBox();
            searBtn = new Button();
            priceLabel = new Label();
            searchBox = new TextBox();
            latUpdQLabel = new Label();
            idLabel = new Label();
            pricingLabel = new Label();
            searchLabel = new Label();
            latestUpdateTimeBox = new TextBox();
            latUpdTLabel = new Label();
            invtLabel = new Label();
            currentInventoryBox = new TextBox();
            currInvtLabel = new Label();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homePanel.Controls.Add(pictureBox);
            homePanel.Controls.Add(graphBtn);
            homePanel.Controls.Add(trackBar);
            homePanel.Controls.Add(transBtn);
            homePanel.Controls.Add(groupBox);
            homePanel.Controls.Add(deleteBtn);
            homePanel.Controls.Add(latestOrderCostBox);
            homePanel.Controls.Add(addBtn);
            homePanel.Controls.Add(groupLabel);
            homePanel.Controls.Add(searchBtn);
            homePanel.Controls.Add(latestOrderIDBox);
            homePanel.Controls.Add(editBtn);
            homePanel.Controls.Add(barcodeBox);
            homePanel.Controls.Add(recCostLabel);
            homePanel.Controls.Add(barcodeLabel);
            homePanel.Controls.Add(nameBox);
            homePanel.Controls.Add(currentCostBox);
            homePanel.Controls.Add(nameLabel);
            homePanel.Controls.Add(latOrdLabel);
            homePanel.Controls.Add(idBox);
            homePanel.Controls.Add(currCostLabel);
            homePanel.Controls.Add(saveBtn);
            homePanel.Controls.Add(latestUpdateQuantityBox);
            homePanel.Controls.Add(undoBtn);
            homePanel.Controls.Add(priceBox);
            homePanel.Controls.Add(searBtn);
            homePanel.Controls.Add(priceLabel);
            homePanel.Controls.Add(searchBox);
            homePanel.Controls.Add(latUpdQLabel);
            homePanel.Controls.Add(idLabel);
            homePanel.Controls.Add(pricingLabel);
            homePanel.Controls.Add(searchLabel);
            homePanel.Controls.Add(latestUpdateTimeBox);
            homePanel.Controls.Add(latUpdTLabel);
            homePanel.Controls.Add(invtLabel);
            homePanel.Controls.Add(currentInventoryBox);
            homePanel.Controls.Add(currInvtLabel);
            homePanel.Location = new Point(12, 12);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(760, 437);
            homePanel.TabIndex = 2;
            homePanel.Click += homePanel_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(511, 189);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(213, 238);
            pictureBox.TabIndex = 21;
            pictureBox.TabStop = false;
            // 
            // graphBtn
            // 
            graphBtn.Anchor = AnchorStyles.None;
            graphBtn.Location = new Point(15, 278);
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
            trackBar.Location = new Point(9, 404);
            trackBar.Maximum = 1;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(76, 23);
            trackBar.TabIndex = 2;
            trackBar.TickStyle = TickStyle.None;
            trackBar.Scroll += trackBar_Scroll;
            // 
            // transBtn
            // 
            transBtn.Anchor = AnchorStyles.None;
            transBtn.Location = new Point(15, 227);
            transBtn.Name = "transBtn";
            transBtn.Size = new Size(76, 46);
            transBtn.TabIndex = 5;
            transBtn.Text = "Trans (F6)";
            transBtn.UseVisualStyleBackColor = true;
            transBtn.Click += transBtn_Click;
            // 
            // groupBox
            // 
            groupBox.Location = new Point(164, 142);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(232, 23);
            groupBox.TabIndex = 12;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.None;
            deleteBtn.Location = new Point(15, 175);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(76, 46);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete (F5)";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // latestOrderCostBox
            // 
            latestOrderCostBox.Location = new Point(161, 267);
            latestOrderCostBox.Name = "latestOrderCostBox";
            latestOrderCostBox.Size = new Size(232, 23);
            latestOrderCostBox.TabIndex = 12;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.None;
            addBtn.Location = new Point(15, 123);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(76, 46);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add (F4)";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new Point(97, 146);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(40, 15);
            groupLabel.TabIndex = 11;
            groupLabel.Text = "Group";
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.None;
            searchBtn.Location = new Point(15, 70);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(76, 46);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search (F3)";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // latestOrderIDBox
            // 
            latestOrderIDBox.Location = new Point(585, 73);
            latestOrderIDBox.Name = "latestOrderIDBox";
            latestOrderIDBox.Size = new Size(139, 23);
            latestOrderIDBox.TabIndex = 20;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.None;
            editBtn.Location = new Point(15, 18);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(76, 46);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit (F2)";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // barcodeBox
            // 
            barcodeBox.Location = new Point(164, 113);
            barcodeBox.Name = "barcodeBox";
            barcodeBox.Size = new Size(232, 23);
            barcodeBox.TabIndex = 10;
            // 
            // recCostLabel
            // 
            recCostLabel.AutoSize = true;
            recCostLabel.Location = new Point(94, 270);
            recCostLabel.Name = "recCostLabel";
            recCostLabel.Size = new Size(53, 15);
            recCostLabel.TabIndex = 11;
            recCostLabel.Text = "Rec.Cost";
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Location = new Point(97, 116);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new Size(50, 15);
            barcodeLabel.TabIndex = 9;
            barcodeLabel.Text = "Barcode";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(164, 84);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(232, 23);
            nameBox.TabIndex = 8;
            // 
            // currentCostBox
            // 
            currentCostBox.Location = new Point(161, 242);
            currentCostBox.Name = "currentCostBox";
            currentCostBox.Size = new Size(232, 23);
            currentCostBox.TabIndex = 10;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(97, 87);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name";
            // 
            // latOrdLabel
            // 
            latOrdLabel.AutoSize = true;
            latOrdLabel.Location = new Point(513, 75);
            latOrdLabel.Name = "latOrdLabel";
            latOrdLabel.Size = new Size(46, 15);
            latOrdLabel.TabIndex = 19;
            latOrdLabel.Text = "Lat.Ord";
            // 
            // idBox
            // 
            idBox.Location = new Point(164, 55);
            idBox.Name = "idBox";
            idBox.Size = new Size(100, 23);
            idBox.TabIndex = 6;
            // 
            // currCostLabel
            // 
            currCostLabel.AutoSize = true;
            currCostLabel.Location = new Point(94, 244);
            currCostLabel.Name = "currCostLabel";
            currCostLabel.Size = new Size(57, 15);
            currCostLabel.TabIndex = 9;
            currCostLabel.Text = "Curr.Cost";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(402, 21);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(60, 20);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // latestUpdateQuantityBox
            // 
            latestUpdateQuantityBox.Location = new Point(585, 124);
            latestUpdateQuantityBox.Name = "latestUpdateQuantityBox";
            latestUpdateQuantityBox.Size = new Size(139, 23);
            latestUpdateQuantityBox.TabIndex = 18;
            // 
            // undoBtn
            // 
            undoBtn.Location = new Point(336, 20);
            undoBtn.Name = "undoBtn";
            undoBtn.Size = new Size(60, 20);
            undoBtn.TabIndex = 4;
            undoBtn.Text = "Undo";
            undoBtn.UseVisualStyleBackColor = true;
            undoBtn.Click += undoBtn_Click;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(161, 216);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(232, 23);
            priceBox.TabIndex = 8;
            // 
            // searBtn
            // 
            searBtn.Location = new Point(270, 20);
            searBtn.Name = "searBtn";
            searBtn.Size = new Size(60, 20);
            searBtn.TabIndex = 3;
            searBtn.Text = "Search";
            searBtn.UseVisualStyleBackColor = true;
            searBtn.Click += searBtn_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(94, 219);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(33, 15);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "Price";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(164, 18);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(100, 23);
            searchBox.TabIndex = 2;
            // 
            // latUpdQLabel
            // 
            latUpdQLabel.AutoSize = true;
            latUpdQLabel.Location = new Point(513, 127);
            latUpdQLabel.Name = "latUpdQLabel";
            latUpdQLabel.Size = new Size(60, 15);
            latUpdQLabel.TabIndex = 17;
            latUpdQLabel.Text = "Lat.Upd.Q";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(97, 58);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(60, 15);
            idLabel.TabIndex = 1;
            idLabel.Text = "ProdCode";
            // 
            // pricingLabel
            // 
            pricingLabel.AutoSize = true;
            pricingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pricingLabel.Location = new Point(94, 189);
            pricingLabel.Name = "pricingLabel";
            pricingLabel.Size = new Size(64, 21);
            pricingLabel.TabIndex = 1;
            pricingLabel.Text = "Pricing";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchLabel.Location = new Point(97, 18);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(61, 21);
            searchLabel.TabIndex = 0;
            searchLabel.Text = "Search";
            // 
            // latestUpdateTimeBox
            // 
            latestUpdateTimeBox.Location = new Point(585, 98);
            latestUpdateTimeBox.Name = "latestUpdateTimeBox";
            latestUpdateTimeBox.Size = new Size(139, 23);
            latestUpdateTimeBox.TabIndex = 14;
            // 
            // latUpdTLabel
            // 
            latUpdTLabel.AutoSize = true;
            latUpdTLabel.Location = new Point(513, 100);
            latUpdTLabel.Name = "latUpdTLabel";
            latUpdTLabel.Size = new Size(57, 15);
            latUpdTLabel.TabIndex = 13;
            latUpdTLabel.Text = "Lat.Upd.T";
            // 
            // invtLabel
            // 
            invtLabel.AutoSize = true;
            invtLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invtLabel.Location = new Point(511, 9);
            invtLabel.Name = "invtLabel";
            invtLabel.Size = new Size(85, 21);
            invtLabel.TabIndex = 2;
            invtLabel.Text = "Inventory";
            // 
            // currentInventoryBox
            // 
            currentInventoryBox.Location = new Point(585, 47);
            currentInventoryBox.Name = "currentInventoryBox";
            currentInventoryBox.Size = new Size(139, 23);
            currentInventoryBox.TabIndex = 12;
            // 
            // currInvtLabel
            // 
            currInvtLabel.AutoSize = true;
            currInvtLabel.Location = new Point(513, 49);
            currInvtLabel.Name = "currInvtLabel";
            currInvtLabel.Size = new Size(53, 15);
            currInvtLabel.TabIndex = 11;
            currInvtLabel.Text = "Curr.Invt";
            // 
            // ProductControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(homePanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "ProductControlForm";
            Text = "Product Control";
            Load += ProductControlForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private TextBox currentCostBox;
        private Label currCostLabel;
        private TextBox priceBox;
        private Label priceLabel;
        private Label pricingLabel;
        private TextBox barcodeBox;
        private Label barcodeLabel;
        private TextBox nameBox;
        private Label nameLabel;
        private TextBox idBox;
        private Button saveBtn;
        private Button undoBtn;
        private Button searBtn;
        private TextBox searchBox;
        private Label idLabel;
        private Label searchLabel;
        private TextBox latestOrderCostBox;
        private Label recCostLabel;
        private TextBox latestOrderIDBox;
        private Label latOrdLabel;
        private TextBox latestUpdateQuantityBox;
        private Label latUpdQLabel;
        private TextBox latestUpdateTimeBox;
        private Label latUpdTLabel;
        private TextBox currentInventoryBox;
        private Label currInvtLabel;
        private Label invtLabel;
        private TextBox groupBox;
        private Label groupLabel;
        private Button graphBtn;
        private Button transBtn;
        private Button deleteBtn;
        private Button addBtn;
        private Button searchBtn;
        private Button editBtn;
        private TrackBar trackBar;
        private PictureBox pictureBox;
    }
}