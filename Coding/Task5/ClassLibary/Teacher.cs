using System.Collections.Generic;

namespace ClassLibary
{
    public class Teacher : Student
    {
        List<Student> students = new List<Student>();

        public override void Print()
        {

        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return true;
        }

        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }
    }
}
