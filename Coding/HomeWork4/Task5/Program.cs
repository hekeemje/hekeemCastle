using System;

namespace Task5
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 3, 7, 2, 9, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            arr.Sort();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
