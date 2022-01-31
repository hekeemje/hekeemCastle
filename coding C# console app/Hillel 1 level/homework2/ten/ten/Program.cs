using System;

namespace ten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your number : ");
            string number = Console.ReadLine();
            double square = Convert.ToDouble(number) * Convert.ToDouble(number);
            Console.WriteLine("Square of this num = " + square);
        }
    }
}
