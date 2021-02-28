using System;

namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            /////// Даны два целых числа A и B (A < B). Вывести в порядке возрастания все целые числа, 
            ///расположенные между A и B (включая сами числа A и B),  а также количество N этих чисел.

            int numa = 2;
            int numb = 7;
            int count = 0;

            for (int i = numa; i <= numb; i++)
            {
                Console.WriteLine(i);
                count++;
            }

            Console.WriteLine("Количество чисел : " + count);
        }
    }
}
