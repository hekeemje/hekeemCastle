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

    class MyClass
    {
        public int field;

        public MyClass(int n)
        {
            field = n;
        }

        public override string ToString()
        {
            return $"Field = {field}";
        }

        public static implicit operator MyClass(int n)
        {
            return new MyClass(n);
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

            Show<MyClass>(400);
        }

        public static void Show<T>(T text)
        {
            Console.WriteLine(typeof(T).Name);
            Console.WriteLine(text);
        }
    }
}