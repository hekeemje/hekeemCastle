using System;

namespace _01_Problem
{
    class Student // пользовательский тип данных
    {
        private string name;
        private string surname;
        private int age;
        private bool isGoodStudent;

        public void SetName(string name)
        {
            name = name;
        }

        public string GetName()
        {
            return surname;
        }

        public string Surname
        {
            get 
            {
                return surname;
            }
            set 
            {
                surname = value;
            }
        }

        public void Print()
        {
            Console.WriteLine($"{name} {surname} {age} {isGoodStudent}");
        }
    }
}
