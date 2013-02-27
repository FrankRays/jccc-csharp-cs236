using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursorPainting
{
    public partial class BrushForm : Form
    {
        public static Color brushColor;
        public static int brushSize;
        public static bool formClosed;

        public BrushForm()
        {
            InitializeComponent();

            brushColor = Color.Purple;
            brushSize = 4;
        }

        private void customSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            brushSize = (int)customSizeNumericUpDown.Value;

            if (customSizeRadioButton.Checked)
                customSizeNumericUpDown.Enabled = true;
            else
                customSizeNumericUpDown.Enabled = false;
        }

        private void redColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Color.Red;
        }

        private void greenColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Color.Green;
        }

        private void blueColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Color.Blue;
        }

        private void blackColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Color.Black;
        }

        private void purpleColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Color.Purple;
        }

        private void smallSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            brushSize = 4;
        }

        private void mediumSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            brushSize = 16;
        }

        private void largeSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            brushSize = 32;
        }

        private void customSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            brushSize = (int)customSizeNumericUpDown.Value;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        private void BrushForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
