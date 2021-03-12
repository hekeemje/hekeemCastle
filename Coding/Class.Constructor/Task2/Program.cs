using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Type first and last name of employee.");
                Console.Write("First name : ");
                string firstName = Console.ReadLine();
                Console.Write("Last name : ");
                string lastName = Console.ReadLine();
                Employee firstEmployee = new Employee(firstName, lastName);
                Console.Write("Position in company ( Junior, Middle, Senior, Team Lead ) ? : ");
                string position = Console.ReadLine();
                firstEmployee.Position = position.ToLower();
                Console.Write("How many years this employee work in company? ( 1 - 15 ) : ");
                int experience = int.Parse(Console.ReadLine());
                firstEmployee.Experience = experience;
                Console.WriteLine("Salary = " + firstEmployee.Salary(firstEmployee.Position, firstEmployee.Experience) + "$");
                Console.WriteLine("Taxes = " + Math.Round(firstEmployee.Taxes(firstEmployee.Salary(firstEmployee.Position, firstEmployee.Experience)),2) + "$");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}
