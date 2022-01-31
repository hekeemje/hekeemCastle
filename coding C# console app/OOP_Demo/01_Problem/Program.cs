using MyMathLib;

namespace _01_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.SetName("Ivan");

            Student student2 = new Student();

            student2.Surname = "Vlad";
            System.Console.WriteLine(student2.Surname);
        }
    }
}
