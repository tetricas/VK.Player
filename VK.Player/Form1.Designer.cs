namespace VK.Player
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.songsList = new System.Windows.Forms.ListBox();
            this.CurrSong = new System.Windows.Forms.Label();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // songsList
            // 
            this.songsList.FormattingEnabled = true;
            this.songsList.ItemHeight = 16;
            this.songsList.Location = new System.Drawing.Point(12, 12);
            this.songsList.Name = "songsList";
            this.songsList.Size = new System.Drawing.Size(461, 324);
            this.songsList.TabIndex = 0;
            this.songsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.songsList_MouseClick);
            // 
            // CurrSong
            // 
            this.CurrSong.AutoSize = true;
            this.CurrSong.Enabled = false;
            this.CurrSong.Location = new System.Drawing.Point(3, 0);
            this.CurrSong.Name = "CurrSong";
            this.CurrSong.Size = new System.Drawing.Size(68, 17);
            this.CurrSong.TabIndex = 2;
            this.CurrSong.Text = "No songs";
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(3, 27);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(219, 45);
            this.mediaPlayer.TabIndex = 3;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayer_PlayStateChange);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mediaPlayer);
            this.panel1.Controls.Add(this.CurrSong);
            this.panel1.Location = new System.Drawing.Point(12, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 104);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.songsList);
            this.Name = "Form1";
            this.Text = "Vk.Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ListBox songsList;
        private System.Windows.Forms.Label CurrSong;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Panel panel1;
    }
}

