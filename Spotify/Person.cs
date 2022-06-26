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
            Playlist newPlaylist = new(this, title);
            newPlaylist.playables = new List<iPlayable>();
            Playlists.Add(newPlaylist);
            CurrentPlaylist = newPlaylist;
            return newPlaylist;
        }

        public void RemovePlaylist(Playlist list)
        {
            Playlists.Remove(list);
        }

        public void AddToPlaylist(iPlayable number)
        {
            CurrentPlaylist.playables.Add(number);
        }

        public void RemoveFromPlaylist(iPlayable number)
        {
            CurrentPlaylist.playables.Remove(number);
        }

        public string GetNames()
        {
            foreach (var friend in Friends)
            {
                return friend.Name;
            }
            return "";
        }

        public override string? ToString()
        {
            return "Name: " + this.Name +
                "Friends: " + GetNames();

        }
    }
}
