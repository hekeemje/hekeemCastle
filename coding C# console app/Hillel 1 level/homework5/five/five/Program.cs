using System;

namespace five
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// Дан двумерный массив. Вывести на экран: 
            /// а) все элементы третьей строки массива, начиная с последнего элемента этой строки; 
            /// б) все элементы k-го столбца массива, начиная с нижнего элемента этого столбца.

            int index1 = 5;
            int index2 = 5;
            Random random = new Random();

            int[,] arr = new int[index1, index2];

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    arr[i, j] = random.Next(1,21);
                    Console.Write(arr[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Выводим все элементы третьей строки задом наперёд : "); /// - a)

            for (int i = index2 - 1; i > -1; i--)
            {
                Console.Write(arr[2, i] + "\t");
            }
            try
            {
                Console.WriteLine("");
                Console.WriteLine("С какого столбца вывести числа начиная с нижнего элемента столбца? "); /// - b)
                Console.Write("Введи число от 1 до 5 : ");
                int numa = int.Parse(Console.ReadLine());

                for (int i = index1 - 1; i > -1; i--)
                {
                    Console.WriteLine(arr[i, numa - 1]);
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Something wrong.");
            }
        }
    }
}
