using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorySearch.Models
{
    class PlaylistItem
    {
        public PlaylistItem(int id, string fileName)
        {
            Id = id;
            Title = fileName;
        }

        public int Id { get; set; }

        public string Title { get; set; }
    }
}
