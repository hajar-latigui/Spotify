namespace Spotify
{
    public interface iPlayable
    {
        public int Length { get; set; }

        public void Play();
        public void Stop();
        public void Pause();
        public void Next();

    }
}
