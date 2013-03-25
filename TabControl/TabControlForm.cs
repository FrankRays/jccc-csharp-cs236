using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab10
{
    public partial class TabControlForm : Form
    {
        public TabControlForm()
        {
            InitializeComponent();
        }

        private void customRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (customRadioButton.Checked)
                customMessageTextBox.Enabled = true;
            else
                customMessageTextBox.Enabled = false;
        }

        private void customMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Text = customMessageTextBox.Text;
        }

        private void cheezburgerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.Text = "I can has cheezburger?";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.Text = "kthxbai";
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.ForeColor = SystemColors.ControlText;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.ForeColor = Color.Red;
        }

        private void purpleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.ForeColor = Color.Purple;
        }

        private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.Font = new Font(messageLabel.Font.Name, 12.0f);
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.Font = new Font(messageLabel.Font.Name, 16.0f);
        }

        private void largeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.Font = new Font(messageLabel.Font.Name, 20.0f);
        }

        int maxLeft;
        int maxRight;
        int original;
        bool left;
        bool done;
        Control control;

        private void ShakeControl(Control ctrl)
        {
            original = ctrl.Location.X; // Capture the original window location (X)

            // Make the max opposite 100 pixels relative to their location
            maxLeft = ctrl.Location.X - 120;
            maxRight = this.Location.X + 120;

            // Reset or initialize values
            left = false;
            done = false;

            control = ctrl;

            // Start the animation timer.
            animationTimer.Start();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            int constant = 25;

            // Start out going right.

            if (!left && !done)
            {
                if (control.Location.X < maxRight)
                    control.Location = new Point(control.Location.X + constant, control.Location.Y);
                else if (control.Location.X >= maxRight)
                    left = true;
            }
            else if (left && !done) // then we start going left
            {
                if (control.Location.X > maxLeft)
                    control.Location = new Point(control.Location.X - constant, control.Location.Y);
                else if (control.Location.X <= maxRight)
                    done = true;
            }
            else // left && done
            {
                if (control.Location.X != original)
                    control.Location = new Point(control.Location.X + constant, control.Location.Y);
                else if (control.Location.X == original) // make sure we get in the exact place.
                {
                    //animationTimer.Stop();
                    done = false;
                    left = false;
                }
            }
        }

        private void TabControlForm_Load(object sender, EventArgs e)
        {
            ShakeControl(aboutLabel);
        }
    }
}
