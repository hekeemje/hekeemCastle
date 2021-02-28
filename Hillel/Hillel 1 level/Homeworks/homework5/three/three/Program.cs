using System;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Составить программу: а) заменяющую значение любого элемента пятой строки двумерного массива числом 1949;
            /// б) заменяющую значение любого элемента двумерного массива числом a.

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

            try
            {
                int num = 1949;
                Console.WriteLine("Какой по счету элемент из пятой строки ты хочешь заменить на число 1949 ?");
                Console.WriteLine("Введи число от " + 1 + " до " + index1);
                int choice = int.Parse(Console.ReadLine());
                if (choice >= 0 && choice <= index1)
                {
                    arr[4, choice - 1] = num;
                }

                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Теперь заменим любое число в массиве твоим.");
                Console.WriteLine("Введи своё число.");
                int numa = int.Parse(Console.ReadLine());
                Console.WriteLine("Выбери строку.");
                Console.WriteLine("Введи число от " + 1 + " до " + index1);
                int choice22 = int.Parse(Console.ReadLine());
                Console.WriteLine("Выбери строку.");
                Console.WriteLine("Введи число от " + 1 + " до " + index1);
                int choice33 = int.Parse(Console.ReadLine());
                if (choice22 >= 0 && choice22 <= index1 | choice33 >= 0 && choice33 <= index1)
                {
                    arr[choice22 - 1, choice33 - 1] = numa;
                }

                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong.");
            }
        }
    }
}
