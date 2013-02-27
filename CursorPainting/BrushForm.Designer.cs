namespace CursorPainting
{
    partial class BrushForm
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
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.redColorRadioButton = new System.Windows.Forms.RadioButton();
            this.purpleColorRadioButton = new System.Windows.Forms.RadioButton();
            this.blackColorRadioButton = new System.Windows.Forms.RadioButton();
            this.blueColorRadioButton = new System.Windows.Forms.RadioButton();
            this.greenColorRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.customSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.customSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.largeSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.smallSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.settingsButton = new System.Windows.Forms.Button();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.colorGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customSizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.redColorRadioButton);
            this.colorGroupBox.Controls.Add(this.purpleColorRadioButton);
            this.colorGroupBox.Controls.Add(this.blackColorRadioButton);
            this.colorGroupBox.Controls.Add(this.blueColorRadioButton);
            this.colorGroupBox.Controls.Add(this.greenColorRadioButton);
            this.colorGroupBox.Location = new System.Drawing.Point(12, 12);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(70, 137);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            this.myToolTip.SetToolTip(this.colorGroupBox, "Changes the color of your brush!");
            // 
            // redColorRadioButton
            // 
            this.redColorRadioButton.AutoSize = true;
            this.redColorRadioButton.ForeColor = System.Drawing.Color.Red;
            this.redColorRadioButton.Location = new System.Drawing.Point(6, 42);
            this.redColorRadioButton.Name = "redColorRadioButton";
            this.redColorRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redColorRadioButton.TabIndex = 11;
            this.redColorRadioButton.Text = "Red";
            this.redColorRadioButton.UseVisualStyleBackColor = true;
            this.redColorRadioButton.CheckedChanged += new System.EventHandler(this.redColorRadioButton_CheckedChanged);
            // 
            // purpleColorRadioButton
            // 
            this.purpleColorRadioButton.AutoSize = true;
            this.purpleColorRadioButton.Checked = true;
            this.purpleColorRadioButton.ForeColor = System.Drawing.Color.Purple;
            this.purpleColorRadioButton.Location = new System.Drawing.Point(6, 19);
            this.purpleColorRadioButton.Name = "purpleColorRadioButton";
            this.purpleColorRadioButton.Size = new System.Drawing.Size(55, 17);
            this.purpleColorRadioButton.TabIndex = 10;
            this.purpleColorRadioButton.TabStop = true;
            this.purpleColorRadioButton.Text = "Purple";
            this.purpleColorRadioButton.UseVisualStyleBackColor = true;
            this.purpleColorRadioButton.CheckedChanged += new System.EventHandler(this.purpleColorRadioButton_CheckedChanged);
            // 
            // blackColorRadioButton
            // 
            this.blackColorRadioButton.AutoSize = true;
            this.blackColorRadioButton.ForeColor = System.Drawing.Color.Black;
            this.blackColorRadioButton.Location = new System.Drawing.Point(6, 111);
            this.blackColorRadioButton.Name = "blackColorRadioButton";
            this.blackColorRadioButton.Size = new System.Drawing.Size(52, 17);
            this.blackColorRadioButton.TabIndex = 9;
            this.blackColorRadioButton.Text = "Black";
            this.blackColorRadioButton.UseVisualStyleBackColor = true;
            this.blackColorRadioButton.CheckedChanged += new System.EventHandler(this.blackColorRadioButton_CheckedChanged);
            // 
            // blueColorRadioButton
            // 
            this.blueColorRadioButton.AutoSize = true;
            this.blueColorRadioButton.ForeColor = System.Drawing.Color.Blue;
            this.blueColorRadioButton.Location = new System.Drawing.Point(6, 88);
            this.blueColorRadioButton.Name = "blueColorRadioButton";
            this.blueColorRadioButton.Size = new System.Drawing.Size(46, 17);
            this.blueColorRadioButton.TabIndex = 8;
            this.blueColorRadioButton.Text = "Blue";
            this.blueColorRadioButton.UseVisualStyleBackColor = true;
            this.blueColorRadioButton.CheckedChanged += new System.EventHandler(this.blueColorRadioButton_CheckedChanged);
            // 
            // greenColorRadioButton
            // 
            this.greenColorRadioButton.AutoSize = true;
            this.greenColorRadioButton.ForeColor = System.Drawing.Color.Green;
            this.greenColorRadioButton.Location = new System.Drawing.Point(6, 65);
            this.greenColorRadioButton.Name = "greenColorRadioButton";
            this.greenColorRadioButton.Size = new System.Drawing.Size(54, 17);
            this.greenColorRadioButton.TabIndex = 7;
            this.greenColorRadioButton.Text = "Green";
            this.greenColorRadioButton.UseVisualStyleBackColor = true;
            this.greenColorRadioButton.CheckedChanged += new System.EventHandler(this.greenColorRadioButton_CheckedChanged);
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.customSizeNumericUpDown);
            this.sizeGroupBox.Controls.Add(this.customSizeRadioButton);
            this.sizeGroupBox.Controls.Add(this.largeSizeRadioButton);
            this.sizeGroupBox.Controls.Add(this.mediumSizeRadioButton);
            this.sizeGroupBox.Controls.Add(this.smallSizeRadioButton);
            this.sizeGroupBox.Location = new System.Drawing.Point(12, 155);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(70, 141);
            this.sizeGroupBox.TabIndex = 1;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            this.myToolTip.SetToolTip(this.sizeGroupBox, "Changes the size of your brush!");
            // 
            // customSizeNumericUpDown
            // 
            this.customSizeNumericUpDown.Enabled = false;
            this.customSizeNumericUpDown.Location = new System.Drawing.Point(5, 111);
            this.customSizeNumericUpDown.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.customSizeNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.customSizeNumericUpDown.Name = "customSizeNumericUpDown";
            this.customSizeNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.customSizeNumericUpDown.TabIndex = 4;
            this.customSizeNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.customSizeNumericUpDown.ValueChanged += new System.EventHandler(this.customSizeNumericUpDown_ValueChanged);
            // 
            // customSizeRadioButton
            // 
            this.customSizeRadioButton.AutoSize = true;
            this.customSizeRadioButton.Location = new System.Drawing.Point(6, 88);
            this.customSizeRadioButton.Name = "customSizeRadioButton";
            this.customSizeRadioButton.Size = new System.Drawing.Size(60, 17);
            this.customSizeRadioButton.TabIndex = 3;
            this.customSizeRadioButton.TabStop = true;
            this.customSizeRadioButton.Text = "Custom";
            this.customSizeRadioButton.UseVisualStyleBackColor = true;
            this.customSizeRadioButton.CheckedChanged += new System.EventHandler(this.customSizeRadioButton_CheckedChanged);
            // 
            // largeSizeRadioButton
            // 
            this.largeSizeRadioButton.AutoSize = true;
            this.largeSizeRadioButton.Location = new System.Drawing.Point(6, 65);
            this.largeSizeRadioButton.Name = "largeSizeRadioButton";
            this.largeSizeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.largeSizeRadioButton.TabIndex = 2;
            this.largeSizeRadioButton.TabStop = true;
            this.largeSizeRadioButton.Text = "Large";
            this.largeSizeRadioButton.UseVisualStyleBackColor = true;
            this.largeSizeRadioButton.CheckedChanged += new System.EventHandler(this.largeSizeRadioButton_CheckedChanged);
            // 
            // mediumSizeRadioButton
            // 
            this.mediumSizeRadioButton.AutoSize = true;
            this.mediumSizeRadioButton.Location = new System.Drawing.Point(6, 42);
            this.mediumSizeRadioButton.Name = "mediumSizeRadioButton";
            this.mediumSizeRadioButton.Size = new System.Drawing.Size(62, 17);
            this.mediumSizeRadioButton.TabIndex = 1;
            this.mediumSizeRadioButton.TabStop = true;
            this.mediumSizeRadioButton.Text = "Medium";
            this.mediumSizeRadioButton.UseVisualStyleBackColor = true;
            this.mediumSizeRadioButton.CheckedChanged += new System.EventHandler(this.mediumSizeRadioButton_CheckedChanged);
            // 
            // smallSizeRadioButton
            // 
            this.smallSizeRadioButton.AutoSize = true;
            this.smallSizeRadioButton.Checked = true;
            this.smallSizeRadioButton.Location = new System.Drawing.Point(6, 19);
            this.smallSizeRadioButton.Name = "smallSizeRadioButton";
            this.smallSizeRadioButton.Size = new System.Drawing.Size(50, 17);
            this.smallSizeRadioButton.TabIndex = 0;
            this.smallSizeRadioButton.TabStop = true;
            this.smallSizeRadioButton.Text = "Small";
            this.smallSizeRadioButton.UseVisualStyleBackColor = true;
            this.smallSizeRadioButton.CheckedChanged += new System.EventHandler(this.smallSizeRadioButton_CheckedChanged);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(12, 302);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(70, 29);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Settings";
            this.myToolTip.SetToolTip(this.settingsButton, "Click here to save or clear your canvas.");
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // BrushForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(94, 343);
            this.ControlBox = false;
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.colorGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrushForm";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Brush Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrushForm_FormClosing);
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customSizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.RadioButton purpleColorRadioButton;
        private System.Windows.Forms.RadioButton blackColorRadioButton;
        private System.Windows.Forms.RadioButton blueColorRadioButton;
        private System.Windows.Forms.RadioButton greenColorRadioButton;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.RadioButton mediumSizeRadioButton;
        private System.Windows.Forms.RadioButton smallSizeRadioButton;
        private System.Windows.Forms.NumericUpDown customSizeNumericUpDown;
        private System.Windows.Forms.RadioButton customSizeRadioButton;
        private System.Windows.Forms.RadioButton largeSizeRadioButton;
        private System.Windows.Forms.RadioButton redColorRadioButton;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Button settingsButton;


    }
}