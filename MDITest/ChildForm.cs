using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDITest
{
    public class ChildForm : Form
    {
        private PictureBox picBox;

        public ChildForm(string title)
        {
            this.Text = title;

            picBox = null;
        }

        public ChildForm(string title, string imageName, int formWidth, int formHeight)
        {
            this.Text = title;

            this.Width = formWidth;
            this.Height = formHeight;

            picBox = new PictureBox();
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.Width = formWidth;
            picBox.Height = formHeight;

            picBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

            picBox.Location = new Point(0, 0);

            this.Controls.Add(picBox);
        }

        protected override void OnResize(EventArgs e)
        {
            if (picBox != null)
            {
                picBox.Width = this.Width;
                picBox.Height = this.Height;
            }

            base.OnResize(e);
        }
    }
}
