using System;

namespace Task3.City
{
    partial class Program
    {

        static void Main(string[] args)
        {
            try
            {
            City city1 = new City();
            city1.SetInfo();
            Console.WriteLine(city1.Print());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
