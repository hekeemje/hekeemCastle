using System;

namespace something3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            i++;

            Console.WriteLine(++i); /// чтобы выводилось сразу с + 
            Console.WriteLine(i);

            Console.WriteLine(++i + i++);
            Console.WriteLine(i);

            int ccc = 5; int bbb = 7;
            bool kkk = ccc == bbb;
            Console.WriteLine(kkk); //// Сравнивание true и false

            int num = 5;
            int start = 0, finish = 10;
            bool result = num >= start & num <= finish; //// чтобы проверило число в диапазоне старта и финиша , & = И ;

            double stepen = Math.Pow(2, 8);
            Console.WriteLine(stepen); /// 2 возвели в 8 степень

            string str = "October";
            string answer = Console.ReadLine(); /// OctobeR
            string temp = answer.ToLower(); /// october
            Console.WriteLine(str.Equals(temp)); /// Сравнивает str єквивалентно ли к temp
        }
    }
}
