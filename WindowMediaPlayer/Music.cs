using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowMediaPlayer
{
    public class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Duration { get; set; }
        [XmlIgnore()]
        public Uri PathUri { get; set; }
        [XmlElement("URI")]
        public string _URI
        {
            get { return PathUri.ToString(); }
            set { PathUri = new Uri(value); }
        }

        public Music()
        {

        }

        public Music(string musicPath)
        {
            TagLib.File musicInfos = TagLib.File.Create(musicPath);

            PathUri = new Uri(musicPath, UriKind.RelativeOrAbsolute);
            Title = musicInfos.Tag.Title;
            Artist = musicInfos.Tag.FirstAlbumArtist;
            Album = musicInfos.Tag.Album;
            Duration = musicInfos.Properties.Duration.ToString(@"mm\:ss");
        }   
    }
}
