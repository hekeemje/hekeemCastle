using System;

namespace _01_Problem
{
    class Student // пользовательский тип данных
    {
        private string Name;
        private string Surname;
        private int Age;
        private bool isGoodStudent;

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {isGoodStudent}");
        }
    }
}
