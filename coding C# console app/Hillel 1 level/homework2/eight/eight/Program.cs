using System;

namespace eight
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 73;
            int count10 = num / 10;
            Console.WriteLine("Число десятков в числе 73 = " + count10);
            int oneCount = num % 10;
            Console.WriteLine("Число единиц в числе 73 = " + oneCount);
            int sum = count10 + oneCount;
            Console.WriteLine("Сумма цифр числа = " + sum);
            int proizv = count10 * oneCount;
            Console.WriteLine("Произведение числа = " + proizv);
        }
    }
}
