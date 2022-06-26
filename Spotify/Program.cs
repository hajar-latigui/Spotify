namespace Spotify
{
    public class Program
    {

        static void Main(string[] args)
        {
            Artist artist = new Artist("NCT", new List<Album> { });
            Song Afterlife = new Song("Afterlife", new List<Artist> { artist }, Genre.DRUM_AND_BASS);
            Song Dancing = new Song("Dancing In The Rain", new List<Artist> { artist }, Genre.DRUM_AND_BASS);
            Song Say = new Song("Say To Me", new List<Artist> { artist }, Genre.DRUM_AND_BASS);
            Album Astrophysical = new Album(new List<Artist> { artist, new Artist("Adele", new List<Album> { }) }, "Astrophysical", new List<Song> { Afterlife, Dancing, Say });

            List<Person> Users = new List<Person>{new Person("Robert"),new Person ("John"),new Person ("Sarah"),
                new Person ("Jasmin"),new Person ("Lisanne")};

            Client client = new Client(Users, new List<Album> { Astrophysical }, new List<Song> { Afterlife, Dancing, Say });

            Login(client);
            addFriend(client);
            AddPlaylist(client);
            addAlbumToPlaylist(client);
            addSongToPlaylist(client);
            SelectAlbum(client);
            PlayAlbum(client);

        }

        public static void Login(Client client)
        {
            Console.WriteLine("Select Acive User:");
            client.ShowAllUsers();

            bool valid = false;

            do
            {
                try
                {
                    int res = Convert.ToInt32(Console.ReadLine());
                    client.SelectUser(res);
                    client.SetActiveUser(client.User);
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a valid number");
                }
            } while (!valid);


        }


        public static void addFriend(Client client)
        {
            Console.WriteLine("Add a friend:");
            client.ShowAllUsers();

            bool valid = false;

            do
            {
                try
                {
                    int res = Convert.ToInt32(Console.ReadLine());
                    client.AddFriend(res);
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a valid number");
                }
            } while (!valid);

        }

        public static void AddPlaylist(Client client)
        {
            Console.WriteLine("Playlist Name: ");
            string res = Console.ReadLine();
            client.CreatePlaylist(res);
        }

        public static void addAlbumToPlaylist(Client client)
        {
            Console.WriteLine("Select an album:");
            client.ShowAllAlbums();

            bool valid = false;

            do
            {
                try
                {
                    int res = Convert.ToInt32(Console.ReadLine());
                    client.AddToPlaylist(res, "album");
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a valid number");
                }
            } while (!valid);
        }

        public static void addSongToPlaylist(Client client)
        {
            Console.WriteLine("Select a song:");
            client.ShowAllSongs();

            bool valid = false;

            do
            {
                try
                {
                    int res = Convert.ToInt32(Console.ReadLine());
                    client.AddToPlaylist(res, "song");
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a valid number");
                }
            } while (!valid);
        }

        public static void SelectAlbum(Client client)
        {
            Console.WriteLine("Select album:");
            client.ShowAllAlbums();

            bool valid = false;

            do
            {
                try
                {
                    int res = Convert.ToInt32(Console.ReadLine());
                    client.SelectAlbum(res);
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a valid number");
                }
            } while (!valid);
        }

        public static void PlayAlbum(Client client)
        {
            Console.WriteLine("Select album:");
            client.ShowAllAlbums();

            bool valid = false;

            do
            {
                try
                {
                    int res = Convert.ToInt32(Console.ReadLine());
                    client.SelectAlbum(res);
                    client.CurrentlyPlaying = client.SelectedAlbum;
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a valid number");
                }
            } while (!valid);
        }


    }

}


