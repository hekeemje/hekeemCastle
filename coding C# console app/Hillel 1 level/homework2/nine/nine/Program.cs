using System;

namespace nine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write first number :");
            string firstNum = Console.ReadLine();
            Console.Write("Write second number :");
            string secondNum = Console.ReadLine();
            double sum = Convert.ToDouble(firstNum) + Convert.ToDouble(secondNum);
            double average = sum / 2;
            Console.WriteLine("Arithmetical mean = " + average);
        }
    }
}
