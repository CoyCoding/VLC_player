using DirectorySearch.Models;
using DirectorySearch.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectorySearch
{
    public partial class Form1 : Form
    {
        List<PlaylistItem> playListItems = new List<PlaylistItem>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All Files |*| .m4a |*.m4a";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                var currentFileName = openFile.SafeFileName;
                VideoPlayer.playlist.add("file:///"+ openFile.FileName, currentFileName, null);
                playListItems.Add(new PlaylistItem(VideoPlayer.playlist.itemCount-1, currentFileName));
                
            }
        }

        private void ChangeItem_Event(object sender, EventArgs e)
        {
            VideoPlayer.playlist.playItem(playlistView.GetSelectedItem());
        }

        private void Playlist_btn_Click(object sender, EventArgs e)
        {
           playlistView.LoadPlaylist(playListItems);
        }

        public void ChangeVideo()
        {
            VideoPlayer.playlist.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VideoPlayer.playlist.currentItem.ToString());
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            VideoPlayer.playlist.next();
        }

        private void Previous_btn_Click(object sender, EventArgs e)
        {
            VideoPlayer.playlist.prev();
        }
    }
}
