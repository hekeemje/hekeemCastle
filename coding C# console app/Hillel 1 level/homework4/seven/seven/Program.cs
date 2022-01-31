using System;

namespace seven
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1.2, 1.4, …, 2 кг конфет.

            double price = 3.37;
            Console.WriteLine("Цена за 1 кг конфет : " + price);
            double realprice;

            for (double i = 1.2; i <= 2; i += 0.2)
            {
                realprice = price * i;
                Console.WriteLine("Цена за " + i + " кг конфет = " + realprice); //// Почему вывод такой странный ?  
            }
        }
    }
}
