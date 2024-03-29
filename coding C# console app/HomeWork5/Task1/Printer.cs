﻿using System;

namespace Task1
{
    class Printer
    {
        public ConsoleColor color = Console.ForegroundColor;

        public void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
        }
    }

    class Company : Printer
    {
        public Company()
        {
            color = ConsoleColor.Green;
        }
    }

    class Position : Company
    {
        public Position()
        {
            color = ConsoleColor.Blue;
        }
    }

    class NamePerson : Position
    {
        public NamePerson()
        {
            color = ConsoleColor.Red;
        }
    }

}