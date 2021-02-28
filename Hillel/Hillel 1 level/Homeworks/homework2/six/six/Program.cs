using System;

namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have 234 days. Lets count how many full weeks it is.");
            int days = 234;
            int weeks = days / 7;
            Console.WriteLine("234 days its " + weeks + " full weeks.");
        }
    }
}
