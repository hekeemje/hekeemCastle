using System;
using System.Collections.Generic;
using MyMathLib;

namespace something_12
{
    class Student // Пользовательский тип данных
    {
        public string Name;
        private string surname;
        private int Age; // public or private ( паблик с Большой буквы , приват с маленькой называть члены ) 

        public void SetName(string name)
        {
            if (name.Length > 0)
                Name = name;
            else
                throw new ArgumentException("Длина имени должна быть больше нуля");

        }

        public string GetName()
        {
            return Name;
        }

      

        public void SetAge(int age)
        {
            if (age >= 18)
                Age = age;
            else
                throw new ArgumentException("Мало лет , гуляй.");
        }

        public void Print()
        {
        // Console.WriteLine($"{Name} {Surname} {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int res = MainFunction.Add(2, 8);

            // student info ( FI , age )

            //List<string> surnames = new List<string>();
            //List<string> names = new List<string>();
            //List<byte> ages = new List<byte>();

            //surnames.Add("Ivanov");
            //names.Add("Ivan");
            //ages.Add(18);

            Student student1 = new Student(); // экземпляр класса Student
            student1.Age = 18; //      student1.SetAge(2);
            student1.Name = "Petr";
            // student1.SetName() = "Petrov";

            Student student2 = new Student();
            student2.Age = 19; //      student2.SetAge(2);
            student2.Name = "Ivan";
            // student2.Surname = "Ivanov";

            student1.Print();

            Student student = new Student();
            student.Name = "lol";
            student.SetAge(2); // редактить
            Console.WriteLine(student.GetName());


        }
    }
}
