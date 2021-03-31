using System;
using System.Collections.Generic;

namespace ClassLibary
{
    public class Student : Person 
    {
        StudentWithAdvisor teacher;

        public int Grade
        {
            get { return Grade; }
            set
            {
                if (value > 0 && value <= 11)
                {
                    Grade = value;
                }
                else Console.WriteLine("School have grade only from 0 to 11.");
            }
        }

        public override void Print()
        {

        }

        public override string ToString()
        {
            return $"{Name} teach in {Grade} grade";
        }

        public override bool Equals(object obj)
        {
            return true;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
