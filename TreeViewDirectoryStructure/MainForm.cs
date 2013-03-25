using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeViewDirectoryStructure
{
    public partial class MainForm : Form
    {
        string substr;

        public MainForm()
        {
            InitializeComponent();
        }

        public void PopulateTreeView(string directory, TreeNode parentNode)
        {
            string[] directoryArray = Directory.GetDirectories(directory);

            try
            {
                if (directoryArray.Length != 0)
                {
                    foreach (string dir in directoryArray)
                    {
                        substr = Path.GetFileNameWithoutExtension(dir);

                        TreeNode myNode = new TreeNode(substr);

                        parentNode.Nodes.Add(myNode);

                        PopulateTreeView(dir, myNode);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access Denied");
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            generateButton.Enabled = false;
            pathTextBox.Enabled = false;

            if (Directory.Exists(pathTextBox.Text))
            {
                directoryTreeView.Nodes.Clear();

                directoryTreeView.Nodes.Add(pathTextBox.Text);

                PopulateTreeView(pathTextBox.Text, directoryTreeView.Nodes[0]);
            }
            else
            {
                generateButton.Enabled = true;
                pathTextBox.Enabled = true;

                MessageBox.Show("Whoops! The path you entered does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pathTextBox.Focus();
            }

            generateButton.Enabled = true;
            pathTextBox.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pathTextBox.Text = Environment.CurrentDirectory;
        }
    }
}
