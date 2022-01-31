using System;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// Найти сумму положительных нечетных чисел, меньших 50.

            int summa = 0;

            for (int i = 1; i < 50; i += 2)
                summa = summa + i;

            Console.WriteLine(summa);

        }
    }
}
