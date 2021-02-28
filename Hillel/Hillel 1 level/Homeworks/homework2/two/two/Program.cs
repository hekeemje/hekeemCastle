using System;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, tell me please your full name. ");
            Console.Write("Your first name is : ");
            string firstName = Console.ReadLine();
            Console.Write("Your middle name is : ");
            string middleName = Console.ReadLine();
            Console.Write("Your last name is : ");
            string lastName = Console.ReadLine();
            Console.Write("How old are you ? ");
            string ageOfUser = Console.ReadLine();
            Console.Write("What is your education ? ");
            string educationOfUser = Console.ReadLine();
            Console.Write("Can you tell me please your place of life ? ");
            string placeOfLife = Console.ReadLine();
            Console.WriteLine("Thank you for information, we saved your information to our data base.");
            checkPoint:
            Console.WriteLine("If you want to check your full name write number '1' ");
            Console.WriteLine("If you want to check how old are you write number '2' ");
            Console.WriteLine("If you want to check your education write number '3' ");
            Console.WriteLine("If you want to check your living place write number '4' ");
            string checkInfoString = Console.ReadLine();
            try
            {
                int checkInfo = Convert.ToInt32(checkInfoString);
                while ((checkInfo > 4) | (checkInfo < 1))
                {
                    Console.Write("Wrong number. Write number from 1 to 4 : ");
                    checkInfo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
                if (checkInfo == 1)
                {
                    Console.WriteLine(">>>>> Your full name is : " + firstName + " " + middleName + " " + lastName + " <<<<<");
                }
                if (checkInfo == 2)
                {
                    Console.WriteLine(">>>>> Your age is " + ageOfUser + " years old." + " <<<<<");
                }
                if (checkInfo == 3)
                {
                    Console.WriteLine(">>>>> Your education is : " + educationOfUser + "." + " <<<<<");
                }
                if (checkInfo == 4)
                {
                    Console.WriteLine(">>>>> Your place of live : " + placeOfLife + "." + " <<<<<");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("You write something wrong, try again.");
            }
            goto checkPoint;
        }
    }
}
