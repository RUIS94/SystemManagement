namespace UI.Controls
{
    partial class WallPaperForm
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
            changeselection = new ComboBox();
            label2 = new Label();
            startselection = new ComboBox();
            label1 = new Label();
            imageContainer = new FlowLayoutPanel();
            okBtn = new Button();
            homePanel.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(okBtn);
            homePanel.Controls.Add(changeselection);
            homePanel.Controls.Add(label2);
            homePanel.Controls.Add(startselection);
            homePanel.Controls.Add(label1);
            homePanel.Controls.Add(imageContainer);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(584, 409);
            homePanel.TabIndex = 0;
            // 
            // changeselection
            // 
            changeselection.FormattingEnabled = true;
            changeselection.Location = new Point(264, 10);
            changeselection.Name = "changeselection";
            changeselection.Size = new Size(105, 25);
            changeselection.TabIndex = 9;
            changeselection.SelectedIndexChanged += changeselection_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 14);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 8;
            label2.Text = "Change:";
            // 
            // startselection
            // 
            startselection.FormattingEnabled = true;
            startselection.Location = new Point(67, 10);
            startselection.Name = "startselection";
            startselection.Size = new Size(105, 25);
            startselection.TabIndex = 7;
            startselection.SelectedIndexChanged += startselection_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 6;
            label1.Text = "StartUp:";
            // 
            // imageContainer
            // 
            imageContainer.AutoScroll = true;
            imageContainer.Location = new Point(12, 43);
            imageContainer.Name = "imageContainer";
            imageContainer.Size = new Size(560, 356);
            imageContainer.TabIndex = 5;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(497, 8);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 10;
            okBtn.Text = "Set";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // WallPaperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 409);
            Controls.Add(homePanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WallPaperForm";
            Text = "WallPaperForm";
            Load += WallPaperForm_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private ComboBox changeselection;
        private Label label2;
        private ComboBox startselection;
        private Label label1;
        private FlowLayoutPanel imageContainer;
        private Button okBtn;
    }
}