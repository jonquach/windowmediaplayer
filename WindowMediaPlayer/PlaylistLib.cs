using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowMediaPlayer
{
    public class PlaylistLib
    {
        public List<Playlist> playlist = new List<Playlist>();
        public List<string> nameList = new List<string>();

        public PlaylistLib()
        {
        }

        public void RefreshNameList()
        {
            nameList.Clear();
            foreach (Playlist p in playlist)
            {
                nameList.Add(p.Name);
            }
        }
    }
}
