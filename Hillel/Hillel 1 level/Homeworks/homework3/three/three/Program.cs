using System;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////// Даны три целых числа. Найти количество положительных и количество отрицательных чисел в исходном наборе. 
            int num1, num2, num3;

            try
            {
                Console.WriteLine("Enter first num:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second num:");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter third num:");
                num3 = int.Parse(Console.ReadLine());

                int positive = 0;
                int negative = 0;

                if (num1 > 0)
                { positive++; }

                if (num2 > 0)
                { positive++; }

                if (num3 > 0)
                { positive++; }

                Console.WriteLine("You have " + positive + " positive numbers");

                if (num1 < 0)
                { negative++; }

                if (num2 < 0)
                { negative++; }

                if (num3 < 0)
                { negative++; }

                Console.WriteLine("You have " + negative + " negative numbers");
            }

            catch (Exception)
            { Console.WriteLine("You type something wrong."); }

        }
    }
}
