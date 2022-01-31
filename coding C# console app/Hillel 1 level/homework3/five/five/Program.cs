using System;

namespace five
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////// Напишите программу, проверяющую число на четность.
            int num;

            try
            {
                Console.WriteLine("Enter any number : ");
                num = int.Parse(Console.ReadLine());

                num = num % 2;

                if (num > 0)
                {
                    Console.WriteLine("Your number нечетное число.");
                }

                else if (num == 0)
                {
                    Console.WriteLine("Your number четное число.");
                }
            }

            catch (Exception)
            { Console.WriteLine("You type something wrong."); }

        }
    }
}
