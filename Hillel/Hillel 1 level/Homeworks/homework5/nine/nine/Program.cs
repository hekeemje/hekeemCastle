
using System;
using System.Runtime.CompilerServices;

namespace nine
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Дан двумерный массив.Определить: 
            /// а) максимальный элемент массива; 
            /// б) минимальный элемент массива; 
            /// в) координаты минимального элемента массива. Если элементов с минимальным значением несколько, то должны быть найдены координаты самого нижнего и самого правого из них; 
            /// г) координаты максимального элемента массива. Если элементов с максимальным значением несколько, то должны быть найдены координаты самого верхнего и самого левого из них.

            int index1 = 6;
            int index2 = 5;
            Random random = new Random();

            int[,] arr = new int[index1, index2];

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    arr[i, j] = random.Next(1, 11);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int max = arr[0, 0];
            int min = arr[0, 0];
            int coord1 = 0; int coord2 = 0; int coord3 = 3; int coord4 = 0;

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        coord1 = i+1;
                        coord2 = j+1;
                    }

                    if (min >= arr[i, j])
                    {
                        min = arr[i, j];
                        coord3 = i+1;
                        coord4 = j+1;
                    }    
                }
                Console.WriteLine();
            }

            Console.WriteLine("Максимальный элемент в массиве : " + max);
            Console.WriteLine("Минимальный элемент в массиве  : " + min);
            Console.WriteLine("Координаты максмимального элемента массива : " + "Строка " + coord1 + " столбец " + coord2); //// ...координаты самого верхнего и самого левого из них.
            Console.WriteLine("Координаты минимального элемента массива : " + "Строка " + coord3 + " столбец " + coord4); //// ...координаты самого нижнего и самого правого из них; 
        }
    }
}
