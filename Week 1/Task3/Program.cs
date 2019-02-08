using System;

namespace ConsoleApp1
{
    class Program
    {
        static void PP2(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(a[i]);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //вводим размер и сразу в интежеры 
            string s = Console.ReadLine();//для пробела
            string[] str = s.Split();//делит по пробелам и в массив его

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(str[i]);
            }

            PP2(a, n);//вызываем метод (функцию)пп2

        }
    }
}