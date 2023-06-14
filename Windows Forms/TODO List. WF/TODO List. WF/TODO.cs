using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TODO_List._WF
{
    [Serializable]
    public class TODO
    {
        [XmlIgnore]
        private CheckBox priority;
        private string strPriority;
        private string name;
        private string placeOn;
        private DateTime date;
        [XmlElement("Priority")]
        public string StrPriority
        {
            get => strPriority;
            set => strPriority = value;
        }
        [XmlElement("Name")]
        public string Name
        {
            get => name;
            set => name = value;
        }
        [XmlElement("PlaceOn")]
        public string PlaceOn
        {
            get => placeOn;
            set => placeOn = value;
        }
        [XmlElement("PlanDate")]
        public DateTime PlanDate
        {
            get => date;
            set => date = value;
        }
        public TODO(CheckBox priority, string name, string placeOn, DateTime date)
        {
            this.priority = priority;
            strPriority = this.priority.Text;
            Name = name;
            PlaceOn = placeOn;
            PlanDate = date;
        }
        public TODO() : this(default(CheckBox), "Noname", "Noplace", DateTime.Now.AddDays(1)) { }
        public override string ToString()
        {
            return $"Priority : {priority.Text}, Name : {Name}, Place on : {PlaceOn}, Date : {PlanDate}";
        }
    }
}
