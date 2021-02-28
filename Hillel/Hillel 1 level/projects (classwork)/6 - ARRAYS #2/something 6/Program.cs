using System;
using System.Linq;
using System.Runtime.Versioning;

namespace something_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int index1 = 3;
            //int index2 = 3;
            //int[,] arr = new int[index1, index2];
            //Random random = new Random();

            //for (int i = 0; i < index1; i++)
            //{
            //    for (int j = 0; j < index2; j++)
            //    {
            //        arr[i, j] = random.Next(1, 1000);
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //////////////////////////////////////////////////////
            /////////// Используя рандом заполнить массив неповторяющимися числами.

            //int[] array = new int[20];
            //Random rnd = new Random();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rnd.Next(1, 21);

            //    for (int j = 0; j <= i; j++)
            //    {
            //        if (array[j] == array[i])
            //        {
            //            i--;
            //        }
            //    }
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            ////////////////////////////
            /// Отсортировать массив

            //int[] chh = new int[10];

            //for (int i = 0; i < chh.Length; i++)
            //{
            //    chh[i] = new Random().Next(1, 100);
            //    Console.Write(chh[i] + "\t");
            //}

            //Console.WriteLine();
            //Array.Sort(chh);

            //for (int i = 0; i < chh.Length; i++)
            //{
            //    Console.Write(chh[i] + "\t");
            //}

            //chh.Min();
            //chh.Max();

            int[][] jagArr = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                jagArr[i] = new int[4];
            }



        }
    }
}
