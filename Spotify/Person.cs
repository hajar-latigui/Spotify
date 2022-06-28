namespace Spotify
{
    public class Person
    {
        public string Name { get; set; }
        public List<Person> Friends { get; set; }
        public List<Playlist> Playlists { get; set; }
        public Playlist CurrentPlaylist { get; set; }

        public Person(string name)
        {
            this.Name = name;
            this.Friends = new List<Person>();
            this.Playlists = new List<Playlist>();
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
            CurrentPlaylist = playlist;
            return playlist;
        }

        public Playlist CreatePlaylist(string title)
        {
            Playlist newPlaylist = new Playlist(this, title);
            Playlists.Add(newPlaylist);
            return newPlaylist;
        }

        public void RemovePlaylist(Playlist list)
        {
            Playlists.Remove(list);
        }

        public void AddToPlaylist(iPlayable number, Playlist cur)
        {
            Playlist p = Playlists.Where(x => x.Title.Contains(cur.Title)).Single();
            p.Add(number);
        }

        public void RemoveFromPlaylist(iPlayable number,Playlist cur)
        {
            Playlist p = Playlists.Where(x => x.Title.Contains(cur.Title)).Single();
            p.Remove(number);
        }

        public string GetNames()
        {
            foreach (var friend in Friends)
            {
                return friend.Name;
            }
            return "";
        }
        public string getPlaylists()
        {
            foreach (var list in Playlists)
            {
                return list.Title + "\n";
            }
            return "";
        }

        public override string? ToString()
        {
            return "Name: " + this.Name + "\n"+
                "Friends: " + GetNames() + "\n"+
                "Playlists" + getPlaylists();

        }
    }
}
