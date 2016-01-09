using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowMediaPlayer
{
    public class Videos
    {
        public string Title { get; set; }
        [XmlIgnore()]
        public Uri PathUri { get; set; }
        [XmlElement("URI")]
        public string _URI
        {
            get { return PathUri.ToString(); }
            set { PathUri = new Uri(value); }
        }

        public Videos()
        {
            PathUri = null;
            Title = "Not a video";
        }

        public Videos(string videoPaths)
        {
            PathUri = new Uri(videoPaths);
            Title = videoPaths.Split('\\').Last();
        }

    }
}
