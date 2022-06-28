namespace Spotify
{
    public class SongCollection : iPlayable
    {
        public string Title { get; set; }
        private List<iPlayable> Playables;
        public List<iPlayable> playables { get { return Playables; } set { Playables = value; } }
        public int Length { get; set; }
        private int index = 0;

        public SongCollection(string title)
        {
            this.Title = title;
            this.playables = new List<iPlayable>();
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
            playables[index].Play();
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
            if(index <= playables.Count)
            {
                index++;
                Play();
            }
        }
    }

}
