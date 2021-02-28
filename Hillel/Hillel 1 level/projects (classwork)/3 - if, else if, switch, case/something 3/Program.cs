using System;

namespace something_3
{
    class Program
    {

        static void lolkek() { }

{        static void Main(string[] args)
        {
            int a = 9, b = 8, c = 4;

            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

            ///////

            Console.WriteLine("Your language ?");
            string lang = Console.ReadLine();
            lang = lang.ToLower();

            if (lang.Equals("ru", StringComparison.OrdinalIgnoreCase)) /// Сравнение строк с игнором больших букв и тд.
            {

            }

            switch (lang)
            {

                case "us-en":
                case "us-cn":
                    {
                        Console.WriteLine("EN");
                        break;
                    }
                case "ru":
                    {
                        Console.WriteLine("RU");
                        break;
                    }
                case "ua":
                    {
                        Console.WriteLine("UA");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("EN");
                        break;
                    }

            }

            lolkek();
            ///////
            ///
            int weekday = int.Parse(Console.ReadLine());
            switch (weekday)
            {
                case '1':
                    Console.WriteLine("Monday");
                    break;
                case '2':
                    Console.WriteLine("Tuesday");
                    break;
                case '3':
                    Console.WriteLine("Wednesday");
                    break; /// ...... 
                default:
                    Console.WriteLine("Something wrong.");
                    break;
            }
            ////////////////
            int monthnum = int.Parse(Console.ReadLine());
            if (monthnum == 12)
            {
                Console.WriteLine("winter");
            }
            if (monthnum > 0 && monthnum < 3)
            {
                Console.WriteLine("winter");
            }
            else if (monthnum > 2 && monthnum < 6)
            {
                Console.WriteLine("Spring");
            }
            else if (monthnum > 5 && monthnum < 9)
            {
                Console.WriteLine("summer");
            }
            else if (monthnum > 8 && monthnum < 12)
            {
                Console.WriteLine("autumn");
            }
            else
            {
                Console.WriteLine("something wrong");
            }
            //////////////////


            //// Робот может перемещаться в четырех направлениях («С» — север,  «З» — запад, «Ю» — юг, «В» — восток) 
            ///и принимать три цифровые команды: 0 — продолжать движение, 1 — поворот налево, –1 — поворот направо. 
            ///Дан символ C — исходное направление робота и целое число N — посланная ему команда. 
            ///Вывести направление робота после выполнения полученной команды.

            char C = char.Parse(Console.ReadLine());
            sbyte dir = sbyte.Parse(Console.ReadLine());

            switch (c)
            {
                case 'C':
                    {
                        switch (dir) //// мэйби сделать лучше метод чтобы дальше повторение кода не было 
                        {
                            case 0:
                                Console.WriteLine("sever");
                                break;
                            case 1:
                                Console.WriteLine("Zapad");
                                break;
                            case -1:
                                Console.WriteLine("Vostok");
                                break;
                            default:
                                Console.WriteLine("wrong way");
                                break;
                        }
                        break;
                    }
                case 'Z':

                    break;
                case 'Y':

                    break;
                case 'V':

                    break;
                default:
                    Console.WriteLine("daun?");
                    break;
            }
            /////
            /////
            ///

            int aka = 9, bebe = 0;

            string answer = (a > b) ? "a > b" : "a < b"; ///// условие ? true : false; 
        }
    }
}
