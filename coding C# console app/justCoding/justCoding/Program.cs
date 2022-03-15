using System;
using System.Collections.Generic;
using System.Linq;

namespace justCoding
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, -7, 3, 5, -1, 1, 4, -5, 9, -2 };

            IEnumerable<int> negative =
                         from num in nums
                         where num < 0
                         select num;

            foreach (var item in negative)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            IEnumerable<int> positive =
                        from num in nums
                        where num >= 0
                        select num;

            foreach (var item in positive)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            var min = nums.Min();
            Console.WriteLine($"Min : {min}");

            var max = nums.Max();
            Console.WriteLine($"Max : {max}");

            var sum = nums.Sum();
            Console.WriteLine($"Sum : {sum}");

            var avg = nums.Average();
            Console.WriteLine($"Average : {avg}");
            var where = nums.Where(p => p <= avg).Max();
            Console.WriteLine($"First Large : {where}");

            var first = nums.First();

            var orderedNumbers = from num in nums
                                 orderby num
                                 select num;

            foreach (var item in orderedNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}