using System;

namespace Seven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have some figure with size : 543 x 130 . Lets count how many squares 130 we can make.");
            int aFigure = 543;
            int bFigure = 130;
            int square = 130;
            if ( aFigure >= square ) //////// Проверяем чтобы размер квадрата который хотим отрезать был не больше одной из сторон. Затем большое значение фигуры делим на размет квадрата.
            {
                if (bFigure >= square)
                {
                    if (aFigure > bFigure)
                    {
                        int howManyTrue = aFigure / square;
                        Console.WriteLine("We can do " + howManyTrue + " squares.");
                    }
                    if (bFigure > aFigure)
                    {
                        int howManyTrue = aFigure / square;
                        Console.WriteLine("We can do " + howManyTrue + " squares.");
                    }
                    if (bFigure == aFigure)
                    {
                        int howManyTrue = aFigure / square;
                        Console.WriteLine("We can do " + howManyTrue + " squares.");
                    }
                }
                else
                Console.WriteLine("We can cut 0 squares.");
            }
            else
            {
                Console.WriteLine("We can cut 0 squares.");
            }
        }
    }
}
