using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Album : SongCollection
    {

        public List<Artist> Artists { get; set; }

        public Album(List<Artist> artists ,string title, List<Song> songs) : base(title)
        {
            this.Artists = artists;
            this.Title = title;
        }

        public override string ToString()
        {
            return "Title: " + this.Title + "\n" +
                "Artist: " + this.Artists + "\n";
        }
    }
}
