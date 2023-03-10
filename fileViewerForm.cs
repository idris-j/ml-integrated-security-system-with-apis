using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace File_Security_System
{
    public partial class fileViewerForm : Form
    {
        MediaElement mediaElement = new MediaElement();
        private string filePath;
        public System.Drawing.Image cImage;
        private int _zoomLevel = 100;
        public fileViewerForm(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            LoadFile(filePath);
        }
        private void LoadFile(string filePath)
        {
            try
            {
                if (filePath.EndsWith(".mp4"))
                {
                    //mediaElement requires an assembly reference "PresentatonFramework"
                    mediaElement.Source = new Uri(filePath);
                    mediaElement.Play();
                    btnPlay.Visible = true;
                    btnPause.Visible = true;
                    btnForward.Visible = true;
                    btnRewind.Visible = true;
                }
                else if (filePath.EndsWith(".txt"))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string content = reader.ReadToEnd();
                        fileBrowser.DocumentText = content;
                    }
                    btnPlay.Visible = false;
                    btnPause.Visible = false;
                    btnForward.Visible = false;
                    btnRewind.Visible = false;
                    zoomInBtn.Visible = false;
                    btnZoomOut.Visible = false;
                    btnFit.Visible = false;
                }
                else if (filePath.EndsWith(".jpg") || filePath.EndsWith(".jpeg") || filePath.EndsWith(".png") || filePath.EndsWith(".gif"))
                {
                    //fileBrowser.Navigate(filePath);
                    System.Drawing.Image currentImage = System.Drawing.Image.FromFile(filePath);
                    pictureView.Image = currentImage;
                    zoomInBtn.Visible = true;
                    btnZoomOut.Visible = true;
                    btnFit.Visible = true;
                }
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("Error message: " + ex.Message);
                Console.WriteLine("Stack trace: " + ex.StackTrace);
            }
        }

        private void UpdateImageSize()
        {
            System.Drawing.Image currentImage = System.Drawing.Image.FromFile(filePath);
             pictureView.Width = currentImage.Width * _zoomLevel / 100;
            pictureView.Height = currentImage.Height * _zoomLevel / 100;
        }

        private void zoomInBtn_Click(object sender, EventArgs e)
        {
            if (_zoomLevel < 200)
            {
                _zoomLevel += 10;
                UpdateImageSize();
            }
            //webBrowser.Document.InvokeScript("zoomIn");
            //fileBrowser.ExecWB(OLECMDID.OLECMDID_ZOOM, OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, 250, IntPtr.Zero);

        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (_zoomLevel > 10)
            {
                _zoomLevel -= 10;
                UpdateImageSize();
            }
            //webBrowser.Document.InvokeScript("zoomOut");
            //fileBrowser.ExecWB(OLECMDID.OLECMDID_ZOOM, OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, 250, IntPtr.Zero);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mediaElement.Play();
            //fileBrowser.ExecWB(OLECMDID.OLECMDID_PLAY, OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, IntPtr.Zero, IntPtr.Zero);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mediaElement.Pause();
            //fileBrowser.ExecWB(OLECMDID.OLECMDID_PAUSE, OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, IntPtr.Zero, IntPtr.Zero);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            mediaElement.Position += TimeSpan.FromSeconds(10);
            //fileBrowser.ExecWB(OLECMDID.OLECMDID_FORWARD, OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, IntPtr.Zero, IntPtr.Zero);
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            mediaElement.Position -= TimeSpan.FromSeconds(10);
            //fileBrowser.ExecWB(OLECMDID.OLECMDID_BACK, OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, IntPtr.Zero, IntPtr.Zero);
        }

        private void btnFit_Click(object sender, EventArgs e)
        {
            //fileBrowser.ExecWB(OLECMDID.OLECMDID_BACK, OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, IntPtr.Zero, IntPtr.Zero);

        }

    }
}
