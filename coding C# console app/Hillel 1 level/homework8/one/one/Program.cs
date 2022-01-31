using System;
using System.Text;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дано слово. Вывести на экран его третий символ.
            Console.WriteLine("Дано слово. Вывести на экран его третий символ.");
            string str = "Hillel";
            Console.WriteLine(str);
            Console.WriteLine(str[2]);

            // Дано слово. Определить, одинаковы ли второй и четвертый символы в нем.
            Console.WriteLine("\nДано слово. Определить, одинаковы ли второй и четвертый символы в нем.");
            Console.WriteLine(str);
            Console.WriteLine(Equals(str[1], str[3]));

            // Дано название футбольного клуба. Напечатать его на экране "столбиком".
            Console.WriteLine("\nДано название футбольного клуба. Напечатать его на экране столбиком.");
            string str2 = "Tottenham";
            for (int i = 0; i < str2.Length ; i++)
            {
                Console.WriteLine(str2[i]);
            }

            // Дано слово s1.Получить слово s2, образованное нечетными буквами слова s1
            Console.WriteLine("\nДано слово s1.Получить слово s2, образованное нечетными буквами слова s1");
            string s1 = "programming";
            string s2 = " ";
            for (int i = 0; i < s1.Length; i++)
            {
                if (i % 2 != 0)
                {
                    s2 = s2 + s1[i];
                }
            }
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            // Дан текст. Сколько раз в нем встречается символ "+" и сколько раз символ "*"? 
            Console.WriteLine("\nДан текст. Сколько раз в нем встречается символ  +  и сколько раз символ  * ?");
            string str3 = "We* will* get 30 if we will do 10+15 and* + 5";
            Console.WriteLine(str3);
            int plus = 0;
            int star = 0;
            for (int i = 0; i < str3.Length; i++)
            {
                switch (str3[i]) { 
                    case '+':
                    plus++;
                    break;
                    case '*':
                    star++;
                    break;
                }
            }
            Console.WriteLine($"We have plus {plus} times and star {star} times");

            // Дано предложение. Все буквы е в нем заменить буквой и.
            Console.WriteLine("\nДано предложение. Все буквы е в нем заменить буквой и.");
            StringBuilder str4 = new StringBuilder();
            str4.Append("Есть у нас ежевика и перец.");
            Console.WriteLine(str4);
            for (int i = 0; i < str4.Length; i++)
            {
                switch (str4[i]) {
                    case 'е':
                        str4[i] = 'и';
                        break;
                }
            }
            Console.WriteLine(str4);

            // Дано предложение. Все пробелы в нем заменить символом "_". 
            Console.WriteLine("\nДано предложение. Все пробелы в нем заменить символом _.");
            StringBuilder str5 = new StringBuilder();
            str5.Append("В агенство по продажи мебели ищется продавец.");
            Console.WriteLine(str5);
            for (int i = 0; i < str5.Length; i++)
            {
                switch (str5[i])
                {
                    case ' ':
                        str5[i] = '_';
                        break;
                }
            }
            Console.WriteLine(str5);

            // Дан текст. Напечатать все имеющиеся в нем цифры. 
            Console.WriteLine("\nДан текст. Напечатать все имеющиеся в нем цифры. ");
            string str6 = "H3l10";
            Console.WriteLine(str6);
            for (int i = 0; i < str6.Length; i++)
            {
                if (char.IsDigit(str6[i]))
                {
                    Convert.ToInt32(str6[i].ToString());
                    Console.Write(str6[i]);
                }
            }

            // Дан текст, в котором имеются цифры. а) Найти их сумму. б) Найти максимальную цифру ????? 
            Console.WriteLine("\nДан текст, в котором имеются цифры. а) Найти их сумму. б) Найти максимальную цифру");
            string str7 = "На 3 минуте матча был забит гол игроком под номером 7, это его 4 гол в карьере.";
            Console.WriteLine(str7);
            int sum = 0;
            int max = 0;
            for (int i = 0; i < str7.Length; i++)
            {

                if (char.IsDigit(str7[i]))
                {
                    sum += str7[i] - '0';
                    if (max < str7[i] - '0')
                    {
                        max = str7[i] - '0';
                    }
                }
            }
            Console.WriteLine($"Сумма = {sum} , максимальное число {max}");

            // Составить программу, которая запрашивает название государства и его столицы, а затем выводит сообщение: 
            // "Столица государства ... — город ..." (на месте многоточий должны быть выведены соответствующие значения).  
            // Попробовать решить  с помощью массивов или/и swtich

            Console.WriteLine("\nСоставить программу, которая запрашивает название государства и его столицы, а затем выводит сообщение.");
            Console.WriteLine("Столица государства... — город... (на месте многоточий должны быть выведены соответствующие значения). ");
            int index = 4;
            string[] country = new string[index];
            string[] city = new string[index];
            Console.WriteLine("Введи название государства, а затем его столицу.");
            for (int i = 0; i < index; i++)
            {
                Console.Write("Государство : ");
                country[i] = Console.ReadLine();
                Console.Write("Столица : ");
                city[i] = Console.ReadLine();
            }
            Console.WriteLine("Спасибо.");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"Столица государства {country[i]} — город {city[i]} .");
            }

            // Даны три слова. Напечатать их общие буквы. Повторяющиеся буквы каждого слова не рассматривать.

            Console.WriteLine("\nДаны три слова. Напечатать их общие буквы. Повторяющиеся буквы каждого слова не рассматривать.");
            string str8 = "Programming";
            string str9 = "Telegram";
            string str10 = "Organic";
            string words = " ";
            Console.WriteLine($"Слово 1 : {str8} , Слово 2 : {str9} , Слово 3 : {str10}");
            for (int i = 0; i < str8.Length; i++)
            {
                for (int j = 0; j < str9.Length; j++)
                {
                    if (Equals(str8[i], str9[j]))
                    {
                        for (int q = 0; q < str10.Length; q++)
                        {
                            if (Equals(str9[j], str10[q]))
                            {
                                if (words.IndexOf(str10[q]) == -1)
                                { 
                                    words += str10[q]; 
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Общие буквы :{words}");

            // Дано предложение из 10 слов. Заполнить ими массив из 10 элементов.

            Console.WriteLine("\nДано предложение из 10 слов. Заполнить ими массив из 10 элементов.");
            string str11 = "Завтра утром мы пойдём в лес за грибами и ягодами.";
            string[] str12 = str11.Split(' ');
            Console.WriteLine($"3 индекс массива = {str12[3]}");

            //Дано предложение. Напечатать его в обратном порядке слов, например, предложение мама мыла раму должно быть напечатано в виде раму мыла мама. 

            Console.WriteLine("\nДано предложение. Напечатать его в обратном порядке слов, например, предложение мама мыла раму должно быть напечатано в виде раму мыла мама.");
            string str13 = "мама мыла раму";
            Console.WriteLine(str13);
            string[] str14 = str13.Split(' ');
            for (int i = str14.Length - 1; i > -1; i--)
            {
                Console.Write($"{str14[i]} ");
            }

            // Дано предложение. Определить: а) количество слов, начинающихся с буквы н; б) количество слов, оканчивающихся буквой р.
            Console.WriteLine();
            Console.WriteLine("\nДано предложение. Определить: а) количество слов, начинающихся с буквы н; б) количество слов, оканчивающихся буквой р.");

            string str15 = "Через 10 наносекунд мы нашли калькулятор который начинал работать как вентилятор .";
            Console.WriteLine(str15);
            string[] str16 = str15.Split(' ');
            int countn = 0;
            int countrr = 0;
            
            for (int i = 0; i < str16.Length; i++)
            {
                if (str16[i].StartsWith("н"))
                {
                    countn++;
                }
                if (str16[i].EndsWith("р"))
                {
                    countrr++;
                }
            }

            Console.WriteLine($"Количество слов начинающихся с буквы н  = {countn}, оканчиваюшихся буквой р = {countrr}");
        }
    }
}
