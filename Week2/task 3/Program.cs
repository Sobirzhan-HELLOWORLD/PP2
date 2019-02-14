using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
       static void print(int r )
        {
            for (int i = 0; i <r; i++)
            {
                Console.Write("    ");
            }
        }
        
        static void Show(DirectoryInfo d, int r)
        {
            print(r-3);

      
            Console.WriteLine(d.Name);
            FileInfo[] fo = d.GetFiles();

            foreach (FileInfo g in fo)
            {
                print(r);  
                Console.WriteLine(g.Name);
                         }
            DirectoryInfo[] di = d.GetDirectories();

            foreach (DirectoryInfo dd in di)
            {
                Show(dd, r+3);
            }


        }

        static void Main(string[] args)
        {
            DirectoryInfo s = new DirectoryInfo(@"C:\Users\User\Desktop\test\Новая папка\Week2");

            Show(s, 3);
        }
    }
}
