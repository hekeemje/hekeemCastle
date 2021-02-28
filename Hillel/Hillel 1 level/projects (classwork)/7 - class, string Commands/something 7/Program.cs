using System;
using System.Linq;

namespace something_7
{
    class myClass
    {
        public int i;
    }


    class Program
    {
        static void Main(string[] args)
        {
            //// Value type - типы значений 
            /// Stack - 1mb
            /// LastInFirstOut (LIFO) 
            //// - int, -double, -decimal , char, bool, struct 

            //// Reference types - ссылочные типы
            /// Managed heap - управляемая куча
            //// string, random, Math

            myClass myClass = new myClass();
            myClass.i = 7;

            myClass my = new myClass();
            my = myClass;

            Console.WriteLine($"myClass.i = {myClass.i} , my.i = {my.i}");
            my.i = 5;
            Console.WriteLine($"myClass.i = {myClass.i} , my.i = {my.i}");
            ////////// Ссылочные типы влияют друг на друга


            string str;
            string str2 = null;
            string str3 = "";
            string str4 = string.Empty;

            string path = "C:\\Program Files";
            string path2 = @"C:\Program Flies";

            var str5 = "sadasd";

            string str6 = $"{5 + 5}";

            string concat = "Hello" + " " + "World";
            string concat2 = string.Concat(concat, "?");

            string[] arr = { "One", "Two", "Three" };

            string all = string.Join(',', arr);

            Console.WriteLine(all);

            string str11 = "H", str22 = "h";

            Console.WriteLine(string.Compare(str11,str22)); // -1 0 1

            Console.WriteLine(str11.Equals(str22, StringComparison.OrdinalIgnoreCase)); // true false 
            /// StringComparison.OrdinalIgnoreCase - игнорирует большие или маленькие это

            string strr = "Hello,world, !";

            strr = strr.Insert(strr.LastIndexOf('d') + 1, "!"); /// вставит после d символ !

            string[] arr1 = strr.Split(','); // разрежет в массив и будет Hello world ! 

            Console.WriteLine(strr.Trim('!')); // уберёт ! с Hello world , если пробел ( то убирает только по бокам )

            strr = strr.Substring(3, 5); /// с какого индекса вырезать и сколько букв вырезать

            strr = strr.Remove(0, 2); /// удаляет начиная с 0 индекса и удаляет 2 буквы

            strr = strr.Replace("World", "All!"); // Заменяет World на All

            Console.WriteLine("Введи что то");

            string user = Console.ReadLine();
        }
    }
}
