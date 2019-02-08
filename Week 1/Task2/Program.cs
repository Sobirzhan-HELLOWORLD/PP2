using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(" Sobirzhon", "18BD11039111", 7);//input Student
            s.Alsiher();//show name Student with increment the year of study
        }
    }
    class Student//сздаю новый класс студент
    {
        string Name; //{ get; set; }//name of a Student  
        string ID; //{ get; set; }//id of a Student
        int ys; //{ get; set; }//Student year of study
        public Student(string Name, string ID, int ys)//cсоздаю конструктор
        {
            this.Name = Name;//в констуркторе есть св-во имя ;
            this.ID = ID;//в констуркторе есть св-во айди;    
            this.ys = ys;//в констуркторе есть св-во год обучения;
        }
        public void Alsiher()//функция оф инкремен под названием алишер
        {
            ys++;
            Console.WriteLine("Student: {0}, ID: {1}, Year of study: {2}", Name, ID, ys);
        }
    }

}