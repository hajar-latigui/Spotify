namespace Spotify
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client Song = new Client(new List<Person> { }, new List<Album> { }, new List<Song> { });
            Song.Play();
        }


    }
}