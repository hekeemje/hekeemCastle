using System;

namespace seven
{
    class Program
    {
        static void Main(string[] args)
        {
            /////// Робот может перемещаться в четырех направлениях («С» — север,  «З» — запад, «Ю» — юг, «В» — восток) 
            ///и принимать три цифровые команды: 0 — продолжать движение, 1 — поворот налево, –1 — поворот направо. 
            ///Дан символ C — исходное направление робота и целое число N — посланная ему команда. 
            ///Вывести направление робота после выполнения полученной команды.

            try
            {
                Console.WriteLine("In what position robot look now?");
                Console.WriteLine("«S» — sever,  «Z» — zapad, «Y» — yug, «V» — vostok");
                char c = char.Parse(Console.ReadLine());
                Console.WriteLine("What we need to do ?");
                Console.WriteLine("0 — продолжать движение, 1 — поворот налево, –1 — поворот направо. ");
                sbyte n = sbyte.Parse(Console.ReadLine());

                switch (c)
                {
                    case 'S':
                        {
                            switch (n)
                            {
                                case 0:
                                    Console.WriteLine("Sever.");
                                    break;
                                case 1:
                                    Console.WriteLine("Vostok.");
                                    break;
                                case -1:
                                    Console.WriteLine("Zapad.");
                                    break;
                                default:
                                    Console.WriteLine("Wrong way.");
                                    break;
                            }
                            break;
                        }
                    case 'Z':
                        {
                            switch (n)
                            {
                                case 0:
                                    Console.WriteLine("Zapad.");
                                    break;
                                case 1:
                                    Console.WriteLine("Sever.");
                                    break;
                                case -1:
                                    Console.WriteLine("Yug.");
                                    break;
                                default:
                                    Console.WriteLine("Wrong way.");
                                    break;
                            }
                            break;
                        }
                    case 'Y':
                        {
                            switch (n)
                            {
                                case 0:
                                    Console.WriteLine("Yug.");
                                    break;
                                case 1:
                                    Console.WriteLine("Zapad.");
                                    break;
                                case -1:
                                    Console.WriteLine("Vostok");
                                    break;
                                default:
                                    Console.WriteLine("Wrong way.");
                                    break;
                            }
                            break;
                        }
                    case 'V':
                        {
                            switch (n)
                            {
                                case 0:
                                    Console.WriteLine("Vostok.");
                                    break;
                                case 1:
                                    Console.WriteLine("Yug.");
                                    break;
                                case -1:
                                    Console.WriteLine("Sever.");
                                    break;
                                default:
                                    Console.WriteLine("Wrong way.");
                                    break;
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong position.");
                        break;
                }

            }

            catch (Exception)
            {
                Console.WriteLine("Error 404.");
            }
        }
    }
}
