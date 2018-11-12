using DirectorySearch.Models;
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

namespace DirectorySearch
{
    public partial class Form1 : Form
    {
        List<PlaylistItem> playlist = new List<PlaylistItem>();

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
                playlist.Add(new PlaylistItem(openFile.SafeFileName, openFile.GetHashCode()));
                Console.WriteLine(playlist[0].HashCode);
                VideoPlayer.playlist.add("file:///"+ openFile.FileName, openFile.SafeFileName, null);
                
            }
        }

        private void Playlist_btn_Click(object sender, EventArgs e)
        {
            playlistView.LoadPlaylist(playlist);
        }

        public void ChangeVideo()
        {
            
            VideoPlayer.playlist.stop();
            VideoPlayer.playlist.playItem(playlist[0].HashCode);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
