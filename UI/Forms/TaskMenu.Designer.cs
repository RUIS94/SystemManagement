namespace UI.Forms
{
    partial class TaskMenu
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
            taskTabControl = new TabControl();
            controlTabPage = new TabPage();
            adminTabPage = new TabPage();
            exportFileBtn = new Button();
            logViewBtn = new Button();
            dbBackupBtn = new Button();
            homePanel.SuspendLayout();
            taskTabControl.SuspendLayout();
            adminTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(taskTabControl);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(784, 461);
            homePanel.TabIndex = 0;
            // 
            // taskTabControl
            // 
            taskTabControl.Controls.Add(controlTabPage);
            taskTabControl.Controls.Add(adminTabPage);
            taskTabControl.Location = new Point(12, 12);
            taskTabControl.Name = "taskTabControl";
            taskTabControl.SelectedIndex = 0;
            taskTabControl.Size = new Size(760, 437);
            taskTabControl.TabIndex = 0;
            // 
            // controlTabPage
            // 
            controlTabPage.Location = new Point(4, 24);
            controlTabPage.Name = "controlTabPage";
            controlTabPage.Padding = new Padding(3);
            controlTabPage.Size = new Size(752, 409);
            controlTabPage.TabIndex = 0;
            controlTabPage.Text = "Control";
            controlTabPage.UseVisualStyleBackColor = true;
            // 
            // adminTabPage
            // 
            adminTabPage.Controls.Add(exportFileBtn);
            adminTabPage.Controls.Add(logViewBtn);
            adminTabPage.Controls.Add(dbBackupBtn);
            adminTabPage.Location = new Point(4, 24);
            adminTabPage.Name = "adminTabPage";
            adminTabPage.Padding = new Padding(3);
            adminTabPage.Size = new Size(752, 409);
            adminTabPage.TabIndex = 1;
            adminTabPage.Text = "Admin";
            adminTabPage.UseVisualStyleBackColor = true;
            // 
            // exportFileBtn
            // 
            exportFileBtn.Location = new Point(300, 39);
            exportFileBtn.Name = "exportFileBtn";
            exportFileBtn.Size = new Size(68, 70);
            exportFileBtn.TabIndex = 2;
            exportFileBtn.Text = "Export Files";
            exportFileBtn.UseVisualStyleBackColor = true;
            exportFileBtn.Click += exportFileBtn_Click;
            // 
            // logViewBtn
            // 
            logViewBtn.Location = new Point(164, 39);
            logViewBtn.Name = "logViewBtn";
            logViewBtn.Size = new Size(68, 70);
            logViewBtn.TabIndex = 1;
            logViewBtn.Text = "View Logfile";
            logViewBtn.UseVisualStyleBackColor = true;
            logViewBtn.Click += logViewBtn_Click;
            // 
            // dbBackupBtn
            // 
            dbBackupBtn.Location = new Point(34, 39);
            dbBackupBtn.Name = "dbBackupBtn";
            dbBackupBtn.Size = new Size(68, 70);
            dbBackupBtn.TabIndex = 0;
            dbBackupBtn.Text = "Database Backup";
            dbBackupBtn.UseVisualStyleBackColor = true;
            dbBackupBtn.Click += dbBackupBtn_Click;
            // 
            // TaskMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(homePanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TaskMenu";
            Text = "TaskMenu";
            homePanel.ResumeLayout(false);
            taskTabControl.ResumeLayout(false);
            adminTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private TabControl taskTabControl;
        private TabPage controlTabPage;
        private TabPage adminTabPage;
        private Button exportFileBtn;
        private Button logViewBtn;
        private Button dbBackupBtn;
    }
}