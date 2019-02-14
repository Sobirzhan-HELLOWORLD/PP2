using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name; //паблик чтобы был доступным
        public string id;
        public int year;
        public Student()
        {
            name = Console.ReadLine(); //ввожу имя 
           id = Console.ReadLine();//ввожу айди
          year = Convert.ToInt32(Console.ReadLine());//ввожу год обучения
        }
        public Student(string name, string id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }
        public void info()
        {
            Console.WriteLine(name + " " + id + " " + (year + 1));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            a.info();
            Student b = new Student("DavlatovS", "19bd", 2001);
            b.info();


            Console.ReadKey();
        }
    }
}