using System;

namespace justCoding
{
    class Person
    {
        public string name;
        public int age;

        public Person() : this("Неизвестно")
        {
        }
        public Person(string name) : this(name, 18)
        {
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person { name = "Tom", age = 31 };
            tom.GetInfo();          // Имя: Tom  Возраст: 31
        }
    }
}