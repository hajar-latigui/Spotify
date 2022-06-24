using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Person
    {
        public string Name { get; set; }
        public List<Person> Friends { get; set; }
        public List<Playlist> Playlists { get; set; }
        private Playlist _playlist;

        public Person(string name)
        {
            this.Name = name;
        }

        public List<Person> ShowFriends()
        {
            return Friends;
        }

        public void AddFriend(Person person)
        {
            Friends.Add(person);
        }

        public void RemoveFriend(Person person)
        {
            Friends.Remove(person);
        }

        public List<Playlist> ShowPlaylists()
        {
            return Playlists;
        }

        public Playlist SelectPlaylist(int id)
        {
            Playlist playlist = Playlists.ElementAt(id);
            this._playlist = playlist;
            return playlist;
        }

        public Playlist CreatePlaylist(string title)
        {
            Playlist newPlaylist = new(this, title);
            Playlists.Add(newPlaylist);
            return newPlaylist;
        }

        public void RemovePlaylist(Playlist list)
        {
            Playlists.Remove(list);
        }

        public void AddToPlaylist(iPlayable number)
        {
            _playlist.Add(number);
         }

        public void RemoveFromPlaylist(iPlayable number)
        { 
            _playlist.Remove(number);
        }

        public override string? ToString()
        {
            return "User: " + this.Name;
        }
    }
}
