using System;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////// Найти сумму целых положительных чисел из промежутка от a до b, кратных четырем.
            try
            {
                Console.WriteLine("Write number A :");
                int numa = int.Parse(Console.ReadLine());
                Console.WriteLine("Write number A :");
                int numb = int.Parse(Console.ReadLine());

                if (numa > numb)
                {
                    int temp = numa;
                    numa = numb;
                    numb = temp;
                }


                int summa = 0;
                for (int i = numa; i <= numb; i++)
                {
                    summa += (i > 0 && i % 4 == 0) ? i : 0; ///// условие ? true : false; 
                }

                Console.WriteLine("Summa = " + summa);
            }

            catch (Exception)
            {
                Console.WriteLine("You type something wrong.");
            }

        }
    }
}
