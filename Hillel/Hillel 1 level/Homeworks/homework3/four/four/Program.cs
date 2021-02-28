using System;
using System.Runtime.ExceptionServices;

namespace four
{
    class Program
    {
        static void Main(string[] args)
        {
            //////// Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить каждой переменной сумму этих значений, 
            //////// а если равны, то присвоить переменным нулевые значения. Вывести новые значения переменных A и B. 

            int num1, num2;

            try
            {
                Console.WriteLine("Enter first num:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second num:");
                num2 = int.Parse(Console.ReadLine());

                int sum = 0;
                if (num1 != num2)
                {
                    sum = num1 * num2;
                    num1 = sum;
                    num2 = sum;
                    Console.WriteLine("First number : " + num1);
                    Console.WriteLine("Second number : " + num2);
                }

                else if (num1 == num2)
                {
                    num1 = 0;
                    num2 = 0;
                    Console.WriteLine("First number : " + num1);
                    Console.WriteLine("Second number : " + num2);
                }

            }

            catch (Exception)
            { Console.WriteLine("You type something wrong."); }

        }
    }
}
