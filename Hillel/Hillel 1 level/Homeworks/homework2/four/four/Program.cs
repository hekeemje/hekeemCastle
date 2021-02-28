using System;

namespace four
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 7;
            int secondNum = 9;
            Console.WriteLine("First Number is " + firstNum);
            Console.WriteLine("Second Number is " + secondNum);
            Console.WriteLine(">>> Swipe it <<<");
            int temp; //// Создаем временную переменую куда будем записывать одно значение из переменных и затем свайпать их
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("First Number is " + firstNum);
            Console.WriteLine("Second Number is " + secondNum);
            Console.WriteLine("            ");
            /////// Ниже без использования третьей временной переменной.
            int thirdNum = 7;
            int fourNum = 9;
            Console.WriteLine("Third Number is " + thirdNum);
            Console.WriteLine("Four Number is " + fourNum);
            Console.WriteLine(">>> Swipe it <<<");
            fourNum = thirdNum + fourNum;
            thirdNum = fourNum - thirdNum;
            fourNum = fourNum - thirdNum;
            Console.WriteLine("Third Number is " + thirdNum);
            Console.WriteLine("Four Number is " + fourNum);
            /////// Стоит ли так делать? Не знаю, первый способ с использованием третьей переменой выглядит куда проще) 
        }
    }
}
