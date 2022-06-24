using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Playlist: SongCollection
    {
        public int Id { get; set; }
        private Person owner;
        public Person Owner { get { return owner; } set { owner = value; } }

        public Playlist(Person owner, string title) : base(title)
        {
            this.Owner = owner;
            this.Title = title;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
