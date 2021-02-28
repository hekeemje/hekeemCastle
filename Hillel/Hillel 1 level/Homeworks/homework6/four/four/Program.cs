using System;

namespace four
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// Дан прямоугольный массив размером n x m. Поверните его на 90 градусов по часовой стрелке, записав результат в новый массив размером m x n.

            int n = 4;
            int m = 6;
            int[,] arr = new int[n, m];
            int[,] arr2 = new int[m, n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = random.Next(1, 21);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nПоворот на 90 градусов по часовой : \n");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr2[j,i] = arr[i,j];
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = n -1 ; j > -1; j--)
                {
                    Console.Write(arr[j, i] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
