namespace Spotify
{
    public class Song : iPlayable
    {
        public string Title { get; set; }
        public List<Artist> Artists { get; set; }
        public Genre SongGenre { get; set; }
        public int Length { get; set; }

        public Song(string title, List<Artist> artists,int lenght, Genre songGenre)
        {
            this.Title = title;
            this.Artists = artists;
            this.SongGenre = songGenre;
            this.Length = lenght;

            foreach (var artist in artists)
            {
                artist.AddSong(this);
            }
        }

        public string getArtist()
        {
            foreach (var artist in Artists)
            {
                return artist.Name + ", ";
            }
            return "";
        }

        public override string? ToString()
        {
            return "Title: " + Title + "\n"+
                "Artists: " + getArtist() + "\n"+
                "Length: " + Length + "\n";
        }

        public void Play()
        {
            Console.WriteLine("is playing :\n" + ToString());
        }

        public void Stop()
        {
            Console.WriteLine("Stopped Playing :\n" + ToString());
        }

        public void Pause()
        {
            Console.WriteLine("is pausing :\n" + ToString());
        }

        public void Next()
        {
            Console.WriteLine("is playing :\n" + ToString());
        }
    }
}
