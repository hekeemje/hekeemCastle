using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace one7
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            string str = "привет";
            string yesno;
            StringBuilder strcheck = new StringBuilder();
            strcheck.Append("______");
            int rightorno = 0;
            int live = 6;
            StringBuilder guessed = new StringBuilder();
            guessed.Append("");
            Console.WriteLine("Поиграем в игру в слова? <y/n> ");
            yesno = Console.ReadLine();
            var tolow = yesno?.ToLower();


            if (tolow == "y")
            {
                Console.WriteLine("\nУгадайте мое секретное слово.Оно содержит 6 букв, и вы можете угадывать одну букву за раз.");
                Console.WriteLine("Вам предоставляется 6 неправильных угадываний.\n");
                do
            {
                try
                {


                    Console.Write("Угадайте букву : ");
                    char answer = char.Parse(Console.ReadLine());

                    for (int i = 0; i < str.Length; i++)
                    {
                        if (answer == str[i])
                        {
                            Console.WriteLine("Правильно.");
                            strcheck[i] = answer;
                            Console.WriteLine("Ваше слово :" + strcheck);
                                if (str == strcheck.ToString())
                                {
                                    goto win;
                                }
                            Console.WriteLine("Неправильные варианты : " + guessed);
                            rightorno = 1;
                        }
                    }

                    if (rightorno == 0)
                    {
                        Console.WriteLine("Неправильно.");
                        Console.WriteLine("Ваше слово : " + strcheck);
                        guessed.Append($" {answer},");
                        Console.WriteLine("Неправильные варианты :" + guessed);
                        live--;
                    }

                    Console.WriteLine(live + " неправильных вариантов осталось.");
                    rightorno = 0;
                    Console.WriteLine("Нажми enter чтобы перейти к след. раунду.");
                    Console.ReadLine();
                    Console.Clear();

                }

                catch (Exception)
                {
                    Console.WriteLine("Ты ввёл неправильную букву. Попробуй ещё раз.");
                }
            } while (live > 0);

            }

            if (yesno == "n")
            {
                Console.WriteLine("Не хочешь играть? Пока.");
            }
            
            // else Console.WriteLine("Ты ввёл неправильную букву. Перезапусти програму.");

            if (live == 0)
            { 
                Console.WriteLine("К сожалению твои попытки истекли. Проигрыш."); 
            }
        win:
            {
                if(str == strcheck.ToString())
                {
                Console.WriteLine("Угадано!");
                Console.Write("Играем еще? < y / n > : ");
                yesno = Console.ReadLine();
                if (yesno == "n")
                {
                    Console.WriteLine("Удачи.");
                }
                if (yesno == "y")
                {
                    goto start;
                }
                }
            }
        }
    }
}
