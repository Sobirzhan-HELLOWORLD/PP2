using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = (@"C:\Users\User\Pictures\ILIYAS.txt");
            string path1 = (@"C:\Users\User\Desktop\KBTU2019     2 СЕМЕСТР\ИСТОРИЯ АБЫЛХОЖИН\rita.txt");

            DirectoryInfo asistent = new DirectoryInfo(path1);
            FileInfo rita = new FileInfo(path);
            FileInfo AKsahabayeva = new FileInfo(path1);
            FileStream du = AKsahabayeva.Open(FileMode.OpenOrCreate);
           
            du.Close();
                ria.CopyTo(path1 + @"\copiya.txt", true);
                rita.Delete();
            
            
        }
    }
}
