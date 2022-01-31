using System;

namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// Дан двумерный массив. Определить: а) сумму всех элементов третьей строки массива; б) сумму всех элементов s-го столбца массива.

            int index1 = 5;
            int index2 = 5;
            int[,] arr = new int[index1, index2];
            Random random = new Random();

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    arr[i, j] = random.Next(1, 31);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма элементов третьей строки.");

            int sum = 0;

            for (int i = 0; i < index2; i++)
            {
                sum += arr[2, i];
            }
            Console.WriteLine(sum);

            int s = 3;
            Console.WriteLine("Сумма всех элементов " + s + " столбца массива.");

            sum = 0;
            for (int i = 0; i < index1; i++)
            {
                sum += arr[i, s-1];
            }

            Console.WriteLine(sum);
        }
    }
}
