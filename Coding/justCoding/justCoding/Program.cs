using System;
using System.Collections.Generic;
using System.Linq;

namespace justCoding
{
    class Util
    {
        public void SwapGenericObjects<T, U>(ref T a, ref U b)
        {
            var temp = a;
            a = (T)(object)b;
            b = (U)(object)temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Util util = new Util();

            int a = 2; int b = 5;

            Console.WriteLine($"Before : a = {a} and b = {b}");
            util.SwapGenericObjects<int, int>(ref a, ref b);
            Console.WriteLine($"After : a = {a} and b = {b}");
        }
    }
}