using System;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// Дан квадратный массив. Поменяйте местами элементы, стоящие на главной и побочной диагонали, 
            ///при этом каждый элемент должен остаться в том же столбце 
            ///(то есть в каждом столбце нужно поменять местами элемент на главной диагонали и на побочной диагонали).

            int index = 8;
            int[,] arr = new int[index, index];
            Random random = new Random();

            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < index; j++)
                {
                    arr[i, j] = random.Next(1, 21);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int temp = arr[0, 0];

            //b = a[i][j];
            //a[i][j] = a[i][N - 1 - j];
            //a[i][N - 1 - j] = b;

            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < index; j++)
                {
                    if (i == j)
                    {
                        temp = arr[i, j];
                        arr[i, j] = arr[i,index - 1 - j];
                        arr[i, index - 1 - j] = temp;
                    }
                }
            }

            Console.WriteLine("\n Перестановка : \n");

            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < index; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
