namespace Spotify
{
    public class Client
    {
        public iPlayable CurrentlyPlaying { get; set; }
        public int CurrentTime { get; set; }
        public bool IsPlaying { get; set; }
        public bool Shuffle { get; set; }
        public bool IsRepeating { get; set; }
        private Playlist SelectedPlaylist;
        public Person activeUser { get; set; }
        public Album SelectedAlbum { get; set; }
        private Person ActiveUser { get { return activeUser; } set { activeUser = value; } }
        private List<Playlist> userPlaylists;
        private List<Album> Albums;
        private List<Person> Users;
        private List<Song> Songs;
        public Person User;
        private Song currentSong;


        public Client(List<Person> users, List<Album> album, List<Song> song)
        {
            this.Albums = album;
            this.Songs = song;
            this.Users = users;
            this.Shuffle = false;
            this.IsRepeating = false;
            this.IsPlaying = false;
        }

        public void SetActiveUser(Person person)
        {
            this.ActiveUser = person;
        }


        public void ShowAllAlbums()
        {
            int i = 0;
            foreach (var album in Albums)
            {
                Console.WriteLine(i + ": " + album.Title);
                i++;
            }
            Console.WriteLine();
        }

        public void SelectAlbum(int id)
        {
            SelectedAlbum = Albums.ElementAt(id);
        }
        public void ShowAllSongs()
        {
            foreach (var song in Songs)
            {
                Console.WriteLine(song.Title);
            }
        }
        public void SelectSong(int id)
        {
            Song song = Songs.ElementAt(id);
        }
        public void ShowAllUsers()
        {
            int i = 0;
            foreach (var user in this.Users)
            {
                Console.WriteLine(i + ": " + user.Name);
                i++;
            }
        }
        public void SelectUser(int id)
        {
            this.User = this.Users.ElementAt(id);
        }

        public void ShowUserPlaylists()
        {
            userPlaylists = User.ShowPlaylists();
            foreach (var playlist in userPlaylists)
            {
                Console.WriteLine("Title: "+ playlist.Title);
            }

            foreach (var list in userPlaylists.SelectMany(k => k.playables)) 
            {
                Console.WriteLine("Title: " + list.ToString());
            }
        }

        public void SelectUserPlaylist(int id)
        {
            this.SelectedPlaylist = User.SelectPlaylist(id);
        }



        public void Play()
        {
            this.IsPlaying = true;
            CurrentlyPlaying.Play();
        }
        public void Stop()
        {
            this.IsPlaying = false;
            CurrentlyPlaying.Stop();
        }
        public void Pause()
        {
            this.IsPlaying = false;
            CurrentlyPlaying.Pause();
        }
        public void NextSong()
        {
            this.IsPlaying = true;
            CurrentlyPlaying.Play();
        }
        public void SetShuffle()
        {
            this.Shuffle = !this.Shuffle;
        }
        public void SetRepeat()
        {
            this.IsRepeating = !this.IsRepeating;
        }



        public void CreatePlaylist(string title)
        {
           this.SelectedPlaylist =  this.activeUser.CreatePlaylist(title);

        }

        public void ShowPlaylists()
        {
            userPlaylists = activeUser.ShowPlaylists();
            int i = 0;
            foreach (var playlist in userPlaylists)
            {
                Console.WriteLine( $"{i} Title: {playlist.Title}");
                i++;
            }

        }

        public void SelectPlaylist(int id)
        {
            this.SelectedPlaylist = activeUser.SelectPlaylist(id);
        }

        public void RemovePlaylist(int id)
        {
            Playlist removePlaylist = activeUser.SelectPlaylist(id);
            activeUser.RemovePlaylist(removePlaylist);
        }

        public void ShowSongsInPlaylist()
        {
            Playlist playlist = this.SelectedPlaylist;
            foreach (var song in playlist.playables)
            {
                Song son = song as Song;
                Console.WriteLine(son.Title);
            }
        }

        public void AddToPlaylist(int id, String Type)
        {
            if(userPlaylists == null) {
                Console.WriteLine("Add a Playlist first");
                return;
            }
            if (Type == "song")
            {
                Song song = Songs.ElementAt(id);
                activeUser.AddToPlaylist((iPlayable)song, this.SelectedPlaylist);
            }
            else if (Type == "album")
            {
                Album album = Albums.ElementAt(id);
                foreach (var song in album.playables)
                {
                    activeUser.AddToPlaylist(song, this.SelectedPlaylist);
                }
            }
        }

        public void RemoveFromPlaylist(int id)
        {
            Song song = Songs.ElementAt(id);
            activeUser.RemoveFromPlaylist((iPlayable)song, this.SelectedPlaylist);
        }
        public void ShowFriends()
        {
            List<Person> friends = activeUser.ShowFriends();
            foreach (var person in friends)
            {
                Console.WriteLine(person.Name);
            }
        }

        public void SelectFriend(int id)
        {
            // List<Person> friends = activeUser.ShowFriends;
            Person friend = Users.ElementAt(id);
        }
        public void AddFriend(int id)
        {
            var user = Users.ElementAt(id);
            activeUser.AddFriend(user);
        }

        public void RemoveFriend(int id)
        {
            var user = Users.ElementAt(id);
            activeUser.RemoveFriend(user);
        }

    }
}
