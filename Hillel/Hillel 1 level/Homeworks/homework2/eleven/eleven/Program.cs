using System;
using System.Globalization;

namespace eleven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your three-digit number : ");
            string threeDigit = Console.ReadLine();
            int three = Convert.ToInt32(threeDigit);
            while ((three > 999) | (three < 100))
            {
                Console.Write("Wrong number. Write number from 100 to 999 : ");
                three = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            string reverse = three.ToString();
            string backToFront = reverse[2].ToString() + reverse[1].ToString() + reverse[0].ToString();
            Console.WriteLine(backToFront);
        }
    }
}
