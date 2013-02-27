namespace CursorPainting
{
    partial class SettingsForm
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
            this.actionInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.versionInfoLabel = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.checkPictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearCanvasButton = new System.Windows.Forms.Button();
            this.checkPictureBox2 = new System.Windows.Forms.PictureBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.actionInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // actionInfoGroupBox
            // 
            this.actionInfoGroupBox.Controls.Add(this.actionLabel);
            this.actionInfoGroupBox.Location = new System.Drawing.Point(12, 92);
            this.actionInfoGroupBox.Name = "actionInfoGroupBox";
            this.actionInfoGroupBox.Size = new System.Drawing.Size(366, 124);
            this.actionInfoGroupBox.TabIndex = 2;
            this.actionInfoGroupBox.TabStop = false;
            this.actionInfoGroupBox.Text = "Action Information";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(144, 222);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(114, 34);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "O&kay";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(264, 222);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 34);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Can&cel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // versionInfoLabel
            // 
            this.versionInfoLabel.AutoSize = true;
            this.versionInfoLabel.Enabled = false;
            this.versionInfoLabel.Location = new System.Drawing.Point(12, 219);
            this.versionInfoLabel.Name = "versionInfoLabel";
            this.versionInfoLabel.Size = new System.Drawing.Size(102, 26);
            this.versionInfoLabel.TabIndex = 5;
            this.versionInfoLabel.Text = "Version Info\r\n(shown during exec)";
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionLabel.Location = new System.Drawing.Point(7, 20);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(114, 15);
            this.actionLabel.TabIndex = 0;
            this.actionLabel.Text = "Select an action!";
            // 
            // checkPictureBox1
            // 
            this.checkPictureBox1.Location = new System.Drawing.Point(258, 12);
            this.checkPictureBox1.Name = "checkPictureBox1";
            this.checkPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.checkPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.checkPictureBox1.TabIndex = 6;
            this.checkPictureBox1.TabStop = false;
            // 
            // clearCanvasButton
            // 
            this.clearCanvasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCanvasButton.Image = global::CursorPainting.Properties.Resources._1447_eraser_32x32;
            this.clearCanvasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearCanvasButton.Location = new System.Drawing.Point(138, 12);
            this.clearCanvasButton.Name = "clearCanvasButton";
            this.clearCanvasButton.Size = new System.Drawing.Size(114, 34);
            this.clearCanvasButton.TabIndex = 0;
            this.clearCanvasButton.Text = "Clear Canvas";
            this.clearCanvasButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearCanvasButton.UseVisualStyleBackColor = true;
            this.clearCanvasButton.Click += new System.EventHandler(this.clearCanvasButton_Click);
            // 
            // checkPictureBox2
            // 
            this.checkPictureBox2.Location = new System.Drawing.Point(258, 54);
            this.checkPictureBox2.Name = "checkPictureBox2";
            this.checkPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.checkPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.checkPictureBox2.TabIndex = 7;
            this.checkPictureBox2.TabStop = false;
            // 
            // saveImageButton
            // 
            this.saveImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveImageButton.Image = global::CursorPainting.Properties.Resources.base_floppydisk_32;
            this.saveImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveImageButton.Location = new System.Drawing.Point(138, 52);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(114, 34);
            this.saveImageButton.TabIndex = 1;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(390, 268);
            this.Controls.Add(this.checkPictureBox2);
            this.Controls.Add(this.checkPictureBox1);
            this.Controls.Add(this.versionInfoLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.actionInfoGroupBox);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.clearCanvasButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Josho-Paint Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.actionInfoGroupBox.ResumeLayout(false);
            this.actionInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearCanvasButton;
        private System.Windows.Forms.GroupBox actionInfoGroupBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label versionInfoLabel;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.PictureBox checkPictureBox1;
        private System.Windows.Forms.PictureBox checkPictureBox2;
        private System.Windows.Forms.Button saveImageButton;
    }
}