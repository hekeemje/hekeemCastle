using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            NamePerson name = new NamePerson();
            name.Print("Elon");
            var company = (Company)name;
            company.Print("Tesla, SpaceX");
            var position = (Position)company;
            position.Print("Head");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}