using System;
using System.ComponentModel;
using System.Net;

{
    class Program
    {
        static void Main(string[] args)
        {
            // ctrl + e + c(u)
            EnterData();
        }

        private static void EnterData()
        {
            int firstNum = 0;
            int secondNum = 0;
            char sign = ' ';

            try
            {
                Console.WriteLine("Enter first num:");
                firstNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second num:");
                secondNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter sign num:");
                sign = char.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong something.");
            }

            Calc(firstNum, secondNum, sign);
        }

        private static void Calc(int firstNum, int secondNum, char sign)
        {
            int res = 0;

            switch (sign)
            {
                case '+':
                    res = firstNum + secondNum;
                    break;
                case '-':
                    res = firstNum - secondNum;
                    break;
                case '*':
                    res = firstNum * secondNum;
                    break;
                case '/':
                    if (secondNum != 0)
                        res = firstNum / secondNum;
                    else
                        Console.WriteLine("you can't 0");
                    break;
                default:
                    Console.WriteLine("none");
                    break;
            }


            Print(res);
        }

        static void Print(int res)
        {
            Console.WriteLine(res);
        }
    }
}
