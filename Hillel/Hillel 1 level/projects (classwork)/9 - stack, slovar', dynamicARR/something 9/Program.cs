using System;
using System.Collections.Generic;

namespace something_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int index = int.Parse(Console.ReadLine());

            // int[] ints = new int[2];

            // Array.Resize(ref ints, 5); // изменить размер массива на 5


            List<int> ints = new List<int>(); // - СОЗДАТЬ динамик массив 
            // Console.WriteLine(ints.Count); - сколько пока индексов 
            ints.Add(1);
            ints.Add(2);
            ints.Add(4);
            ints.Add(5);
            ints.Insert(2, 3); // вставляет в индекс 2 значение 3 , но не заменяет индекс два, а смещает всё вниз 
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            LinkedList<int> lList = new LinkedList<int>();

            Stack<int> stack = new Stack<int>();
            stack.Push(1); // положили в стэк
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.Pop(); // достали со стэка ( начиная с последнего ) 
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Dictionary<string, string> ruToEng = new Dictionary<string, string>(); // словарь  , нельзя одно и тот же ключ 
            ruToEng.Add("Мама", "Mother");
            ruToEng.Add("Папа", "Father");
            ruToEng.Add("Сын", "Son");

            Console.WriteLine(ruToEng["Папа"]); 
        }
    }
}
