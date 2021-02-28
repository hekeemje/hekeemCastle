using System;
using System.Diagnostics.CodeAnalysis;

namespace something_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lll = 5;
            while (lll < 10)
            {
                Console.WriteLine("lol");
                lll++;
            }

            //////////////////

            double jjj = 7;
            int nnn = 9;


            int iii = 1;
            while (iii <= nnn)
            {
                Console.WriteLine(iii + "x" + jjj + " = " + iii * jjj);
                Console.WriteLine("{0} x {1} = {2}", iii, jjj, iii * jjj);
                Console.WriteLine($"{iii} x {jjj} = {iii * jjj}");
            }

            //////////////////

            int N = 123456789;
            int counter = 0;
            int sum = 0;

            while (N > 0)
            {
                counter++;
                sum += N % 10;
                N /= 10;
            }


            ////////////////// 

            do
            {
                counter++;
                sum += N % 10;
                N /= 10;
            } while (N > 0);

            ////////////////

            for (int i = 5; i < 10; i++)
            {

            }

            ///////////////

            Random random = new Random();

            for (; ; )
            {
                var t = random.Next(1, 10);
                if (t == 5)
                {
                    break;
                }
                Console.WriteLine(t + " ");

            }

            //////////

            for (int i = 0, j = 100; i < 10 && j > 10; i++, j--)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i + " ");
            }

            //////////

            bool isLoopOut = false;

            if (!isLoopOut)
            {
                isLoopOut = true;
            }
        }
    }
}
