using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Client
    {
        public iPlayable CurrentlyPlaying { get; set; }
        public int CurrentTime { get; set; }
        public bool IsPlaying { get; set; }
        public bool Shuffle { get; set; }
        public bool IsRepeating { get; set; }
        private Playlist SelectedPlaylist ;
        public Person activeUser { get; set; }
        private Person ActiveUser { get { return activeUser; } set { activeUser = value; } }
        private List<Album> Albums ;
        private List<Person> Users ;
        private List<Song> Songs ;
        private Person User;
        private Song currentSong;


        public Client(List<Person> users, List<Album> album, List<Song> song)
        {
            this.Albums = album;
            this.Songs = song;
            this.Users = users ;
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
            foreach (var album in Albums)
            {
                Console.WriteLine(album.ToString());
            }
        }
        public void SelectAlbum(int id)
        {
            Album album = Albums.ElementAt(id);

        }
        public void ShowAllSongs()
        {
            foreach (var song in Songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
        public void SelectSong(int id)
        {
            Song song = Songs.ElementAt(id);
        }
        public void ShowAllUsers()
        {
            foreach (var user in this.Users)
            {
                Console.WriteLine(user.Name);
            }
        }
        public void SelectUser(int id)
        {
           this.User = this.Users.ElementAt(id);
        }

        public void ShowUserPlaylists()
        {
            List<Playlist> userPlaylists =  User.ShowPlaylists();
            foreach (var playlist in userPlaylists)
            {
                Console.WriteLine("Title: ", playlist.Title);
            }
        }
        public void SelectUserPlaylist(int id)
        {
            this.SelectedPlaylist = User.SelectPlaylist(id);
        }

        

        public void Play()
        {
            CurrentlyPlaying = new Song("Hello", new List<Artist> { new Artist("Adele", new List<Album> { })},Genre.Pop);
            this.IsPlaying = true;
            CurrentlyPlaying.Play();
        }
        public void Stop()
        {
            this.IsPlaying = false;
        }
        public void Pause()
        {
            this.IsPlaying = false;
            CurrentlyPlaying.Pause();
        }
        public void NextSong()
        {
            var currentSong = SelectedPlaylist.ShowPlayables();
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
            activeUser.CreatePlaylist(title);
        }

        public void ShowPlaylists()
        {
           List<Playlist> userPlaylists = activeUser.ShowPlaylists();
            foreach (var playlist in userPlaylists)
            {
                Console.WriteLine("Title: ", playlist.Title);
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

            this.SelectedPlaylist.ShowPlayables();
        }
        public void AddToPlaylist(int id)
        {
            Song song = Songs.ElementAt(id);
            activeUser.AddToPlaylist(song);
        }

        public void RemoveFromPlaylist(int id)
        {
            Song song = Songs.ElementAt(id);
            activeUser.RemoveFromPlaylist((iPlayable)song);
        }
        public void ShowFriends()
        {
            activeUser.ShowFriends();
        }

        public void SelectFriend()
        {
           
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
