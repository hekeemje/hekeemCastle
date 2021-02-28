using System;
using System.Text;

namespace something_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str2 = "Hello";
            string str3 = string.Intern(Console.ReadLine()); // отправить в интернированую таблицу
            Console.WriteLine(ReferenceEquals(str2,str3));


            StringBuilder sb = new StringBuilder(); // изменяемая строка и занимает меньше памяти и быстрей
            sb.Append("Hello");
            StringBuilder sb2 = sb;
            Console.WriteLine(sb + " " + sb2);

            double pi = Math.PI;
            string str = string.Format("{0:0.00}" , pi);
            Console.WriteLine(str);

            string str33 = "Hel210sjj";
            for (int i = 0; i < str33.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    Convert.ToInt32(str[i].ToString());
                    Console.WriteLine(str33[i]); // выведет только цифры
                }
            }

            string str44 = new string('-', 20); // выводит 20 раз -

        }
    }
}
