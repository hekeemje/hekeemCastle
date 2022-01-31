using System;
using System.Collections.Generic;
using System.Linq;

namespace _01HomeWorkCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите выражение: ");
                string text = Console.ReadLine();
                //string text = string.Join("", args); - если хотим через Main консоль считывать
                List<char> symbols = SymbolFinder(text);
                string[] nums = text.Split('*', '/', '+', '-');
                List<double> numbers = FindNum(nums);
                Console.WriteLine($"Результат: {Prioritets(symbols, numbers)}");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static List<double> FindNum(string[] nums)
        {
            List<double> numbers = new List<double>();
            for (int i = 0; i < nums.Length; i++)
            {
                numbers.Add(Convert.ToDouble(nums[i]));
            }

            return numbers;
        }

        private static List<char> SymbolFinder(string text)
        {
            List<char> symbols = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        symbols.Add(text[i]);
                        break;
                }
            }
            return symbols;
        }

        private static double Prioritets(List<char> symbols, List<double> numbers)
        {
            char[] supportedOperators = { '*', '/', '+', '-' };
            int[] priorities = { 0, 0, 1, 1 };
            foreach (int priority in priorities.Distinct())
            {
                List<char> operators = new List<char>();
                for (int i = 0; i < priorities.Length; i++)
                {
                    if (priorities[i] == priority)
                        operators.Add(supportedOperators[i]);
                }
                for (int i = 0; i < symbols.Count; i++)
                {
                    if (operators.Contains(symbols[i]))
                    {
                        numbers[i] = Calculate(numbers[i], numbers[i + 1],symbols[i]);
                        numbers.RemoveAt(i + 1);
                        symbols.RemoveAt(i);
                        i--;
                    }
                }

            }
            return numbers[0];
        }



        private static double Calculate(double left, double right, char op)
        {
            double num = 0;
            switch (op)
            {
                case '/':
                    num = left / right;
                    break;
                case '*':
                    num = left * right;
                    break;
                case '+':
                    num = left + right;
                    break;
                case '-':
                    num = left - right;
                    break;
            }
            return num;
        }
    }
}
