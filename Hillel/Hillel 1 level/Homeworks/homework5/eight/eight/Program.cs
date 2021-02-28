using System;

namespace eight
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Дан двумерный массив. Определить: а) сумму квадратов элементов второй строки массива; б) сумму квадратов элементов c-го столбца массива.

            int index1 = 6;
            int index2 = 5;
            Random random = new Random();

            int[,] arr = new int[index1, index2];

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    arr[i, j] = random.Next(1, 6);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма квадратов элементов второй строки массива : ");

            int sum = 0;

            for (int i = 0; i < index2; i++)
            {
                sum += arr[1, i] * arr[1, i];
            }

            Console.WriteLine(sum);

            sum = 0;
            int c = 3;
            Console.WriteLine("Сумма квадратов элементов " + c + " столбца массива");

            for (int i = 0; i < index1; i++)
            {
                sum += arr[i, c - 1] * arr[i, c - 1];
            }

            Console.WriteLine(sum);
        }
    }
}
