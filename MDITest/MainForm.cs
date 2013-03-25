using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDITest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void heavyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm("Heavy!", "heavy_sandvich", 258, 243);
            child.MdiParent = this;
            child.Show();
        }

        private void daffyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm("Daffy!", "daffy_robinhood", 500, 361);
            child.MdiParent = this;
            child.Show();
        }

        private void catsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm("Ping Pong!", "cats_pingpong", 490, 368);
            child.MdiParent = this;
            child.Show();
        }

        private void emptyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm("Here is the void()");
            child.MdiParent = this;
            child.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
