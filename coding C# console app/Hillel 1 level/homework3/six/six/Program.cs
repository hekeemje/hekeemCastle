using System;

namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            //////// Единицы длины пронумерованы следующим образом: 1 — дециметр,  2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр. 
            //////// Дан номер единицы длины (целое число в диапазоне 1–5) и длина отрезка в этих единицах (вещественное число). 
            //////// Найти длину отрезка в метрах. 

            int num;
            char check;

            try
            {
                Console.WriteLine("Enter any distance : ");
                num = int.Parse(Console.ReadLine());

                Console.WriteLine("Type number which true for your distance : ");
                Console.WriteLine("1 - decimetr");
                Console.WriteLine("2 - kilometr");
                Console.WriteLine("3 - metr");
                Console.WriteLine("4 - milimetr");
                Console.WriteLine("5 - centimetr");
                check = char.Parse(Console.ReadLine());
                int sum;

                switch (check)

                {
                    case '1':
                        sum = num / 10;
                        Console.WriteLine(num + " decimetres = " + sum + " metres");
                        break;
                    case '2':
                        sum = num * 1000;
                        Console.WriteLine(num + " kilometres = " + sum + " metres");
                        break;
                    case '3':
                        Console.WriteLine(num + " metres = " + num + " metres");
                        break;
                    case '4':
                        sum = num / 1000;
                        Console.WriteLine(num + " milimetres = " + sum + " metres");
                        break;
                    case '5':
                        sum = num / 100;
                        Console.WriteLine(num + " centimetres = " + sum + " metres");
                        break;
                    default:
                        Console.WriteLine("Wrong type of distance.");
                        break;
                }

            }

            catch (Exception)
            { Console.WriteLine("You type something wrong."); }
        }
    }
}
