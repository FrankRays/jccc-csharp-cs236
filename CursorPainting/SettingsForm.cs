using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CursorPainting
{
    public partial class SettingsForm : Form
    {
        private string clearCanvasText = "Doing this will erase your masterpiece!" + Environment.NewLine + Environment.NewLine + "You can't get it back!";
        private string saveImageText = "This will save your awesome work of art!" + Environment.NewLine + Environment.NewLine + "A dialog will appear to let me know where to save it at.";

        private bool clearCanvas;
        private bool saveImage;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.ProductVersion;
            string author = fvi.CompanyName;

            versionInfoLabel.Text = "Josho-Paint" + Environment.NewLine + "by " + author + Environment.NewLine + "v" + version;
        }

        private void clearCanvasButton_Click(object sender, EventArgs e)
        {
            actionLabel.Text = clearCanvasText;

            clearCanvas = true;
            saveImage = false;

            checkPictureBox1.Image = Properties.Resources.base_checkmark_32;
            checkPictureBox2.Image = null;
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            actionLabel.Text = saveImageText;

            saveImage = true;
            clearCanvas = false;

            checkPictureBox1.Image = null; 
            checkPictureBox2.Image = Properties.Resources.base_checkmark_32;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (clearCanvas)
            {
                MainForm.canvasPanel.Refresh();
                Close();
            }
            else if (saveImage)
            {
                SaveFileDialog dlg = new SaveFileDialog();

                dlg.DefaultExt = "png";
                dlg.Title = "Let's save your work of art...";
                dlg.InitialDirectory =Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                dlg.AddExtension = true;
                dlg.Filter = "PNG files (*.png)|*.png|BMP files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif";

                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageFormat fmt = null;

                    switch(dlg.FilterIndex)
                    {
                        case 1:
                            fmt = ImageFormat.Png;
                            break;
                        case 2:
                            fmt = ImageFormat.Bmp;
                            break;
                        case 3:
                            fmt = ImageFormat.Jpeg;
                            break;
                        case 4:
                            fmt = ImageFormat.Gif;
                            break;
                    }

                    CaptureWindow(MainForm.canvasPanel.Handle).Save(dlg.FileName, fmt);
                    Close();
                }
            }
        }

        /// <summary>
        /// Captures an <see cref="Image"/> of the specified window
        /// </summary>
        /// <param name="handle">The handle of the window to capture</param>
        /// <returns>An <see cref="Image"/> of the specified window</returns>
        public static Image CaptureWindow(IntPtr handle)
        {
            IntPtr hdcSrc = GetWindowDC(handle);

            RECT windowRect = new RECT();
            GetWindowRect(handle, windowRect);

            int width = windowRect.right - windowRect.left;
            int height = windowRect.bottom - windowRect.top;

            IntPtr hdcDest = CreateCompatibleDC(hdcSrc);
            IntPtr hBitmap = CreateCompatibleBitmap(hdcSrc, width, height);

            IntPtr hOld = SelectObject(hdcDest, hBitmap);
            BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, SRCCOPY);
            SelectObject(hdcDest, hOld);
            DeleteDC(hdcDest);
            ReleaseDC(handle, hdcSrc);

            Image image = Image.FromHbitmap(hBitmap);
            DeleteObject(hBitmap);

            return image;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, [Out] RECT rect);

        [DllImport("gdi32.dll")]
        public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjectSource, int nXSrc, int nYSrc, int dwRop);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteDC(IntPtr hDC);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

        [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Auto)]
        public class RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        static int SRCCOPY = 0x00CC0020;

        // sorry for the long mess of interop code, panel gfx doesn't convert to a bitmap well.
    }
}
