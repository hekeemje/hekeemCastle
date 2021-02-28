using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет, введи свой возраст и нажми enter. ");
            double ageOfUser = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Твой возраст на планете Земля : " + ageOfUser + " лет.");
            double secondInYears = ageOfUser * 31557600;
            Console.WriteLine("Твой возраст в секундах равняется : " + secondInYears + " секунд.");
            double Merc = 0.2408467 * secondInYears / 31557600; 
            double Venera = 0.61519726 * secondInYears / 31557600;
            double Mars = 1.8808158 * secondInYears / 31557600;
            double Yupiter = 11.862615 * secondInYears / 31557600;
            double Saturn = 29.447498 * secondInYears / 31557600;
            double Uran = 84.016846 * secondInYears / 31557600;
            double Neptun = 164.79132 * secondInYears / 31557600;
            Console.WriteLine("Твой возраст на планете Меркурий : " + Merc + " лет.");
            Console.WriteLine("Твой возраст на планете Венера : " + Venera + " лет.");
            Console.WriteLine("Твой возраст на планете Марс : " + Mars + " лет.");
            Console.WriteLine("Твой возраст на планете Юпитер : " + Yupiter + " лет.");
            Console.WriteLine("Твой возраст на планете Сатурн : " + Saturn + " лет.");
            Console.WriteLine("Твой возраст на планете Уран : " + Uran + " лет.");
            Console.WriteLine("Твой возраст на планете Нептун : " + Neptun + " лет.");

        }  
    }      
}          
           