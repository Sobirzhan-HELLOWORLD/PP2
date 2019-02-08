using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());

                        for(int i = 1; i <=d; i++)
            {
             for(int j = 1; j <=i; j++)
                
                    Console.Write("[*]");//выодит звезду .до i 
                    Console.Write("\n");// и переводит на новую строку
                
            }
        }
    }
}
