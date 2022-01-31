using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Workers[] Company1 = new Workers[] { new WorkersFixSalary("Donald", 3000),
                new WorkersHourSalary("Joe", 24),
                new WorkersHourSalary("Barak", 30),
                new WorkersFixSalary("Josh", 2500),
                new WorkersHourSalary("Angela", 27),
                new WorkersFixSalary("Emanuel", 2750)
            };
            Console.WriteLine("Before sort :");

            foreach (var item in Company1)
            {
                Console.WriteLine($"{item.Name} - {item.AverageSalary}");
            }

            Array.Sort(Company1);

            Console.WriteLine("\nAfter sort :");

            foreach (var item in Company1)
            {
                Console.WriteLine($"{item.Name} - {item.AverageSalary}");
            }
        }
    }
}
