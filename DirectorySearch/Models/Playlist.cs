using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorySearch.Models
{
    class PlaylistItem
    {
        public PlaylistItem(string title, int hashCode)
        {
            Title = title;
            HashCode = hashCode;
        }

        public string Title { get; set; }

        public int HashCode { get; set; }
    }
}
