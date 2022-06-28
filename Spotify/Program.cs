namespace Spotify
{
    public class Program
    {
        public static bool Active = true;

        static void Main(string[] args)
        {
            Artist artist = new Artist("NCT", new List<Album> { });
            Song Afterlife = new Song("Afterlife", new List<Artist> { artist }, 203, Genre.DRUM_AND_BASS);
            Song Dancing = new Song("Dancing In The Rain", new List<Artist> { artist }, 211, Genre.DRUM_AND_BASS);
            Song Say = new Song("Say To Me", new List<Artist> { artist }, 278, Genre.DRUM_AND_BASS);
            Album Astrophysical = new Album(new List<Artist> { artist, new Artist("Adele", new List<Album> { }) }, "Astrophysical", new List<Song> { Afterlife, Dancing, Say });

            List<Person> Users = new List<Person>{new Person("Robert"),new Person ("John"),new Person ("Sarah"),
                new Person ("Jasmin"),new Person ("Lisanne")};

            Client client = new Client(Users, new List<Album> { Astrophysical }, new List<Song> { Afterlife, Dancing, Say });

            Astrophysical.Play();
            Astrophysical.Next();
            Say.Play();
            Console.WriteLine();
            Login(client);


            do
            {
                HeadMenu(client);
            } while (Active);

        }

        public static void HeadMenu(Client client)
        {
            Console.WriteLine("\nChoose one of the options:");
            Console.WriteLine("0: add friend");
            Console.WriteLine("1: add playlist");
            Console.WriteLine("2: add Album To Playlist");
            Console.WriteLine("3: add Song To Playlist");
            Console.WriteLine("4: Show Songs in playlist");
            Console.WriteLine("5: Select album");
            Console.WriteLine("6: Play Album");
            Console.WriteLine("7: Quit program");


            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (x)
                {
                    case 0:
                        addFriend(client);
                        break;
                    case 1:
                        AddPlaylist(client);
                        break;
                    case 2:
                        addAlbumToPlaylist(client);
                        break;
                    case 3:
                        addSongToPlaylist(client);
                        break;
                    case 4:
                        showSong(client);
                        break;
                    case 5:
                        SelectAlbum(client);
                        break;
                    case 6:
                        PlayAlbum(client);
                        break;
                    case 7:
                        Active = false;
                        return;
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("enter a valid number");
            }
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

        public static void sowFriends (Client client)
        {
            List<Person> friends = client.activeUser.ShowFriends();
            foreach (Person person in friends)
            {
                Console.WriteLine(person);
            }
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
            var res = Console.ReadLine();
            bool valid = false;

            do
            {
                try
                {
                    client.CreatePlaylist(res);
                    valid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a valid number");
                }
            } while (!valid);
    
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

        public static void showSong(Client client)
        {
            Console.WriteLine("Select a Playlist");
            client.ShowPlaylists();
            bool valid = false;
            do
            {
                try
                {
                    int res = Convert.ToInt32(Console.ReadLine());
                    client.SelectPlaylist(res);
                    valid = true;

                    client.ShowSongsInPlaylist();
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
                    client.Play();
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


