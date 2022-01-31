using System;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            //////// Заполнить массив из 10 элементов случайными числами в интервале [-10..10]

            int[] arr = new int[10];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 11);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
