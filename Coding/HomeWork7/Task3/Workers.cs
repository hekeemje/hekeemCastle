using System;
using System.Collections.Generic;

namespace Task3
{
    abstract class Workers : IComparable
    {
        public string Name { get; set; }
        public double AverageSalary { get; set; }

        public Workers(string name)
        {
            Name = name;
        }

        public abstract double CountSalary(double rate);

        public int CompareTo(object o)
        {
            Workers p = o as Workers;
            if (p != null)
                return this.AverageSalary.CompareTo(p.AverageSalary);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
