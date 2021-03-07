using MyMathLib;

namespace _01_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.SetName("Ivan");
            //student1.Surname = "Ivanov";
            //student1.Age = 22;

            //Student student2 = new Student();

            //student2.Name = "Dima";
            //student2.Surname = "Dimov";
            //student2.Age = 19;
            

            student1.Print();

            //int res = MathOperation.Plus(2, 8);
            //Console.WriteLine(res);
        }
    }
}
