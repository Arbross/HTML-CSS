using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry.HW
{
    public class Themes
    {
        public Themes()
        {
            listEn.Add(nameof(Light));
            listEn.Add(nameof(Dark));
            listEn.Add(nameof(Default));

            listUa.Add("Світла");
            listUa.Add("Темна");
            listUa.Add("Стандартна");
        }

        public static string Light { get; private set; } = "0";
        public static string Dark { get; private set; } = "1";
        public static string Default { get; private set; } = "2";

        public List<string> listEn = new List<string>();
        public List<string> listUa = new List<string>();
    }
}
