using System;

namespace Task2
{
    class ClassRoom
    {
        public ClassRoom()
        { 
        
        }
    }

    class Pupil : ClassRoom
    {
        public string Name { get; set; }
        public Pupil(string name)
        {
            Name = name;
        }

        public virtual void Study()
        { }

        public virtual void Read()
        { }

        public virtual void Write()
        { }

        public virtual void Relax()
        { }

        class ExcelentPupil : Pupil
        {
            public ExcelentPupil(string name)
                :base(name)
            { 
            
            }


            
        }

        class GoodPupil : Pupil
        {
            public GoodPupil(string name)
                : base(name)
            {

            }
        }

        class BadPupil : Pupil
        {
            public BadPupil(string name)
                : base(name)
            {

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
