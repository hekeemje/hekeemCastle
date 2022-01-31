using System;

namespace egiht
{
    class Program
    {
        static void Main(string[] args)
        {
            /////// Даны целые положительные числа A и B (A < B). 
            ///Вывести все целые числа от A до B включительно; при этом каждое число должно выводиться столько раз, 
            ///каково его значение (например, число 3 выводится 3 раза).

            int numa = 4;
            int numb = 11;

            for (int i = numa; i <= numb; i++)
            {

                
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
