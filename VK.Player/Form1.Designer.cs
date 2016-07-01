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
            this.Shuffle = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
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
            this.songsList.Location = new System.Drawing.Point(12, 44);
            this.songsList.Name = "songsList";
            this.songsList.Size = new System.Drawing.Size(461, 292);
            this.songsList.TabIndex = 0;
            this.songsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.songsList_MouseClick);
            // 
            // CurrSong
            // 
            this.CurrSong.AutoSize = true;
            this.CurrSong.Enabled = false;
            this.CurrSong.Location = new System.Drawing.Point(3, 0);
            this.CurrSong.Name = "CurrSong";
            this.CurrSong.Size = new System.Drawing.Size(61, 17);
            this.CurrSong.TabIndex = 2;
            this.CurrSong.Text = "No song";
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
            // Shuffle
            // 
            this.Shuffle.Location = new System.Drawing.Point(314, 352);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(159, 34);
            this.Shuffle.TabIndex = 5;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // Normal
            // 
            this.Normal.Location = new System.Drawing.Point(314, 392);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(159, 34);
            this.Normal.TabIndex = 6;
            this.Normal.Text = "Normal List";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(12, 13);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(296, 22);
            this.textSearch.TabIndex = 7;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(314, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(85, 25);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(406, 13);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(67, 25);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 453);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.songsList);
            this.Name = "Form1";
            this.Text = "Vk.Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ListBox songsList;
        private System.Windows.Forms.Label CurrSong;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Shuffle;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Add;
    }
}

