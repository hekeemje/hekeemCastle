using System;

namespace justCoding
{
    abstract class Person
    {
        private int name;

        public int Name { get { return name; }
            set { name = value; } }
    }

    class Worker : Person
    {
        private int position;

        public int Position
        {
            get { return position; }
            set { position = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}