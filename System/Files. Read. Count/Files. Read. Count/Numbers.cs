using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Files.Read.Count
{
    public class Numbers
    {
        public Thread[] threads = null;

        public static int Words { get; set; }
        public static int Lines { get; set; }
        public static int Punctuation { get; set; }

        public List<string> files { get; set; } = new List<string>();

        public void ReadAllInfo(object obj)
        {
            string word = null;
            foreach (char item in File.ReadAllText((string)obj))
            {
                lock (this)
                {
                    if (item >= (char)33 && item <= (char)47)
                    {
                        Punctuation++;
                    }

                    if (item == '\n')
                    {
                        Lines++;
                    }

                    if (item == ' ')
                    {
                        Words++;
                        word = null;
                    }
                    word += item;
                }
            }
        }
    }
}
