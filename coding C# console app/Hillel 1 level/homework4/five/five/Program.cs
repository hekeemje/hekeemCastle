using System;

namespace five
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// Даны два целых числа A и B (A < B). Найти сумму и произведение всех целых чисел от A до B включительно.

            int numa = 3;
            int numb = 9;
            int sum = 0;
            int proizv = 1;

            for (int i = numa; i <= numb; i++)
            {
                sum += i;
                proizv = proizv * i;
            }

            Console.WriteLine("Сумма всех чисел от " + numa + " до " + numb + " = " + sum);
            Console.WriteLine("Произведение всех чисел от " + numa + " до " + numb + " = " + proizv);
        }
    }
}
