using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace something_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "asdasdasdasdasdasd";

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

            foreach (var i in str)
            {
                Console.WriteLine(i);
            }

            /////////////

            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    Console.Write($"{i} x {j} = {i * j}\t");
                }
                Console.WriteLine();
            }

            /////////////

            int[] myArr = new int[3];

            myArr[0] = 9;

            int[] myArrSecond = { 5, 2, 9, 7 };

            int[] myArrThird = new int[] { 2, 3, 5 };

            int[] myArrTest = new int[500];

            for (int i = 0; i < myArr.Length; i++)
            {
                myArrTest[i] = i * 700;
            }

            ///////////////////

            int[] quest = new int[] { 37, 0, 50, 46, 34, 46, 0, 13 };

            for (int i = 0; i < quest.Length; i++)
            {
                Console.Write(quest[i] + " ");
            }

            Console.WriteLine();

            foreach (var item in quest)
            {
                Console.Write(quest + " ");
            }

            ////////////////////

            Random random = new Random();

            int[] height = new int[8];

            for (int i = 0; i < height.Length; i++)
            {
                height[i] = random.Next(163, 191); //// от 163 до 190
            }

            //////////////////

            int[] lolkek = new int[10];

            for (int i = 0; i < lolkek.Length; i++)
            {
                lolkek[i] = i + 1;
            }

            for (int i = 2; i < lolkek.Length; i += 2)
            {
                Console.WriteLine(lolkek[i]);
            }

            int[] jjj = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            for (int i = jjj.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(jjj[i]);
            }

            //////////////////

            int[] mass = new int[3];
            int sum = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"Please enter {i + 1}: ");
                mass[i] = int.Parse(Console.ReadLine());
                sum += mass[i];
            }

            Console.WriteLine("Sum : {0}", sum);

            ////////////////

            double[] arr = new double[20];
            double summ = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().NextDouble();
                summ = 1 / arr[i];
            }

            Console.WriteLine($"{summ:0.000}");

            ////////////////

            // Random random = new Random();

            int[] lolar = new int[100];
            int kek = 0;

            for (int i = 0; i < lolar.Length; i++)
            {
                lolar[i] = random.Next(-50, 50);

                kek += lolar[i];
            }

            /////////////////////////

            int[] zxc = new int[7];

            for (int i = 0; i < zxc.Length; i++)
            {
                zxc[i] = new Random().Next(0, 100);
                Console.Write($"{arr[i]}");
            }

            int temp = zxc[1];
            zxc[1] = zxc[4];
            zxc[4] = temp;
        }
    }
}
