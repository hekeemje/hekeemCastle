using System;

namespace _01_Problem
{
    class Student // пользовательский тип данных
    {
        public string Name;
        public string Surname;
        public int Age;
        private bool isGoodStudent;

        public void Print()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {isGoodStudent}");
        }
    }
}
