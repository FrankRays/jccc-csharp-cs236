namespace DateTimePickerTest
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
            this.dropOffDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryMethodComboBox = new System.Windows.Forms.ComboBox();
            this.dropOffLabel = new System.Windows.Forms.Label();
            this.deliveryMethodLabel = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dropOffDateTimePicker
            // 
            this.dropOffDateTimePicker.Location = new System.Drawing.Point(12, 28);
            this.dropOffDateTimePicker.Name = "dropOffDateTimePicker";
            this.dropOffDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dropOffDateTimePicker.TabIndex = 0;
            this.dropOffDateTimePicker.ValueChanged += new System.EventHandler(this.dropOffDateTimePicker_ValueChanged);
            // 
            // deliveryMethodComboBox
            // 
            this.deliveryMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryMethodComboBox.FormattingEnabled = true;
            this.deliveryMethodComboBox.Items.AddRange(new object[] {
            "Economy",
            "Standard",
            "Two-Day",
            "Overnight"});
            this.deliveryMethodComboBox.Location = new System.Drawing.Point(218, 27);
            this.deliveryMethodComboBox.Name = "deliveryMethodComboBox";
            this.deliveryMethodComboBox.Size = new System.Drawing.Size(121, 21);
            this.deliveryMethodComboBox.TabIndex = 1;
            this.deliveryMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.deliveryMethodComboBox_SelectedIndexChanged);
            // 
            // dropOffLabel
            // 
            this.dropOffLabel.AutoSize = true;
            this.dropOffLabel.Location = new System.Drawing.Point(13, 9);
            this.dropOffLabel.Name = "dropOffLabel";
            this.dropOffLabel.Size = new System.Drawing.Size(74, 13);
            this.dropOffLabel.TabIndex = 2;
            this.dropOffLabel.Text = "Drop-off Date:";
            // 
            // deliveryMethodLabel
            // 
            this.deliveryMethodLabel.AutoSize = true;
            this.deliveryMethodLabel.Location = new System.Drawing.Point(215, 9);
            this.deliveryMethodLabel.Name = "deliveryMethodLabel";
            this.deliveryMethodLabel.Size = new System.Drawing.Size(87, 13);
            this.deliveryMethodLabel.TabIndex = 3;
            this.deliveryMethodLabel.Text = "Delivery Method:";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(12, 54);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(326, 20);
            this.infoTextBox.TabIndex = 4;
            this.infoTextBox.Text = "Please input data.";
            this.infoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 86);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.deliveryMethodLabel);
            this.Controls.Add(this.dropOffLabel);
            this.Controls.Add(this.deliveryMethodComboBox);
            this.Controls.Add(this.dropOffDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Delivery Estimater";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dropOffDateTimePicker;
        private System.Windows.Forms.ComboBox deliveryMethodComboBox;
        private System.Windows.Forms.Label dropOffLabel;
        private System.Windows.Forms.Label deliveryMethodLabel;
        private System.Windows.Forms.TextBox infoTextBox;
    }
}

