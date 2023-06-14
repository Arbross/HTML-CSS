using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TrackBar._WF
{
    [Serializable]
    public class Vote
    {
        private Bitmap img;
        private string name;
        private string path;
        private int yesVotes;
        private int noVotes;
        [XmlIgnore]
        public Bitmap Image
        {
            get => img;
            set => img = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Path
        {
            get => path;
            set => path = value;
        }
        public int YesVotes
        {
            get => yesVotes;
            set => yesVotes = value;
        }
        public int NoVotes
        {
            get => noVotes;
            set => noVotes = value;
        }
        public void Load()
        {
            Image = new Bitmap(Path);
        }
        public Vote(Bitmap img, int yesVotes, int noVotes, string path, string name)
        {
            Image = img;
            YesVotes = yesVotes;
            NoVotes = noVotes;
            Path = path;
            Name = name;
        }
        public Vote(string path, int yesVotes, int noVotes)
        {
            img = new Bitmap(path);
            Path = path;
            YesVotes = yesVotes;
            NoVotes = noVotes;
        }
        public Vote() : this(default(Bitmap), 0, 0, String.Empty, String.Empty) { }
    }
}
