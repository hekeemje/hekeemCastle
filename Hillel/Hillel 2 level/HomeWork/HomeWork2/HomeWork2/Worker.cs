using System;
using System.Collections.Generic;

namespace HomeWork2
{
    class Worker
    {
        public string Name; 
        public string Surname;
        public string Vacancy;
        public int Joined;


        public static void InputInfo(ref List<Worker> workers)
        {
            Console.WriteLine("Введи имя нового сотрудника.");
            string name = Console.ReadLine();
            Console.WriteLine("Введи фамилию нового сотрудника.");
            string surname = Console.ReadLine();
            Console.WriteLine("Введи вакансию нового сотрудника.");
            string vacancy = Console.ReadLine();
            Console.WriteLine("Введи дату присоединения нового сотрудника.");
            int joined = int.Parse(Console.ReadLine());
            workers.Add(new Worker { Name = name, Surname = surname, Vacancy = vacancy, Joined = joined });
        }

        public static void SortNames(ref List<Worker> workers)
        {
            workers.Sort((r, l) => r.Surname.CompareTo(l.Surname));
        }

        public static void joinedOutput(ref List<Worker> workers)
        {
            Console.WriteLine("Сотрудников выше какого стажа вывести на экран ? ( в годах ) ");
            Console.Write("Введите стаж сотрудника : ");
            int check2 = int.Parse(Console.ReadLine());
            int yearnow = DateTime.Now.Year;
            for (int i = 0; i < workers.Count; i++)
            {
                if (yearnow - workers[i].Joined >= check2)
                {
                    Console.WriteLine($"{workers[i].Name} | {workers[i].Surname} | {workers[i].Vacancy} | {workers[i].Joined}");
                }
            }
        }

    }
}
