using System;
using System.Collections.Generic;
using System.Linq;

namespace justCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
    'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
    'w', 'x', 'y', 'z'};

            string ss = "The sunset sets at twelve o' clock.";
            ss = ss.ToLower();

            string myres = "";

            for (int i = 0; i < ss.Length; i++)
            {
                for (int j = 0; j  < alphabet.Length; j++)
                {
                    if (ss[i] == alphabet[j])
                    {
                        myres += j + 1;
                            myres += " ";
                    }
                }
            }


            Console.WriteLine(myres.Length);
            Console.WriteLine(myres);
        
        }
    }
}