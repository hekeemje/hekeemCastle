using System;
using System.Collections.Generic;
using System.Linq;

namespace justCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Kek lol cheburek";
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}