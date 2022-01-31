using System;

namespace twelve
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
            string easy = three.ToString();
            string secondFirst = easy[1].ToString() + easy[0].ToString() + easy[2].ToString();
            Console.WriteLine(secondFirst);
        }
    }
}
