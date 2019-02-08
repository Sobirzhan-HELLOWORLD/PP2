using System;

namespace TASK2
{
    class Student/*создаю класс по названием студент */
    {
        private string name;//пишу паблик чтобы он был открыт и доступен для дальнейшей работы с ним
        private string id;
        private int year;

        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        /*public string Name //В С# 7,0
        {
            get => name;
            set => name = value;
        }
        public string Id
        {
            get => id;
            set => id = value;
        }*/

        public string getName()
        {
            return name;
        }
        public string setName(string name)
        {
            this.name = name;
        }
        public string getId()
        {
            return id;
        }
        public string setId(string id)
        {
            this.id = id;
        }
        
        public int getYear()
        {
            return year;
        }

        public int setIncrementYear(int year)
        {
            this.year = ++year;
        }
       
        
        class Program
        {
            static void Main(string[] args)
            {
                Student obj = new Student("Сабыр", "9379992D", 2018);
                string name = obj.getName();
                string id = obj.getId();
                int year = obj.getYear;
                
                Console.WriteLine(name);
                Console.WriteLine(id);
                Console.WriteLine(year);


            }
        }
    }
}