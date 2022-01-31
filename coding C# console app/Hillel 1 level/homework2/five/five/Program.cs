using System;

namespace five
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write distance in cantimetres : ");
            string distanceString = Console.ReadLine();
            int distanceDouble = Convert.ToInt32(distanceString);
            int countDistance = distanceDouble / 100;
            Console.WriteLine("Your distance in metres :" + countDistance);
        }
    }
}
