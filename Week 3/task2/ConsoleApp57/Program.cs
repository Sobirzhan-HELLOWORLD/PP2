using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3_Part2
{
    class Farmanager
    {
        public int cursor;
        public string path;
        DirectoryInfo directory = null;
        public FileSystemInfo fsi = null;
        public int sze;
        public int d = 0;

        public void size()
        {
            sze = directory.GetFileSystemInfos().Length;
        }

        public Farmanager(string path)
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            sze = directory.GetFileSystemInfos().Length;
        }

        public void color(FileSystemInfo fso, int i)
        {
            if (cursor == i)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                fsi = fso;
            }
            else if (fso.GetType() == typeof(FileInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }



        public void show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);
            Console.ForegroundColor = ConsoleColor.Green;
            //  Console.WriteLine("   >>> " + directory.FullName);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();

            for (int i = 0; i < fs.Length; i++)
            {
                color(fs[i], i);
                Console.WriteLine((i + 1) + " " + fs[i].Name);

            }
        }

        public void up()
        {
            cursor--;
            if (cursor < 0)
            {
                cursor = cursor + sze;
            }
        }

        public void down()
        {
            cursor++;
            if (cursor == sze)
            {
                cursor = 0;
            }
        }

        public void openfile(FileSystemInfo fsi)
        {
            d = 1;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            StreamReader sr = new StreamReader(fsi.FullName);
            Console.WriteLine(sr.ReadToEnd());
        }

        public void start()
        {
            ConsoleKeyInfo ki = Console.ReadKey();

            while (true)
            {
                if (d == 0)
                {
                    show();
                }
                else
                {
                    openfile(fsi);
                }
                size();


                ki = Console.ReadKey();
                if (ki.Key == ConsoleKey.UpArrow)
                {
                    up();
                }
                if (ki.Key == ConsoleKey.DownArrow)
                {
                    down();
                }
                if (ki.Key == ConsoleKey.Enter)
                {
                    if (fsi.GetType() == typeof(DirectoryInfo))
                    {
                        path = path + "/" + fsi.Name;
                        cursor = 0;
                    }
                    else
                    {
                        d = 1;
                    }
                }

                if (ki.Key == ConsoleKey.Escape)
                {
                    if (d == 0)
                    {
                        path = directory.Parent.FullName;
                        cursor = 0;
                    }
                    else
                    {
                        d = 0;
                    }
                }
                if (ki.Key == ConsoleKey.Delete)
                {
                    fsi.Delete();

                }
                if (ki.Key == ConsoleKey.S)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.Write("Change the name to: ");
                    string s = Console.ReadLine();
                    Console.WriteLine("Press enter to continue");
                    ki = Console.ReadKey();

                    if (ki.Key == ConsoleKey.Enter)
                    {

                        //s = Path.Combine(fsi.pa, s);
                        string s1 = fsi.FullName;

                        if (fsi.GetType() == typeof(FileInfo))
                        {
                            FileInfo f = new FileInfo(fsi.FullName);
                            string a = Path.Combine(f.DirectoryName, s);

                            File.Move(f.FullName, a);
                        }
                        else
                        {

                            DirectoryInfo d = new DirectoryInfo(fsi.FullName);
                            string a = Path.Combine(d.Parent.FullName, s);
                            Directory.Move(fsi.FullName, a);
                        }

                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\test\Week 1\Task2";
            Farmanager farman = new Farmanager(path);
            farman.start();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
