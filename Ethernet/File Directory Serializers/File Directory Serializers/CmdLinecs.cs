using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace File_Directory_Serializers
{
    class CmdLines
    {
        private string path = @"C:\Users\" + Environment.UserName;
        public string Path
        {
            get => path;
            set
            {

            }
        }
        public string Concat(params char[] symbols)
        {
            string tmp = null;
            for (int i = 0; i < symbols.Length; i++)
            {
                tmp += symbols[i];
            }
            return tmp;
        }
        public void Md(string fname)
        {
            string tmpPath = Path + "\\" + fname;
            Directory.CreateDirectory(tmpPath);
        }
        public void Rd(string fname)
        {
            if (Directory.Exists(fname))
            {
                string tmpPath = Path + "\\" + fname;
                Directory.Delete(tmpPath);
            }
        }
        public void Cd(string fname)
        {
            if (Directory.Exists(fname))
            {
                string tmpPath = Path + "\\" + fname;
                Directory.SetCurrentDirectory(tmpPath);
                path = tmpPath;
            }
        }
        private void Dir_Support(string fname, ref int folderCounter, ref int fileCounter, ref long byteCount)
        {
            string[] entries = Directory.GetFileSystemEntries(fname);
            foreach (var f in entries)
            {
                string sInfo = "<DIR>";
                if (File.GetAttributes(f) != FileAttributes.Directory)
                {
                    FileInfo fi = new FileInfo(f);
                    long lInfo = fi.Length;
                    Console.WriteLine($"{File.GetCreationTime(f), -15}{lInfo, 15}{System.IO.Path.GetFileName(f), 20}");
                    ++folderCounter;
                    byteCount += lInfo;
                }
                else
                {
                    Console.WriteLine($"{File.GetCreationTime(f), -15}{sInfo, 15}{System.IO.Path.GetFileName(f), 20}");
                    ++fileCounter;
                }
            }
        }
        public void Dir(string fname)
        {
            if (Directory.Exists(fname))
            {
                int folderCounter = 0;
                int fileCounter = 0;
                long byteCount = 0;

                if (fname.Contains(Path))
                {
                    Dir_Support(fname, ref folderCounter, ref fileCounter, ref byteCount);
                }
                else if (!fname.Contains(Path))
                {
                    string tmpPath = Path + @"\" + fname;
                    Dir_Support(tmpPath, ref folderCounter, ref fileCounter, ref byteCount);
                }
                else if (fname == Path)
                {
                    Dir_Support(Path, ref folderCounter, ref fileCounter, ref byteCount);
                }
                else if (fname == "")
                {
                    Dir_Support(Path, ref folderCounter, ref fileCounter, ref byteCount);
                }
                Console.WriteLine($"{fileCounter, 10} files{byteCount, 10} bytes\n{folderCounter, 10} folders");
            }
        }
        public void Create(string fname, string text)
        {
            File.WriteAllText(fname, text);
        }
        public void Type(string fname)
        {
            Console.Write($"{File.ReadAllText(fname)}\n\n");
        }
        public void Copy(string fname, string new_fname)
        {
            File.Copy(fname, new_fname);
        }
        public void Del(string fname)
        {
            File.Delete(fname);
        }
        public void Append(string fname, string text)
        {
            File.AppendAllText(fname, text);
        }
        public CmdLines()
        {
            Directory.SetCurrentDirectory(path);
            Console.WriteLine("LifeCraft [Version 1.0]\n(c) Корпорация LifeCraft(LifeCraft Corporation), 2021.Все права защищены.\n");
            while (true)
            {
                Console.Write($"{path}>");
                string choose = Console.ReadLine();
                Console.WriteLine();

                if (Concat(choose[0], choose[1]) == "md")
                {
                    if (choose[2] == ' ')
                    {
                        string fname = null;
                        for (int i = 3; i < choose.Length; i++)
                        {
                            fname += choose[i];
                        }
                        Md(fname);
                    }
                    else
                    {
                        Console.WriteLine("This isn't a command.\n");
                    }
                }
                else if (Concat(choose[0], choose[1]) == "rd")
                {
                    if (choose[2] == ' ')
                    {
                        string fname = null;
                        for (int i = 3; i < choose.Length; i++)
                        {
                            fname += choose[i];
                        }
                        Rd(fname);
                    }
                    else
                    {
                        Console.WriteLine("This isn't a command.\n");
                    }
                }
                else if (Concat(choose[0], choose[1]) == "cd")
                {
                    if (choose[2] == ' ')
                    {
                        string fname = null;
                        for (int i = 3; i < choose.Length; i++)
                        {
                            fname += choose[i];
                        }
                        Cd(fname);
                    }
                }
                else if (Concat(choose[0], choose[1], choose[2]) == "dir")
                {
                    if (choose[3] == ' ')
                    {
                        string fname = null;
                        for (int i = 4; i < choose.Length; i++)
                        {
                            fname += choose[i];
                        }
                        Dir(fname);
                    }
                    else
                    {
                        Console.WriteLine("This isn't a command.\n");
                    }
                }
                else if (Concat(choose[0], choose[1], choose[2], choose[3], choose[4], choose[5]) == "create")
                {
                    if (choose[6] == ' ')
                    {
                        string fname = null;
                        string text = null;
                        int j = 0;
                        for (int i = 7; i < choose.Length; i++)
                        {
                            if (choose[i] == ' ')
                            {
                                j = i;
                                break;
                            }
                            fname += choose[i];
                        }
                        for (int i = j + 1; i < choose.Length; i++)
                        {
                            text += choose[i];
                        }
                        Create(fname, text);
                    }
                    else
                    {
                        Console.WriteLine("This isn't a command.\n");
                    }
                }
                else if (Concat(choose[0], choose[1], choose[2], choose[3]) == "type")
                {
                    if (choose[4] == ' ')
                    {
                        string fname = null;
                        for (int i = 5; i < choose.Length; i++)
                        {
                            fname += choose[i];
                        }
                        Type(fname);
                    }
                    else
                    {
                        Console.WriteLine("This isn't a command.\n");
                    }
                }
                else if (Concat(choose[0], choose[1], choose[2], choose[3]) == "copy")
                {
                    if (choose[4] == ' ')
                    {
                        string fname = null;
                        string new_fname = null;
                        int j = 0;
                        for (int i = 5; i < choose.Length; i++)
                        {
                            fname += choose[i];
                            if (choose[i] == ' ')
                            {
                                j = i;
                                break;
                            }
                        }
                        for (int i = j + 1; i < choose.Length; i++)
                        {
                            new_fname += choose[i];
                        }
                        Copy(fname, new_fname);
                    }
                    else
                    {
                        Console.WriteLine("This isn't a command.\n");
                    }
                }
                else if (Concat(choose[0], choose[1], choose[2]) == "del")
                {
                    if (choose[3] == ' ')
                    {
                        string fname = null;
                        for (int i = 4; i < choose.Length; i++)
                        {
                            fname += choose[i];
                        }
                        Del(fname);
                    }
                    else
                    {
                        Console.WriteLine("This isn't a command.\n");
                    }
                }
                else if (Concat(choose[0], choose[1], choose[2], choose[3], choose[4], choose[5]) == "append")
                {
                    if (choose[6] == ' ')
                    {
                        string fname = null;
                        string text = null;
                        int j = 0;
                        for (int i = 7; i < choose.Length; i++)
                        {
                            if (choose[i] == ' ')
                            {
                                j = i;
                                break;
                            }
                            fname += choose[i];
                        }
                        for (int i = j + 1; i < choose.Length; i++)
                        {
                            text += choose[i];
                        }
                        Append(fname, text);
                    }
                    else
                    {
                        Console.WriteLine("This isn't a command.\n");
                    }
                }
            }
        }
    }
}
