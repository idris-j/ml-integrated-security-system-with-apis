namespace File_Security_System
{
    partial class fileViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileViewerForm));
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.fileBrowser = new System.Windows.Forms.WebBrowser();
            this.btnRewind = new System.Windows.Forms.Button();
            this.btnFit = new System.Windows.Forms.Button();
            this.zoomInBtn = new System.Windows.Forms.Button();
            this.pictureView = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(198, 403);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(279, 403);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(349, 403);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(430, 403);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 4;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // fileBrowser
            // 
            this.fileBrowser.Location = new System.Drawing.Point(12, 12);
            this.fileBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.fileBrowser.Name = "fileBrowser";
            this.fileBrowser.Size = new System.Drawing.Size(776, 385);
            this.fileBrowser.TabIndex = 5;
            // 
            // btnRewind
            // 
            this.btnRewind.Location = new System.Drawing.Point(511, 403);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(75, 23);
            this.btnRewind.TabIndex = 6;
            this.btnRewind.Text = "Rewind";
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // btnFit
            // 
            this.btnFit.Location = new System.Drawing.Point(602, 403);
            this.btnFit.Name = "btnFit";
            this.btnFit.Size = new System.Drawing.Size(75, 23);
            this.btnFit.TabIndex = 7;
            this.btnFit.Text = "Fit to Screen";
            this.btnFit.UseVisualStyleBackColor = true;
            this.btnFit.Click += new System.EventHandler(this.btnFit_Click);
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.Location = new System.Drawing.Point(117, 403);
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Size = new System.Drawing.Size(75, 23);
            this.zoomInBtn.TabIndex = 9;
            this.zoomInBtn.Text = "Zoom In";
            this.zoomInBtn.UseVisualStyleBackColor = true;
            this.zoomInBtn.Click += new System.EventHandler(this.zoomInBtn_Click);
            // 
            // pictureView
            // 
            this.pictureView.Location = new System.Drawing.Point(12, 12);
            this.pictureView.Name = "pictureView";
            this.pictureView.Size = new System.Drawing.Size(776, 385);
            this.pictureView.TabIndex = 10;
            this.pictureView.TabStop = false;
            this.pictureView.Click += new System.EventHandler(this.pictureView_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(776, 385);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // fileViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureView);
            this.Controls.Add(this.zoomInBtn);
            this.Controls.Add(this.btnFit);
            this.Controls.Add(this.btnRewind);
            this.Controls.Add(this.fileBrowser);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnZoomOut);
            this.Name = "fileViewerForm";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.fileViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.WebBrowser fileBrowser;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Button btnFit;
        private System.Windows.Forms.Button zoomInBtn;
        private System.Windows.Forms.PictureBox pictureView;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}