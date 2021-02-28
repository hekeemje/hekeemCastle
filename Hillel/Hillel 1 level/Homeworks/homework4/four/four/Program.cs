using System;
using System.ComponentModel.DataAnnotations;

namespace four
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// Даны натуральное число n и вещественные числа Найти: 
            ///а) максимальное из вещественных чисел; 
            ///б) минимальное из вещественных чисел; 
            ///в) максимальное и минимальное из вещественных чисел. Примечание В задаче (в) использовать только один оператор цикла

            int num = 5;
            double[] veshestv = new double[] { 5.37 , -3.72 , 8.88 , 1.23 , -2.28 };
            double max = veshestv[0];
            double min = veshestv[0]; //// Присвоил не "0" потому что вдруг все числа меньше больше нуля , значит выведет число 0 хотя его нету в массиве 

            for (int i = 0; i < 5; i++)
            {
                if (veshestv[i] > max)
                {
                    max = veshestv[i];
                }
            }

            Console.WriteLine("Максимальное из вещественных чисел : " + max); ///а) максимальное из вещественных чисел; 

            for (int i = 0; i < 5; i++)
            {
                if (veshestv[i] < min)
                {
                    min = veshestv[i];
                }
            }

            Console.WriteLine("Минимальное из вещественных чисел : " + min); ///б) минимальное из вещественных чисел; 

            double max2 = veshestv[0];
            double min2 = veshestv[0];

            for (int i = 0; i < 5; i++) ///в) максимальное и минимальное из вещественных чисел. Примечание В задаче (в) использовать только один оператор цикла
            {
                if (veshestv[i] < min2)
                {
                    min2 = veshestv[i];
                }
                if (veshestv[i] > max2)
                {
                    max2 = veshestv[i];
                }
            }

            Console.WriteLine("Максимальное : " + max2); 
            Console.WriteLine("Минимальное : " + min2);
        }
    }
}
