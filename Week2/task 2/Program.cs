using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static public bool isitprime(int a)
        {
            if (a == 1)
            {
                return false;
            }
            else if (a == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            
            StreamReader strd = new StreamReader(@"C:\Users\User\Desktop\test\Новая папка\Week2\task 2\ruty.txt");
            StreamWriter stw = new StreamWriter(@"C:\Users\User\Desktop\test\Новая папка\Week2\task 2\ruty2.txt");
            string s = strd.ReadToEnd();
            string[] str = s.Split();
            for (int i = 0; i < str.Length; i++){
                if (isitprime(int.Parse(str[i])));
                {
                    stw.Write(str[i] + " ");

                }
            }

            stw.Close();

        }
    }
}
