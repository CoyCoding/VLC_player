using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectorySearch.Models;

namespace DirectorySearch.Views
{
    public partial class PlaylistView : UserControl
    {
        public PlaylistView()
        {
            InitializeComponent();
        }

        internal void LoadPlaylist(PlaylistItem playlist)
        {
               
        }

        private void Load_Video_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            UnFocusView();           
        }

        internal void LoadPlaylist(List<PlaylistItem> playlist)
        {
            FocusView();
            Playlist_Listbox.DataSource = playlist;
            Playlist_Listbox.DisplayMember = "title";
        }

        private void FocusView()
        {
            this.Show();
            this.Enabled = true;
            BringToFront();
        }

        private void UnFocusView()
        {
            Playlist_Listbox.DataSource = null;
            this.Enabled = false;
            this.Visible = false;
        }
    }
}
