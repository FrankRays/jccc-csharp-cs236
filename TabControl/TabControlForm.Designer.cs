namespace Lab10
{
    partial class TabControlForm
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
            this.components = new System.ComponentModel.Container();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.colorTabPage = new System.Windows.Forms.TabPage();
            this.sizeTabPage = new System.Windows.Forms.TabPage();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTabPage = new System.Windows.Forms.TabPage();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.purpleRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.cheezburgerRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.customRadioButton = new System.Windows.Forms.RadioButton();
            this.customMessageTextBox = new System.Windows.Forms.TextBox();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTabControl.SuspendLayout();
            this.colorTabPage.SuspendLayout();
            this.sizeTabPage.SuspendLayout();
            this.messageTabPage.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.colorTabPage);
            this.mainTabControl.Controls.Add(this.sizeTabPage);
            this.mainTabControl.Controls.Add(this.messageTabPage);
            this.mainTabControl.Controls.Add(this.aboutTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(376, 188);
            this.mainTabControl.TabIndex = 0;
            // 
            // colorTabPage
            // 
            this.colorTabPage.Controls.Add(this.purpleRadioButton);
            this.colorTabPage.Controls.Add(this.redRadioButton);
            this.colorTabPage.Controls.Add(this.blackRadioButton);
            this.colorTabPage.Location = new System.Drawing.Point(4, 22);
            this.colorTabPage.Name = "colorTabPage";
            this.colorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.colorTabPage.Size = new System.Drawing.Size(368, 162);
            this.colorTabPage.TabIndex = 0;
            this.colorTabPage.Text = "Color";
            this.colorTabPage.UseVisualStyleBackColor = true;
            // 
            // sizeTabPage
            // 
            this.sizeTabPage.Controls.Add(this.largeRadioButton);
            this.sizeTabPage.Controls.Add(this.mediumRadioButton);
            this.sizeTabPage.Controls.Add(this.smallRadioButton);
            this.sizeTabPage.Location = new System.Drawing.Point(4, 22);
            this.sizeTabPage.Name = "sizeTabPage";
            this.sizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sizeTabPage.Size = new System.Drawing.Size(368, 162);
            this.sizeTabPage.TabIndex = 1;
            this.sizeTabPage.Text = "Size";
            this.sizeTabPage.UseVisualStyleBackColor = true;
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(12, 203);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(376, 50);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "I can has cheezburger?";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageTabPage
            // 
            this.messageTabPage.Controls.Add(this.customMessageTextBox);
            this.messageTabPage.Controls.Add(this.customRadioButton);
            this.messageTabPage.Controls.Add(this.radioButton1);
            this.messageTabPage.Controls.Add(this.cheezburgerRadioButton);
            this.messageTabPage.Location = new System.Drawing.Point(4, 22);
            this.messageTabPage.Name = "messageTabPage";
            this.messageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.messageTabPage.Size = new System.Drawing.Size(368, 162);
            this.messageTabPage.TabIndex = 2;
            this.messageTabPage.Text = "Message";
            this.messageTabPage.UseVisualStyleBackColor = true;
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Controls.Add(this.aboutLabel);
            this.aboutTabPage.Location = new System.Drawing.Point(4, 22);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTabPage.Size = new System.Drawing.Size(368, 162);
            this.aboutTabPage.TabIndex = 3;
            this.aboutTabPage.Text = "About";
            this.aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Checked = true;
            this.blackRadioButton.Location = new System.Drawing.Point(157, 50);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.blackRadioButton.TabIndex = 0;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(157, 73);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton.TabIndex = 1;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // purpleRadioButton
            // 
            this.purpleRadioButton.AutoSize = true;
            this.purpleRadioButton.Location = new System.Drawing.Point(157, 96);
            this.purpleRadioButton.Name = "purpleRadioButton";
            this.purpleRadioButton.Size = new System.Drawing.Size(55, 17);
            this.purpleRadioButton.TabIndex = 2;
            this.purpleRadioButton.Text = "Purple";
            this.purpleRadioButton.UseVisualStyleBackColor = true;
            this.purpleRadioButton.CheckedChanged += new System.EventHandler(this.purpleRadioButton_CheckedChanged);
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Checked = true;
            this.smallRadioButton.Location = new System.Drawing.Point(161, 50);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(46, 17);
            this.smallRadioButton.TabIndex = 0;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "12pt";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            this.smallRadioButton.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(161, 73);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(46, 17);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.Text = "16pt";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.mediumRadioButton_CheckedChanged);
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(161, 96);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(46, 17);
            this.largeRadioButton.TabIndex = 2;
            this.largeRadioButton.Text = "20pt";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            this.largeRadioButton.CheckedChanged += new System.EventHandler(this.largeRadioButton_CheckedChanged);
            // 
            // cheezburgerRadioButton
            // 
            this.cheezburgerRadioButton.AutoSize = true;
            this.cheezburgerRadioButton.Checked = true;
            this.cheezburgerRadioButton.Location = new System.Drawing.Point(116, 37);
            this.cheezburgerRadioButton.Name = "cheezburgerRadioButton";
            this.cheezburgerRadioButton.Size = new System.Drawing.Size(137, 17);
            this.cheezburgerRadioButton.TabIndex = 0;
            this.cheezburgerRadioButton.TabStop = true;
            this.cheezburgerRadioButton.Text = "I can has cheezburger?";
            this.cheezburgerRadioButton.UseVisualStyleBackColor = true;
            this.cheezburgerRadioButton.CheckedChanged += new System.EventHandler(this.cheezburgerRadioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(116, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "kthxbai";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // customRadioButton
            // 
            this.customRadioButton.AutoSize = true;
            this.customRadioButton.Location = new System.Drawing.Point(116, 83);
            this.customRadioButton.Name = "customRadioButton";
            this.customRadioButton.Size = new System.Drawing.Size(63, 17);
            this.customRadioButton.TabIndex = 2;
            this.customRadioButton.Text = "Custom:";
            this.customRadioButton.UseVisualStyleBackColor = true;
            this.customRadioButton.CheckedChanged += new System.EventHandler(this.customRadioButton_CheckedChanged);
            // 
            // customMessageTextBox
            // 
            this.customMessageTextBox.Enabled = false;
            this.customMessageTextBox.Location = new System.Drawing.Point(116, 106);
            this.customMessageTextBox.MaxLength = 16;
            this.customMessageTextBox.Name = "customMessageTextBox";
            this.customMessageTextBox.Size = new System.Drawing.Size(137, 20);
            this.customMessageTextBox.TabIndex = 3;
            this.customMessageTextBox.TextChanged += new System.EventHandler(this.customMessageTextBox_TextChanged);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(151, 71);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(66, 20);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Oh hai!";
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 30;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // TabControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 262);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TabControlForm";
            this.Text = "Using Tabs";
            this.Load += new System.EventHandler(this.TabControlForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.colorTabPage.ResumeLayout(false);
            this.colorTabPage.PerformLayout();
            this.sizeTabPage.ResumeLayout(false);
            this.sizeTabPage.PerformLayout();
            this.messageTabPage.ResumeLayout(false);
            this.messageTabPage.PerformLayout();
            this.aboutTabPage.ResumeLayout(false);
            this.aboutTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage colorTabPage;
        private System.Windows.Forms.TabPage sizeTabPage;
        private System.Windows.Forms.TabPage messageTabPage;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.RadioButton purpleRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton cheezburgerRadioButton;
        private System.Windows.Forms.TextBox customMessageTextBox;
        private System.Windows.Forms.RadioButton customRadioButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Timer animationTimer;
    }
}

