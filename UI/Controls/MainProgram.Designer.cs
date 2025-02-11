﻿namespace UI.Controls
{
    partial class MainProgram
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            capanel1 = new Panel();
            capanel2 = new Panel();
            caCloseL = new Label();
            caLabel = new Label();
            smalltoolsPanel = new Panel();
            emailP = new PictureBox();
            calculatorP = new PictureBox();
            calendarP = new PictureBox();
            opentoolsPanel = new Label();
            fucPanel = new Panel();
            timeLabel = new Label();
            exchangeForm = new ComboBox();
            lockBtn = new Button();
            signBtn = new Button();
            homePanelContainer = new Panel();
            homePanel = new Panel();
            mainBtnPanel = new Panel();
            logoLabel = new Label();
            panel3 = new Panel();
            button3 = new Button();
            adminDisplayBtn = new Button();
            panel1 = new Panel();
            button1 = new Button();
            controlsDisplayBtn = new Button();
            panel2 = new Panel();
            button2 = new Button();
            ordersDisplayBtn = new Button();
            adminBtnPanel = new Panel();
            taskMenuBtn = new Button();
            userCtrlBtn = new Button();
            ordersBtnPanel = new Panel();
            cartCtrlBtn = new Button();
            goodsInBtn = new Button();
            suppOrderBtn = new Button();
            controlsBtnPanel = new Panel();
            custCtrlBtn = new Button();
            prodCtrlBtn = new Button();
            suppCtrlBtn = new Button();
            toolsPanel = new Panel();
            exchangePanel = new Panel();
            closetoolsPanel = new Label();
            wallpaperBtn = new Button();
            exchangeBtn = new Button();
            emailBtn = new Button();
            helpLabel = new Label();
            calculatorPanel = new Panel();
            calculatorBtn = new Button();
            calendarPanel = new Panel();
            openCalendar = new Label();
            calendarBtn = new Button();
            mainPanel.SuspendLayout();
            capanel1.SuspendLayout();
            smalltoolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emailP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calculatorP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarP).BeginInit();
            fucPanel.SuspendLayout();
            homePanelContainer.SuspendLayout();
            mainBtnPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            adminBtnPanel.SuspendLayout();
            ordersBtnPanel.SuspendLayout();
            controlsBtnPanel.SuspendLayout();
            toolsPanel.SuspendLayout();
            calendarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(64, 64, 64);
            mainPanel.Controls.Add(capanel1);
            mainPanel.Controls.Add(smalltoolsPanel);
            mainPanel.Controls.Add(fucPanel);
            mainPanel.Controls.Add(homePanelContainer);
            mainPanel.Controls.Add(mainBtnPanel);
            mainPanel.Controls.Add(toolsPanel);
            mainPanel.Location = new Point(3, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1100, 900);
            mainPanel.TabIndex = 0;
            // 
            // capanel1
            // 
            capanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            capanel1.BackColor = Color.Black;
            capanel1.Controls.Add(capanel2);
            capanel1.Controls.Add(caCloseL);
            capanel1.Controls.Add(caLabel);
            capanel1.Location = new Point(918, 341);
            capanel1.Name = "capanel1";
            capanel1.Size = new Size(142, 296);
            capanel1.TabIndex = 10;
            capanel1.Visible = false;
            // 
            // capanel2
            // 
            capanel2.BackColor = Color.White;
            capanel2.Location = new Point(3, 32);
            capanel2.Name = "capanel2";
            capanel2.Size = new Size(135, 258);
            capanel2.TabIndex = 1;
            capanel2.Paint += capanel2_Paint;
            // 
            // caCloseL
            // 
            caCloseL.AutoSize = true;
            caCloseL.Font = new Font("Informal Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            caCloseL.ForeColor = Color.FromArgb(192, 0, 0);
            caCloseL.Location = new Point(115, 10);
            caCloseL.Name = "caCloseL";
            caCloseL.Size = new Size(17, 16);
            caCloseL.TabIndex = 1;
            caCloseL.Text = "X";
            caCloseL.Click += caCloseL_Click;
            // 
            // caLabel
            // 
            caLabel.AutoSize = true;
            caLabel.ForeColor = Color.White;
            caLabel.Location = new Point(3, 10);
            caLabel.Name = "caLabel";
            caLabel.Size = new Size(66, 17);
            caLabel.TabIndex = 0;
            caLabel.Text = "Calculator";
            // 
            // smalltoolsPanel
            // 
            smalltoolsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            smalltoolsPanel.BackColor = Color.Black;
            smalltoolsPanel.Controls.Add(emailP);
            smalltoolsPanel.Controls.Add(calculatorP);
            smalltoolsPanel.Controls.Add(calendarP);
            smalltoolsPanel.Controls.Add(opentoolsPanel);
            smalltoolsPanel.Location = new Point(1066, 46);
            smalltoolsPanel.Name = "smalltoolsPanel";
            smalltoolsPanel.Size = new Size(28, 848);
            smalltoolsPanel.TabIndex = 8;
            smalltoolsPanel.Visible = false;
            // 
            // emailP
            // 
            emailP.BackColor = Color.White;
            emailP.BackgroundImageLayout = ImageLayout.Stretch;
            emailP.Location = new Point(3, 515);
            emailP.Name = "emailP";
            emailP.Size = new Size(20, 20);
            emailP.SizeMode = PictureBoxSizeMode.StretchImage;
            emailP.TabIndex = 2;
            emailP.TabStop = false;
            emailP.Click += emailP_Click;
            // 
            // calculatorP
            // 
            calculatorP.BackColor = Color.White;
            calculatorP.BackgroundImageLayout = ImageLayout.Stretch;
            calculatorP.Location = new Point(3, 410);
            calculatorP.Name = "calculatorP";
            calculatorP.Size = new Size(20, 20);
            calculatorP.SizeMode = PictureBoxSizeMode.StretchImage;
            calculatorP.TabIndex = 1;
            calculatorP.TabStop = false;
            calculatorP.Click += calculatorP_Click;
            // 
            // calendarP
            // 
            calendarP.BackColor = Color.White;
            calendarP.BackgroundImageLayout = ImageLayout.Stretch;
            calendarP.Location = new Point(3, 39);
            calendarP.Name = "calendarP";
            calendarP.Size = new Size(20, 20);
            calendarP.SizeMode = PictureBoxSizeMode.StretchImage;
            calendarP.TabIndex = 0;
            calendarP.TabStop = false;
            calendarP.Click += calendarP_Click;
            // 
            // opentoolsPanel
            // 
            opentoolsPanel.AutoSize = true;
            opentoolsPanel.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            opentoolsPanel.ForeColor = Color.White;
            opentoolsPanel.Location = new Point(3, 9);
            opentoolsPanel.Name = "opentoolsPanel";
            opentoolsPanel.Size = new Size(19, 22);
            opentoolsPanel.TabIndex = 0;
            opentoolsPanel.Text = "<";
            opentoolsPanel.Click += opentoolsPanel_Click;
            // 
            // fucPanel
            // 
            fucPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fucPanel.BackColor = Color.Black;
            fucPanel.Controls.Add(timeLabel);
            fucPanel.Controls.Add(exchangeForm);
            fucPanel.Controls.Add(lockBtn);
            fucPanel.Controls.Add(signBtn);
            fucPanel.Location = new Point(139, 3);
            fucPanel.Name = "fucPanel";
            fucPanel.Size = new Size(955, 41);
            fucPanel.TabIndex = 7;
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.White;
            timeLabel.ImageAlign = ContentAlignment.MiddleRight;
            timeLabel.Location = new Point(658, 7);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(119, 25);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "Time Display";
            // 
            // exchangeForm
            // 
            exchangeForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            exchangeForm.FormattingEnabled = true;
            exchangeForm.Location = new Point(3, 9);
            exchangeForm.Name = "exchangeForm";
            exchangeForm.Size = new Size(121, 25);
            exchangeForm.TabIndex = 0;
            exchangeForm.Text = "Home Menu";
            exchangeForm.SelectedIndexChanged += exchangeForm_SelectedIndexChanged;
            // 
            // lockBtn
            // 
            lockBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lockBtn.Location = new Point(800, 3);
            lockBtn.Name = "lockBtn";
            lockBtn.Size = new Size(40, 34);
            lockBtn.TabIndex = 0;
            lockBtn.Text = "L";
            lockBtn.UseVisualStyleBackColor = true;
            lockBtn.Visible = false;
            lockBtn.Click += lockBtn_Click;
            // 
            // signBtn
            // 
            signBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            signBtn.Location = new Point(860, 3);
            signBtn.Name = "signBtn";
            signBtn.Size = new Size(92, 34);
            signBtn.TabIndex = 0;
            signBtn.Text = "sign";
            signBtn.UseVisualStyleBackColor = true;
            signBtn.Click += signBtn_Click;
            // 
            // homePanelContainer
            // 
            homePanelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homePanelContainer.BackColor = Color.Navy;
            homePanelContainer.Controls.Add(homePanel);
            homePanelContainer.Location = new Point(139, 46);
            homePanelContainer.Name = "homePanelContainer";
            homePanelContainer.Size = new Size(811, 848);
            homePanelContainer.TabIndex = 6;
            // 
            // homePanel
            // 
            homePanel.BackColor = SystemColors.ActiveCaption;
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(811, 848);
            homePanel.TabIndex = 2;
            homePanel.Visible = false;
            // 
            // mainBtnPanel
            // 
            mainBtnPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mainBtnPanel.BackColor = Color.Black;
            mainBtnPanel.Controls.Add(logoLabel);
            mainBtnPanel.Controls.Add(panel3);
            mainBtnPanel.Controls.Add(panel1);
            mainBtnPanel.Controls.Add(panel2);
            mainBtnPanel.Controls.Add(adminBtnPanel);
            mainBtnPanel.Controls.Add(ordersBtnPanel);
            mainBtnPanel.Controls.Add(controlsBtnPanel);
            mainBtnPanel.Location = new Point(3, 3);
            mainBtnPanel.Name = "mainBtnPanel";
            mainBtnPanel.Size = new Size(133, 891);
            mainBtnPanel.TabIndex = 1;
            // 
            // logoLabel
            // 
            logoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoLabel.ForeColor = Color.White;
            logoLabel.ImageAlign = ContentAlignment.MiddleRight;
            logoLabel.Location = new Point(9, 9);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(54, 25);
            logoLabel.TabIndex = 1;
            logoLabel.Text = "Logo";
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(adminDisplayBtn);
            panel3.Location = new Point(3, 439);
            panel3.Name = "panel3";
            panel3.Size = new Size(124, 36);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(96, 29);
            button3.TabIndex = 12;
            button3.Text = "Admin";
            button3.UseVisualStyleBackColor = false;
            button3.Click += titleButton_Click;
            // 
            // adminDisplayBtn
            // 
            adminDisplayBtn.AccessibleRole = AccessibleRole.PageTabList;
            adminDisplayBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adminDisplayBtn.BackColor = Color.FromArgb(64, 64, 64);
            adminDisplayBtn.ForeColor = Color.White;
            adminDisplayBtn.Location = new Point(97, 3);
            adminDisplayBtn.Name = "adminDisplayBtn";
            adminDisplayBtn.Size = new Size(24, 29);
            adminDisplayBtn.TabIndex = 10;
            adminDisplayBtn.Text = "^";
            adminDisplayBtn.UseVisualStyleBackColor = false;
            adminDisplayBtn.Click += adminDisplayBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(controlsDisplayBtn);
            panel1.Location = new Point(3, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 36);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 11;
            button1.Text = "Controls";
            button1.UseVisualStyleBackColor = false;
            button1.Click += titleButton_Click;
            // 
            // controlsDisplayBtn
            // 
            controlsDisplayBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            controlsDisplayBtn.BackColor = Color.FromArgb(64, 64, 64);
            controlsDisplayBtn.ForeColor = Color.White;
            controlsDisplayBtn.Location = new Point(97, 3);
            controlsDisplayBtn.Name = "controlsDisplayBtn";
            controlsDisplayBtn.Size = new Size(24, 29);
            controlsDisplayBtn.TabIndex = 5;
            controlsDisplayBtn.Text = "^";
            controlsDisplayBtn.UseVisualStyleBackColor = false;
            controlsDisplayBtn.Click += controlsDisplayBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(ordersDisplayBtn);
            panel2.Location = new Point(3, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(124, 39);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(96, 29);
            button2.TabIndex = 12;
            button2.Text = "Orders";
            button2.UseVisualStyleBackColor = false;
            button2.Click += titleButton_Click;
            // 
            // ordersDisplayBtn
            // 
            ordersDisplayBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ordersDisplayBtn.BackColor = Color.FromArgb(64, 64, 64);
            ordersDisplayBtn.ForeColor = Color.White;
            ordersDisplayBtn.Location = new Point(97, 3);
            ordersDisplayBtn.Name = "ordersDisplayBtn";
            ordersDisplayBtn.Size = new Size(24, 29);
            ordersDisplayBtn.TabIndex = 6;
            ordersDisplayBtn.Text = "^";
            ordersDisplayBtn.UseVisualStyleBackColor = false;
            ordersDisplayBtn.Click += ordersDisplayBtn_Click;
            // 
            // adminBtnPanel
            // 
            adminBtnPanel.Controls.Add(taskMenuBtn);
            adminBtnPanel.Controls.Add(userCtrlBtn);
            adminBtnPanel.Location = new Point(3, 481);
            adminBtnPanel.Name = "adminBtnPanel";
            adminBtnPanel.Size = new Size(124, 104);
            adminBtnPanel.TabIndex = 9;
            // 
            // taskMenuBtn
            // 
            taskMenuBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            taskMenuBtn.Location = new Point(3, 5);
            taskMenuBtn.Name = "taskMenuBtn";
            taskMenuBtn.Size = new Size(118, 45);
            taskMenuBtn.TabIndex = 8;
            taskMenuBtn.Text = "Task Menu";
            taskMenuBtn.UseVisualStyleBackColor = true;
            taskMenuBtn.Click += taskMenuBtn_Click;
            // 
            // userCtrlBtn
            // 
            userCtrlBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userCtrlBtn.Location = new Point(3, 56);
            userCtrlBtn.Name = "userCtrlBtn";
            userCtrlBtn.Size = new Size(118, 45);
            userCtrlBtn.TabIndex = 4;
            userCtrlBtn.Text = "User Control";
            userCtrlBtn.UseVisualStyleBackColor = true;
            userCtrlBtn.Click += userCtrlBtn_Click;
            // 
            // ordersBtnPanel
            // 
            ordersBtnPanel.Controls.Add(cartCtrlBtn);
            ordersBtnPanel.Controls.Add(goodsInBtn);
            ordersBtnPanel.Controls.Add(suppOrderBtn);
            ordersBtnPanel.Location = new Point(3, 283);
            ordersBtnPanel.Name = "ordersBtnPanel";
            ordersBtnPanel.Size = new Size(124, 152);
            ordersBtnPanel.TabIndex = 1;
            // 
            // cartCtrlBtn
            // 
            cartCtrlBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cartCtrlBtn.Location = new Point(3, 3);
            cartCtrlBtn.Name = "cartCtrlBtn";
            cartCtrlBtn.Size = new Size(118, 45);
            cartCtrlBtn.TabIndex = 5;
            cartCtrlBtn.Text = "Customer Order";
            cartCtrlBtn.UseVisualStyleBackColor = true;
            cartCtrlBtn.Click += cartCtrlBtn_Click;
            // 
            // goodsInBtn
            // 
            goodsInBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            goodsInBtn.Location = new Point(3, 105);
            goodsInBtn.Name = "goodsInBtn";
            goodsInBtn.Size = new Size(118, 45);
            goodsInBtn.TabIndex = 7;
            goodsInBtn.Text = "Goods Received";
            goodsInBtn.UseVisualStyleBackColor = true;
            goodsInBtn.Click += goodsInBtn_Click;
            // 
            // suppOrderBtn
            // 
            suppOrderBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            suppOrderBtn.Location = new Point(3, 54);
            suppOrderBtn.Name = "suppOrderBtn";
            suppOrderBtn.Size = new Size(118, 45);
            suppOrderBtn.TabIndex = 6;
            suppOrderBtn.Text = "Supplier Order";
            suppOrderBtn.UseVisualStyleBackColor = true;
            suppOrderBtn.Click += suppOrderBtn_Click;
            // 
            // controlsBtnPanel
            // 
            controlsBtnPanel.Controls.Add(custCtrlBtn);
            controlsBtnPanel.Controls.Add(prodCtrlBtn);
            controlsBtnPanel.Controls.Add(suppCtrlBtn);
            controlsBtnPanel.Location = new Point(3, 83);
            controlsBtnPanel.Name = "controlsBtnPanel";
            controlsBtnPanel.Size = new Size(124, 152);
            controlsBtnPanel.TabIndex = 0;
            // 
            // custCtrlBtn
            // 
            custCtrlBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            custCtrlBtn.Location = new Point(3, 3);
            custCtrlBtn.Name = "custCtrlBtn";
            custCtrlBtn.Size = new Size(118, 45);
            custCtrlBtn.TabIndex = 1;
            custCtrlBtn.Text = "Customer Control";
            custCtrlBtn.UseVisualStyleBackColor = true;
            custCtrlBtn.Click += custCtrlBtn_Click;
            // 
            // prodCtrlBtn
            // 
            prodCtrlBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            prodCtrlBtn.Location = new Point(3, 54);
            prodCtrlBtn.Name = "prodCtrlBtn";
            prodCtrlBtn.Size = new Size(118, 45);
            prodCtrlBtn.TabIndex = 2;
            prodCtrlBtn.Text = "Product Control";
            prodCtrlBtn.UseVisualStyleBackColor = true;
            prodCtrlBtn.Click += prodCtrlBtn_Click;
            // 
            // suppCtrlBtn
            // 
            suppCtrlBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            suppCtrlBtn.Location = new Point(3, 104);
            suppCtrlBtn.Name = "suppCtrlBtn";
            suppCtrlBtn.Size = new Size(118, 45);
            suppCtrlBtn.TabIndex = 3;
            suppCtrlBtn.Text = "Supplier Control";
            suppCtrlBtn.UseVisualStyleBackColor = true;
            suppCtrlBtn.Click += suppCtrlBtn_Click;
            // 
            // toolsPanel
            // 
            toolsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            toolsPanel.BackColor = Color.Black;
            toolsPanel.Controls.Add(exchangePanel);
            toolsPanel.Controls.Add(closetoolsPanel);
            toolsPanel.Controls.Add(wallpaperBtn);
            toolsPanel.Controls.Add(exchangeBtn);
            toolsPanel.Controls.Add(emailBtn);
            toolsPanel.Controls.Add(helpLabel);
            toolsPanel.Controls.Add(calculatorPanel);
            toolsPanel.Controls.Add(calculatorBtn);
            toolsPanel.Controls.Add(calendarPanel);
            toolsPanel.Controls.Add(calendarBtn);
            toolsPanel.Location = new Point(953, 46);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Size = new Size(141, 848);
            toolsPanel.TabIndex = 9;
            // 
            // exchangePanel
            // 
            exchangePanel.BackColor = Color.Transparent;
            exchangePanel.Location = new Point(3, 605);
            exchangePanel.Name = "exchangePanel";
            exchangePanel.Size = new Size(135, 107);
            exchangePanel.TabIndex = 8;
            exchangePanel.Visible = false;
            exchangePanel.Paint += exchangePanel_Paint;
            // 
            // closetoolsPanel
            // 
            closetoolsPanel.AutoSize = true;
            closetoolsPanel.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            closetoolsPanel.ForeColor = Color.White;
            closetoolsPanel.Location = new Point(7, 9);
            closetoolsPanel.Name = "closetoolsPanel";
            closetoolsPanel.Size = new Size(19, 22);
            closetoolsPanel.TabIndex = 8;
            closetoolsPanel.Text = ">";
            closetoolsPanel.Click += closetoolsPanel_Click;
            // 
            // wallpaperBtn
            // 
            wallpaperBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            wallpaperBtn.Location = new Point(3, 196);
            wallpaperBtn.Name = "wallpaperBtn";
            wallpaperBtn.Size = new Size(134, 28);
            wallpaperBtn.TabIndex = 0;
            wallpaperBtn.Text = "wallpaper";
            wallpaperBtn.UseVisualStyleBackColor = true;
            wallpaperBtn.Click += wallpaperBtn_Click;
            // 
            // exchangeBtn
            // 
            exchangeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exchangeBtn.Location = new Point(3, 161);
            exchangeBtn.Name = "exchangeBtn";
            exchangeBtn.Size = new Size(134, 28);
            exchangeBtn.TabIndex = 7;
            exchangeBtn.Text = "Currency Exchange";
            exchangeBtn.UseVisualStyleBackColor = true;
            exchangeBtn.Click += exchangeBtn_Click;
            // 
            // emailBtn
            // 
            emailBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailBtn.Location = new Point(3, 126);
            emailBtn.Name = "emailBtn";
            emailBtn.Size = new Size(134, 28);
            emailBtn.TabIndex = 6;
            emailBtn.Text = "Email";
            emailBtn.UseVisualStyleBackColor = true;
            emailBtn.Click += emailBtn_Click;
            // 
            // helpLabel
            // 
            helpLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            helpLabel.AutoSize = true;
            helpLabel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helpLabel.ForeColor = Color.White;
            helpLabel.Location = new Point(7, 34);
            helpLabel.Name = "helpLabel";
            helpLabel.Size = new Size(113, 16);
            helpLabel.TabIndex = 5;
            helpLabel.Text = "Help and Features";
            helpLabel.Click += helpLabel_Click;
            // 
            // calculatorPanel
            // 
            calculatorPanel.BackColor = Color.Transparent;
            calculatorPanel.Location = new Point(3, 453);
            calculatorPanel.Name = "calculatorPanel";
            calculatorPanel.Size = new Size(135, 258);
            calculatorPanel.TabIndex = 4;
            calculatorPanel.Visible = false;
            calculatorPanel.Paint += calculatorPanel_Paint;
            // 
            // calculatorBtn
            // 
            calculatorBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            calculatorBtn.Location = new Point(3, 91);
            calculatorBtn.Name = "calculatorBtn";
            calculatorBtn.Size = new Size(133, 28);
            calculatorBtn.TabIndex = 3;
            calculatorBtn.Text = "Calculator";
            calculatorBtn.UseVisualStyleBackColor = true;
            calculatorBtn.Click += calculatorBtn_Click;
            // 
            // calendarPanel
            // 
            calendarPanel.BackColor = Color.White;
            calendarPanel.Controls.Add(openCalendar);
            calendarPanel.Location = new Point(3, 407);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.Size = new Size(135, 170);
            calendarPanel.TabIndex = 2;
            calendarPanel.Visible = false;
            calendarPanel.Paint += calendarPanel_Paint;
            // 
            // openCalendar
            // 
            openCalendar.AutoSize = true;
            openCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            openCalendar.Location = new Point(4, 142);
            openCalendar.Name = "openCalendar";
            openCalendar.Size = new Size(86, 15);
            openCalendar.TabIndex = 0;
            openCalendar.Text = "Open Calendar";
            openCalendar.Click += openCalendar_Click;
            // 
            // calendarBtn
            // 
            calendarBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            calendarBtn.Location = new Point(3, 56);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Size = new Size(133, 28);
            calendarBtn.TabIndex = 1;
            calendarBtn.Text = "Calendar";
            calendarBtn.UseVisualStyleBackColor = true;
            calendarBtn.Click += calendarBtn_Click;
            // 
            // MainProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPanel);
            Name = "MainProgram";
            Size = new Size(1100, 900);
            mainPanel.ResumeLayout(false);
            capanel1.ResumeLayout(false);
            capanel1.PerformLayout();
            smalltoolsPanel.ResumeLayout(false);
            smalltoolsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emailP).EndInit();
            ((System.ComponentModel.ISupportInitialize)calculatorP).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarP).EndInit();
            fucPanel.ResumeLayout(false);
            fucPanel.PerformLayout();
            homePanelContainer.ResumeLayout(false);
            mainBtnPanel.ResumeLayout(false);
            mainBtnPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            adminBtnPanel.ResumeLayout(false);
            ordersBtnPanel.ResumeLayout(false);
            controlsBtnPanel.ResumeLayout(false);
            toolsPanel.ResumeLayout(false);
            toolsPanel.PerformLayout();
            calendarPanel.ResumeLayout(false);
            calendarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel mainBtnPanel;
        private Panel panel3;
        private Button button3;
        private Button adminDisplayBtn;
        private Panel panel1;
        private Button button1;
        private Button controlsDisplayBtn;
        private Panel panel2;
        private Button button2;
        private Button ordersDisplayBtn;
        private Panel adminBtnPanel;
        private Button taskMenuBtn;
        private Button userCtrlBtn;
        private Panel ordersBtnPanel;
        private Button cartCtrlBtn;
        private Button goodsInBtn;
        private Button suppOrderBtn;
        private Panel controlsBtnPanel;
        private Button custCtrlBtn;
        private Button prodCtrlBtn;
        private Button suppCtrlBtn;
        private Panel homePanelContainer;
        private Panel homePanel;
        private Panel fucPanel;
        private Label timeLabel;
        private ComboBox exchangeForm;
        private Button lockBtn;
        private Button signBtn;
        private Panel smalltoolsPanel;
        private PictureBox emailP;
        private PictureBox calculatorP;
        private PictureBox calendarP;
        private Label opentoolsPanel;
        private Panel toolsPanel;
        private Panel exchangePanel;
        private Label closetoolsPanel;
        private Button wallpaperBtn;
        private Button exchangeBtn;
        private Button emailBtn;
        private Label helpLabel;
        private Panel calculatorPanel;
        private Button calculatorBtn;
        private Panel calendarPanel;
        private Label openCalendar;
        private Button calendarBtn;
        private Panel capanel1;
        private Panel capanel2;
        private Label caCloseL;
        private Label caLabel;
        private Label logoLabel;
    }
}
