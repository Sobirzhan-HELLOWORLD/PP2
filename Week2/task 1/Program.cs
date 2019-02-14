using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineer = File.ReadAllText(@"C:\Users\User\Desktop\test\Новая папка\Week2\task 1\poli.txt");
            char[] ritusya = lineer.ToCharArray();
            Array.Reverse(ritusya);
            string f = new string(ritusya);
            if (lineer == f)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
            }
                }
    }

