using System;

namespace Task_1
{
    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private readonly DateTime accCreated;

        public string Login { get { return login; } set { login = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } set { age = value; } }
        public DateTime AccCreated { get { return accCreated; } }

        public User()
        {
            this.accCreated = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Login : " + Login);
            Console.WriteLine("Full name : " + Name + " " + Surname);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Acc created time : " + AccCreated);
            Console.WriteLine("_________________________________________");
        }
    }
}
