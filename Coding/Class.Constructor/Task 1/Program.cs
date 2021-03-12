using System;

namespace Task_1
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user1 = new User();
                Console.WriteLine("Type login of new user : ");
                user1.Login = Console.ReadLine();
                Console.WriteLine("First name : ");
                user1.Name = Console.ReadLine();
                Console.WriteLine("Last name : ");
                user1.Surname = Console.ReadLine();
                Console.WriteLine("Age : ");
                user1.Age = int.Parse(Console.ReadLine());
                user1.AccCreated = DateTime.Now;

                user1.Print();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}
