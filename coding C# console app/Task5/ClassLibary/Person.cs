using System;

namespace ClassLibary
{
    

    public class Person
    {
        public string Name;

        public virtual void Print()
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
            throw new NotImplementedException();
        }


    }
}
