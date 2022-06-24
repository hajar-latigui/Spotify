using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
