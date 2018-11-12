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
                VideoPlayer.playlist.add("file:///"+ openFile.FileName, openFile.SafeFileName, null);
            }
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            VideoPlayer.playlist.play();
        }

        private void Pause_btn_Click(object sender, EventArgs e)
        {
            VideoPlayer.playlist.pause();
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            VideoPlayer.playlist.stop();
        }
    }
}
