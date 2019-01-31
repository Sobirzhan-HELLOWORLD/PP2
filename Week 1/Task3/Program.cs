using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {


            int d = int.Parse(Console.ReadLine());/*считываю d  в консоле сразу как интежер*/
            int[] a = new int[d];   /*создаю массив с размером d*/

            string s = Console.ReadLine();//считываем стринг чтобы он мог прочитать числа
            string[] arr = s.Split(' ');//идет стринговый массив куда идут числа через пробел 

            for (int i = 0; i < d; i++)
            {
              for (int k = 0; k < 2; k++)
                   {
                    Console.Write(arr[i]+' ');//выводим в консоль число до 2 значений .потом переходит к следующему
                }

            }
            
        }
    }
}

