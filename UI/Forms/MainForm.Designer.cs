namespace UI.Forms
{
    partial class MainForm
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
            mainPanel = new Panel();
            titlePanel = new Panel();
            deleBtn = new Button();
            setBtn = new Button();
            newform = new Button();
            newtab = new Button();
            tabControl = new TabControl();
            homePage = new TabPage();
            mainPanel.SuspendLayout();
            titlePanel.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(64, 64, 64);
            mainPanel.Controls.Add(titlePanel);
            mainPanel.Controls.Add(tabControl);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1108, 938);
            mainPanel.TabIndex = 0;
            // 
            // titlePanel
            // 
            titlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titlePanel.BackColor = Color.Black;
            titlePanel.Controls.Add(deleBtn);
            titlePanel.Controls.Add(setBtn);
            titlePanel.Controls.Add(newform);
            titlePanel.Controls.Add(newtab);
            titlePanel.Location = new Point(86, 3);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(1019, 25);
            titlePanel.TabIndex = 0;
            // 
            // deleBtn
            // 
            deleBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            deleBtn.Location = new Point(55, 3);
            deleBtn.Name = "deleBtn";
            deleBtn.Size = new Size(20, 20);
            deleBtn.TabIndex = 3;
            deleBtn.Text = "D";
            deleBtn.UseVisualStyleBackColor = true;
            deleBtn.Visible = false;
            deleBtn.Click += deleBtn_Click;
            // 
            // setBtn
            // 
            setBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            setBtn.Location = new Point(995, 3);
            setBtn.Name = "setBtn";
            setBtn.Size = new Size(20, 20);
            setBtn.TabIndex = 2;
            setBtn.Text = "S";
            setBtn.UseVisualStyleBackColor = true;
            setBtn.Click += setBtn_Click;
            // 
            // newform
            // 
            newform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            newform.Location = new Point(29, 3);
            newform.Name = "newform";
            newform.Size = new Size(20, 20);
            newform.TabIndex = 1;
            newform.Text = "F";
            newform.UseVisualStyleBackColor = true;
            newform.Click += newform_Click;
            // 
            // newtab
            // 
            newtab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            newtab.Location = new Point(3, 3);
            newtab.Name = "newtab";
            newtab.Size = new Size(20, 20);
            newtab.TabIndex = 0;
            newtab.Text = "T";
            newtab.UseVisualStyleBackColor = true;
            newtab.Click += newtab_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(homePage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ItemSize = new Size(200, 30);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1108, 938);
            tabControl.TabIndex = 1;
            // 
            // homePage
            // 
            homePage.BackColor = Color.FromArgb(64, 64, 64);
            homePage.Location = new Point(4, 34);
            homePage.Name = "homePage";
            homePage.Padding = new Padding(3);
            homePage.Size = new Size(1100, 900);
            homePage.TabIndex = 0;
            homePage.Text = "Home Page";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 938);
            Controls.Add(mainPanel);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            mainPanel.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel titlePanel;
        private Button setBtn;
        private Button newform;
        private Button newtab;
        private TabControl tabControl;
        private TabPage homePage;
        private Button deleBtn;
    }
}