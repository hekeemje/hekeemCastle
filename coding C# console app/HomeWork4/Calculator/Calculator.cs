using System;

namespace Task4
{
    static class Calculator
    {
        public static void Plus(double firstNum, double secondNum)
        {
            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum+secondNum}");
        }

        public static void Minus(double firstNum, double secondNum)
        {
            Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
        }

        public static void Multiply(double firstNum, double secondNum)
        {
            Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
        }

        public static void Divide(double firstNum, double secondNum)
        {
            Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
        }
    }
}
