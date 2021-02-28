using System;

namespace eight
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////Дано целое число в диапазоне 20–69, определяющее возраст (в годах). 
            ///Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год», например: 20 — «двадцать лет», 
            ///32 — «тридцать два года», 41 — «сорок один год»

            try
            {
                Console.WriteLine("Write any age ( from 20 to 69) :");
                int age = int.Parse(Console.ReadLine());
                int check = age % 10;

                if (age > 19 && age < 70)
                {
                    switch (check)
                    {
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            Console.WriteLine("Ваш возраст : " + age + " лет.");
                            break;
                        case 1:
                            Console.WriteLine("Ваш возраст : " + age + " год");
                            break;
                        case 2:
                        case 3:
                        case 4:
                            Console.WriteLine("Ваш возраст : " + age + " года");
                            break;
                        default:
                            Console.WriteLine("wrong age");
                            break;
                    }
                }
                else
                    Console.WriteLine("Wrong age.");
            }

            catch (Exception)
            {
                Console.WriteLine("Wrong age.");
            }
        }
    }
}
