using System;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// Дано целое число. Если оно является положительным, то прибавить к нему 1; если отрицательным, то вычесть из него 2; 
            ////// если нулевым, то заменить его на 10. Вывести полученное число.

            int num;
            try
            {
                Console.WriteLine("write any number : ");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    num++;
                    Console.WriteLine(num);
                }

                else if (num < 0)
                {
                    num = num - 2;
                    Console.WriteLine(num);
                }

                else if (num == 0)
                {
                    num = 10;
                    Console.WriteLine(num);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You type something wrong.");
            }
        }
    }
}
