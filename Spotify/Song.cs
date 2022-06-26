namespace Spotify
{
    public class Song : iPlayable
    {
        public string Title { get; set; }
        public List<Artist> Artists { get; set; }
        public Genre SongGenre { get; set; }
        public int Length { get; set; }

        public Song(string title, List<Artist> artists, Genre songGenre)
        {
            this.Title = title;
            this.Artists = artists;
            this.SongGenre = songGenre;

            foreach (var artist in artists)
            {
                artist.AddSong(this);
            }
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public void Play()
        {
            Console.WriteLine("is playing :" + Title);
        }

        public void Stop()
        {
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            Console.WriteLine("is playing :");
        }
    }
}
