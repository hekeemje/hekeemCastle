using System;

namespace Task2.Rectangle
{
    partial class Program
    {

        static void Main(string[] args)
        {
            try
            {      
            Rectangle first = new Rectangle();
            Console.WriteLine("Введите первую сторону прямоугольника в сантиметрах.");
            first.side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника в сантиметрах.");
            first.side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Периметр прямоугольника : ");
            Console.WriteLine(first.Perimeter);
            Console.WriteLine("Площадь прямоугольника : ");
            Console.WriteLine(first.Area);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
