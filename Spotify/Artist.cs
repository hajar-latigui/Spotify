using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Artist
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; }

        public Artist(string name, List<Album> albums)
        {
            Name = name;
            Albums = albums;
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        public override string? ToString()
        {
            return "Artist: " + this.Name + "\n" +
               "Albums: " + this.Albums + "\n" ;
        }
    }
}
