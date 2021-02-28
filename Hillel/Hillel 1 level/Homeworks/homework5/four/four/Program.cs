using System;
using System.Threading;

namespace four
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// Заполнить двумерный массив результатами таблицы умножения 
            /// (в первой строке должны быть записаны произведения каждого из чисел от 1 до 9 на 1, во второй — на 2, ..., в последней — на 9).

            int index1 = 10;
            int index2 = 10;
            int numa = 1; int numb = 1;
            int[,] arr = new int[index1,index2];

            for (int i = 0; i < index1 - 1; i++)
            {
                for (int j = 0; j < index2 -1; j++)
                {
                    arr[i, j] = numa * numb;
                    numb++;
                    Console.Write(arr[i, j] + " ");
                }
                numa++;
                numb = 1;
                Console.WriteLine();
            }

        }
    }
}
