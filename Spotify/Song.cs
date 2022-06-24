using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Song : iPlayable
    {
        public string Title { get; set; }
        public List<Artist> Artists { get; set; }
        public Genre SongGenre { get; set; }
        public int Length { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Song(string title, List<Artist> artists, Genre songGenre)
        {
            Title = title;
            Artists = artists;
            SongGenre = songGenre;
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
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }
    }
}
