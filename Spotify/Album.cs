namespace Spotify
{
    public class Album : SongCollection
    {

        public List<Artist> Artists { get; set; }

        public Album(List<Artist> artists, string title, List<Song> songs) : base(title)
        {
            this.Artists = artists;
            this.Title = title;
            this.playables = new List<iPlayable>(songs);

            foreach (var artist in artists)
            {
                artist.AddAlbum(this);
            }
        }

        public override string ToString()
        {
            return "Title: " + this.Title + "\n" +
                "Artist: " + this.Artists + "\n";
        }
    }
}
