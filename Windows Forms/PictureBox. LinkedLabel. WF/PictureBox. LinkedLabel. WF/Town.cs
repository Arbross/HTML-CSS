using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureBox._LinkedLabel._WF
{
    public class Town
    {
        private string name;
        private string ethernet_path;
        private List<string> photo_paths;
        public int photo_counter { get; set; }
        public int views { get; set; }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Ethernet_Path
        {
            get => ethernet_path;
            set => ethernet_path = value;
        }
        public List<string> Photo_Paths
        {
            get => photo_paths;
            set => photo_paths = value;
        }
        public Town(string name, string ethernet_path, List<string> photo_paths)
        {
            Name = name;
            Ethernet_Path = ethernet_path;
            Photo_Paths = photo_paths;
        }
        public Town() : this("Noname", "NoEthernetPath", default(List<string>)) { }
        private string Print()
        {
            string paths = null;
            foreach (var item in Photo_Paths)
            {
                paths += (item + " ");
            }
            return paths;
        }
        public override string ToString()
        {
            return $"Name : {Name}, Ethernet path : {Ethernet_Path}, Photo paths : {Print()}";
        }
    }
}
