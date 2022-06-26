namespace Spotify
{
    public class Artist
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; }

        public Artist(string name, List<Album> albums)
        {
            this.Name = name;
            this.Albums = albums;
            this.Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            this.Songs.Add(song);
        }

        public void AddAlbum(Album album)
        {
            this.Albums.Add(album);
        }

        public override string? ToString()
        {
            return "Artist: " + this.Name + "\n" +
               "Albums: " + this.Albums + "\n";
        }
    }
}
