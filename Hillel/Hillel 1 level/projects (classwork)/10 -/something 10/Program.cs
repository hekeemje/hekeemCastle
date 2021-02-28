using System;

namespace something_10
{
    class Program
    {
        static void Swap(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday = 200, 
            Friday, // - 201 
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine((int)DayOfWeek.Wednesday);

            // Console.WriteLine(Environment.SpecialFolder.CommonApplicationData);

            Console.WriteLine(GetSpecialFolderPath(Environment.SpecialFolder.ApplicationData));

            int a = 5;
            int b = 9;
            Console.WriteLine($"{a} , {b}");
            Swap(ref a, ref b);
            
            Console.WriteLine($"{a} , {b}");

            int i = 9;
            IncrementVar(i); // ref i; так же есть out где i будет пересоздаваться в методе
            Console.WriteLine(i);

            int answer;
            int.TryParse("5", out answer); // TryParse чтобы ловить Exception

            int ii;
            myTryParse(out ii, "5");
            myTryParse(out ii, "q");



            Console.WriteLine(ManyParams(5, 7, 9, 8));

            string str = "5 4 7 56";

            string[] ch = str.Split(); // числа разобьет и запишет в массив
            int[] arr = new int[ch.Length];
            for (int o = 0; o < arr.Length; o++)
            {
                arr[o] = Convert.ToInt32(ch[o]);
            }

            ManyParams(arr);

            Calc(5, 9.4f, 5); // перегрузка, выберет снизу ему лучший
        }
        /// <summary>
        /// Сумма двух аргументов
        /// </summary>
        /// <param name="v1">1 число </param>
        /// <param name="v2">2 число </param>
        private static void Calc(int v1, int v2)
        {
            Console.WriteLine(v1+v2);
        }

        private static void Calc(double v1, double v2)
        {
            Console.WriteLine(v1 + v2);
        }

        private static void Calc(float v1, float v2, int v3)
        {
            Console.WriteLine(v1 + v2 + v3);
        }

        static string GetSpecialFolderPath(Environment.SpecialFolder specialFolder)
        {
            return Environment.GetFolderPath(specialFolder);
        }

        static void IncrementVar(int i) // надо ref int i; так же есть out где i будет пересоздаваться в методе
        {
            i++;
        }

        static void myTryParse(out int ii, string answer, bool isException = false)
        {
            try
            {
                ii = int.Parse(answer);
                return;
            }
            catch (Exception ex)
            {
                isException = true;
                Console.WriteLine(ex.Message);
            }
            finally // выполнится в любое случае есть Exception или нет; нужен допустим при работе с базой данных чтобы точно закрыть поток
            {
                ii = 0;
            }
        }

        static int ManyParams(params int[] jj) // params - если заранее не знаешь сколько параметров нужно передать , и params должен стоять последним в передаваемых значениях
        {
            int sum = 0;
            for (int i = 0; i < jj.Length; i++)
            {
                sum += jj[i];
            }
            return sum;
        }
    }
}
