using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursorPainting
{
    public partial class MainForm : Form
    {
        private static bool canPaint = false; // So the settings form can save a copy of the image.
        public static System.Windows.Forms.Panel canvasPanel;

        public MainForm()
        {
            InitializeComponent();

            new BrushForm().Show(this);

            this.Focus();

            canvasPanel = new Panel();

            canvasPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            canvasPanel.Location = new System.Drawing.Point(0, 0);
            canvasPanel.Name = "canvasPanel";
            canvasPanel.Size = new System.Drawing.Size(462, 365);
            canvasPanel.TabIndex = 1;
            canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseDown);
            canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseMove);
            canvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseUp);

            this.Controls.Add(canvasPanel);
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            canPaint = true;
        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            canPaint = false;
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (canPaint)
            {
                using (Graphics gfx = canvasPanel.CreateGraphics())
                {
                    gfx.FillEllipse(new SolidBrush(BrushForm.brushColor), e.X, e.Y, BrushForm.brushSize, BrushForm.brushSize);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
