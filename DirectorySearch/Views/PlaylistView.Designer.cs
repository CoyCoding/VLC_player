namespace DirectorySearch.Views
{
    partial class PlaylistView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Playlist_listbox = new System.Windows.Forms.ListBox();
            this.Play_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Playlist_listbox
            // 
            this.Playlist_listbox.FormattingEnabled = true;
            this.Playlist_listbox.Location = new System.Drawing.Point(0, 3);
            this.Playlist_listbox.Name = "Playlist_listbox";
            this.Playlist_listbox.Size = new System.Drawing.Size(645, 511);
            this.Playlist_listbox.TabIndex = 0;
            // 
            // Play_btn
            // 
            this.Play_btn.Location = new System.Drawing.Point(695, 35);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(75, 23);
            this.Play_btn.TabIndex = 1;
            this.Play_btn.Text = "button1";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(695, 78);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 2;
            this.Cancel_btn.Text = "button2";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // PlaylistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.Playlist_listbox);
            this.Name = "PlaylistView";
            this.Size = new System.Drawing.Size(816, 515);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Playlist_listbox;
        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.Button Cancel_btn;
    }
}
