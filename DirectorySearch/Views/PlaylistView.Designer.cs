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
            this.Playlist_Listbox = new System.Windows.Forms.ListBox();
            this.Load_Video_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Playlist_Listbox
            // 
            this.Playlist_Listbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Playlist_Listbox.FormattingEnabled = true;
            this.Playlist_Listbox.Location = new System.Drawing.Point(3, 1);
            this.Playlist_Listbox.Name = "Playlist_Listbox";
            this.Playlist_Listbox.Size = new System.Drawing.Size(704, 459);
            this.Playlist_Listbox.TabIndex = 0;
            // 
            // Load_Video_btn
            // 
            this.Load_Video_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_Video_btn.Location = new System.Drawing.Point(728, 24);
            this.Load_Video_btn.Name = "Load_Video_btn";
            this.Load_Video_btn.Size = new System.Drawing.Size(75, 23);
            this.Load_Video_btn.TabIndex = 1;
            this.Load_Video_btn.Text = "button1";
            this.Load_Video_btn.UseVisualStyleBackColor = true;
            this.Load_Video_btn.Click += new System.EventHandler(this.Load_Video_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_btn.Location = new System.Drawing.Point(728, 64);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 2;
            this.Cancel_btn.Text = "button1";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // PlaylistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Load_Video_btn);
            this.Controls.Add(this.Playlist_Listbox);
            this.Name = "PlaylistView";
            this.Size = new System.Drawing.Size(829, 463);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Playlist_Listbox;
        private System.Windows.Forms.Button Load_Video_btn;
        private System.Windows.Forms.Button Cancel_btn;
    }
}
