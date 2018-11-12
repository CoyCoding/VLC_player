using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DirectorySearch.Models;

namespace DirectorySearch.Views
{
    public partial class PlaylistView : UserControl
    {
        public event EventHandler ChangeItem_Event;

        public PlaylistView()
        {
            InitializeComponent();
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            if (ChangeItem_Event != null)
            {
                ChangeItem_Event(this, new EventArgs());
            }
            UnFocusView();
        }

        internal void LoadPlaylist(List<PlaylistItem> playlist)
        {
            FocusView();
            Playlist_listbox.DataSource = playlist;
            Playlist_listbox.DisplayMember = "title";
            Playlist_listbox.ValueMember = "Id";
        }

        private void FocusView()
        {
            this.Show();
            this.Enabled = true;
            BringToFront();
        }

        private void UnFocusView()
        {
            Playlist_listbox.DataSource = null;
            this.Enabled = false;
            this.Visible = false;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            UnFocusView();
        }

        public int GetSelectedItem()
        {

            return (int)Playlist_listbox.SelectedValue;
        }
    }
}
