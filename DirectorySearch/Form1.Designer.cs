namespace DirectorySearch
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
            this.Load_btn = new System.Windows.Forms.Button();
            this.Playlist_btn = new System.Windows.Forms.Button();
            this.VideoPlayer = new AxAXVLC.AxVLCPlugin2();
            this.playlistView = new DirectorySearch.Views.PlaylistView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_btn
            // 
            this.Load_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Load_btn.AutoSize = true;
            this.Load_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Load_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_btn.Location = new System.Drawing.Point(12, 443);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(51, 28);
            this.Load_btn.TabIndex = 1;
            this.Load_btn.Text = "Load";
            this.Load_btn.UseVisualStyleBackColor = true;
            this.Load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            // 
            // Playlist_btn
            // 
            this.Playlist_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist_btn.Location = new System.Drawing.Point(88, 443);
            this.Playlist_btn.Name = "Playlist_btn";
            this.Playlist_btn.Size = new System.Drawing.Size(106, 28);
            this.Playlist_btn.TabIndex = 2;
            this.Playlist_btn.Text = "PlaylistItem";
            this.Playlist_btn.UseVisualStyleBackColor = true;
            this.Playlist_btn.Click += new System.EventHandler(this.Playlist_btn_Click);
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(12, 12);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(776, 416);
            this.VideoPlayer.TabIndex = 0;
            // 
            // playlistView
            // 
            this.playlistView.Enabled = false;
            this.playlistView.Location = new System.Drawing.Point(-2, -1);
            this.playlistView.Name = "playlistView";
            this.playlistView.Size = new System.Drawing.Size(804, 491);
            this.playlistView.TabIndex = 3;
            this.playlistView.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Playlist_btn);
            this.Controls.Add(this.Load_btn);
            this.Controls.Add(this.VideoPlayer);
            this.Controls.Add(this.playlistView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 VideoPlayer;
        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.Button Playlist_btn;
        private Views.PlaylistView playlistView;
        private System.Windows.Forms.Button button1;
    }
}

