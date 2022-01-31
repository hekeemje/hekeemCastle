using System;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Найдите индексы первого вхождения максимального элемента. Выведите два числа: номер строки и номер столбца, в которых стоит наибольший элемент в двумерном массиве. 
            /// Если таких элементов несколько, то выводится тот, у которого меньше номер строки, а если номера строк равны то тот, у которого меньше номер столбца.

            int index1 = 5;
            int index2 = 5;
            int[,] arr = new int[index1, index2];
            Random random = new Random();

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    arr[i, j] = random.Next(1, 21);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int max = arr[0,0];
            int maxi = 0;
            int maxj = 0;

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    if (max < arr[i,j])
                    {
                        max = arr[i, j];
                        maxi = i+1;
                        maxj = j+1;
                    }
                }
            }

            
            Console.WriteLine("Номер строки наибольшего элемента в массиве : " + maxi + " , номер столбца : " + maxj);

        }
    }
}
