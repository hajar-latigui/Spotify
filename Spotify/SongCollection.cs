namespace Spotify
{
    public class SongCollection : iPlayable
    {
        public string Title { get; set; }
        private List<iPlayable> Playables;
        public List<iPlayable> playables { get { return Playables; } set { Playables = value; } }
        public int Length { get; set; }

        public SongCollection(string title)
        {
            Title = title;
        }

        public void Add(iPlayable playable)
        {
            playables.Add(playable);
        }

        public void Remove(iPlayable playable)
        {
            playables.Remove(playable);
        }

        public List<iPlayable> ShowPlayables()
        {
            return playables;
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public void Play()
        {
            throw new NotImplementedException();
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
