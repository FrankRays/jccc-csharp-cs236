using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoneWordCombinations
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            // As long as the string is larger than 0, because if we backspace the first char, it will cause an infinite format exception.
            if (inputTextBox.Text.Length > 0)
            {
                outputTextBox.Clear(); // We clear the output box, so we can re-enter the updated data.

                outputTextBox.Text = WordGen.CalculatePossibleWords(inputTextBox.Text); // Let's get the words.
            }
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Let's check if the user presses a 0 or 1...
            if (e.KeyChar == '0' || e.KeyChar == '1')
            {
                MessageBox.Show("You must enter a number between 2 and 9.", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true; // So it won't enter the bad char.
            }

            // Now let's check to see if the user enters an invalid char.
            try
            {
                Convert.ToInt32(e.KeyChar); // It will throw an exception if the char doesn't convert to an int32
            }
            catch
            {
                MessageBox.Show("You must enter a valid character!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear(); // Clear the output
            inputTextBox.Clear(); // Clear the input
            inputTextBox.Focus(); // Refocus the input
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Select File to Save";

            DialogResult result = sfd.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sfd.FileName) || string.IsNullOrWhiteSpace(sfd.FileName))
                    MessageBox.Show("You must enter a valid file name!", "Invalid Filename", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);

                    foreach (string line in outputTextBox.Lines)
                    {
                        sw.WriteLine(line);
                    }

                    sw.Close();
                    sw.Dispose();
                }
            }
        }
    }
}
