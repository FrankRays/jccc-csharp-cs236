using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuTestApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Josh Kennedy!", "About This Program.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            purpleToolStripMenuItem.Checked = false;
        }

        private void ClearFont()
        {
            microsoftSansSerifToolStripMenuItem.Checked = false;
            timesNewRomanToolStripMenuItem.Checked = false;
            courierNewToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();

            blackToolStripMenuItem.Checked = true;

            testLabel.ForeColor = Color.Black;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();

            greenToolStripMenuItem.Checked = true;

            testLabel.ForeColor = Color.Green;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();

            purpleToolStripMenuItem.Checked = true;

            testLabel.ForeColor = Color.Purple;
        }

        private void microsoftSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();

            microsoftSansSerifToolStripMenuItem.Checked = true;

            testLabel.Font = new Font("Microsoft Sans Serif", 16.0f, testLabel.Font.Style);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();

            timesNewRomanToolStripMenuItem.Checked = true;

            testLabel.Font = new Font("Times New Roman", 16.0f, testLabel.Font.Style);
        }

        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();

            courierNewToolStripMenuItem.Checked = true;

            testLabel.Font = new Font("Courier New", 16.0f, testLabel.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked; // invert the current value.

            testLabel.Font = new Font(testLabel.Font, testLabel.Font.Style ^ FontStyle.Bold); // use xor to add/remove bold.
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !(italicToolStripMenuItem.Checked); // invert the current value.

            testLabel.Font = new Font(testLabel.Font, testLabel.Font.Style ^ FontStyle.Italic); // use xor to add/remove italics.
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            underlineToolStripMenuItem.Checked = !underlineToolStripMenuItem.Checked; // invert the current value.

            testLabel.Font = new Font(testLabel.Font, testLabel.Font.Style ^ FontStyle.Underline); // use xor to add/remove underline.
        }

        private void strikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strikeoutToolStripMenuItem.Checked = !strikeoutToolStripMenuItem.Checked; // invert the current value.

            testLabel.Font = new Font(testLabel.Font, testLabel.Font.Style ^ FontStyle.Strikeout); // use xor to add/remove strikeout.
        }
    }
}
