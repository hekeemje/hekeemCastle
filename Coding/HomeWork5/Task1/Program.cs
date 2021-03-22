using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer name = new NamePerson();
            name.Print("Elon");
            Printer company = new Company();
            company.Print("Tesla, SpaceX");
            Printer position = new Position();
            position.Print("Head");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}