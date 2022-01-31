using System;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            //////// Дан двумерный массив. а) Вывести на экран элемент, расположенный в правом верхнем углу массива. б) Вывести на экран элемент, расположенный в левом нижнем углу массива.

            int index1 = 4;
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

            Console.WriteLine("Правый верхний угол : " + arr[0, index2-1]);
            Console.WriteLine("Левый нижний : " + arr[index1 - 1, 0]);

            
        }
    }
}
