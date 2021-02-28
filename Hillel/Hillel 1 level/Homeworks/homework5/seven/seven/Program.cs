using System;
using System.Diagnostics.CodeAnalysis;

namespace seven
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Дан двумерный массив.Определить: а) сумму всех элементов второго столбца массива; б) сумму всех элементов k-й строки массива.

            int index1 = 6;
            int index2 = 7;
            Random random = new Random();

            int[,] arr = new int[index1,index2];

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    arr[i, j] = random.Next(1,21);
                    Console.Write(arr[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма всех элементов второго столбца : ");

            int sum = 0;

            for (int i = 0; i < index1; i++)
            {
                sum += arr[i, 1];
            }

            Console.WriteLine(sum);

            sum = 0;
            int k = 4;
            Console.WriteLine("Сумма элементов " + k + " строки массива");

            for (int i = 0; i < index2; i++)
            {
                sum += arr[k - 1, i];
            }

            Console.WriteLine(sum);
        }
    }
}
