
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//считываем число n и превращаем его в инт .
            int[] a = new int[n];// создаю массив
            int  cnt = 0;
            int r = 0;
            int[] b = new int[n];// создаю массив с размером n.

            string s = Console.ReadLine();//считываю стринг потому что и пробелы он считает. 
            string[] c = s.Split(); //создаю массив который делит мой стринг по пробелам.

            for (int i = 0; i < n; ++i) {
                a[i] = int.Parse(c[i]);
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 2; j < a[i]; j++)//создаю второй массив чтобы нашел что не прайм.
                {
                    if (a[i] % j == 0) a[i] = 0;//пытаемся найти прайм намберс .если оно прайм  присваеваем 0
                }
            }



            for (int i = 0; i < n; i++)
            {
                if (a[i] > 1)//if numbers bigger than one there are prime numbers 
                {
                 
                    b[r] = a[i];
                    r++;//увеличаю на один и как бы создаю массив                
                    cnt++;
                }
            }

            Console.WriteLine(cnt);//вывожу кол-во прайм намберс 
            for (int i = 0; i < cnt; i++)
            {
                Console.Write(b[i] + " ");//вывожу прайм намберс
            }
        }
    }
}