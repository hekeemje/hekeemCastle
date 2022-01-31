using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane1 = new Plane("19°33′11″  27°13′21″", 20000000, 531, 2010, 2200.5, 220);
            plane1.PrintInfo();
            Car car1 = new Car("31°22′11″  49°21′17″", 25000, 160, 2018, "Toyota", 230);
            car1.PrintInfo();
            Ship ship1 = new Ship("46°30′13″  30°44′40″", 12000000, 120, 1999, 320, "Odessa port");
            ship1.PrintInfo();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
