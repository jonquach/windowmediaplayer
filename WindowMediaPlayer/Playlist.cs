using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowMediaPlayer
{
    public class Playlist
    {
        public string Name{ get; set; }
        public List<Music> MusicList { get; set; }

        public Playlist()
        {

        }

        public Playlist(string name, List<Music> music)
        {
            Name = name;
            MusicList = music;
        }
    }
}
