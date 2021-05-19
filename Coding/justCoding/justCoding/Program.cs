using System;
using System.Collections.Generic;
using System.Linq;

namespace justCoding
{

    class Program
    {
        static void F4(Dictionary<int, string> keyValuePairs)
        { 
            foreach (var item in keyValuePairs)
                Console.WriteLine($"{item.Key} : {item.Value}");
        }

        public delegate void MyDicDel(Dictionary<int, string> keks);

        static void Main(string[] args)
        {
            Dictionary<int, string> kk1 = new Dictionary<int, string>();
            kk1.Add(1, "one");
            kk1.Add(2, "two");
            kk1.Add(3, "three");

            MyDicDel myDicDel = F4;
            myDicDel.Invoke(kk1);
        }

    }
}