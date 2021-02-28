using System;
using System.Collections.Generic;

namespace HomeWork2
{

    class Program
    {
        static void Main(string[] args)
        {

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker { Name = "Donald", Surname = "Trump" , Vacancy = "Dev", Joined = 2015 });
            workers.Add(new Worker { Name = "Barak", Surname = "Obama" , Vacancy = "HR", Joined = 2011 });
            workers.Add(new Worker { Name = "Joe", Surname = "Biden" , Vacancy = "Team lead", Joined = 2020 });

            Worker.InputInfo(ref workers); // Метод ввода нового сотрудника 
            Console.WriteLine("\n");
            Console.WriteLine("До сортировки : ");
            for (int i = 0; i < workers.Count; i++)
            {
                Console.WriteLine($"{workers[i].Name} | {workers[i].Surname} | {workers[i].Vacancy} | {workers[i].Joined}");
            }
            Worker.SortNames(ref workers); // Метод сортировки по фамилии
            Console.WriteLine("\n");
            Console.WriteLine("После сортировки : ");
            for (int i = 0; i < workers.Count; i++)
            {
                Console.WriteLine($"{workers[i].Name} | {workers[i].Surname} | {workers[i].Vacancy} | {workers[i].Joined}");
            }
            Console.WriteLine("\n");
            Worker.joinedOutput(ref workers); // Метод вывода по стажу
        }
    }
}
