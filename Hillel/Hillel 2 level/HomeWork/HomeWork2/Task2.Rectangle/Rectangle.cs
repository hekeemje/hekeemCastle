namespace Task2.Rectangle
{
    partial class Program
    {
        class Rectangle
        {
            public double side1, side2;

            public static double AreaCalculator(double first, double second)
            {

                return first*second;
            }

            public static double PerimeterCalculator(double first, double second)
            {

                return (first+second) * 2;
            }

            public double Area { get { return AreaCalculator(side1, side2); } }
            public double Perimeter { get { return PerimeterCalculator(side1, side2); } }

        }
    }
}
