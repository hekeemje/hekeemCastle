using System;

namespace Task2
{
    class ClassRoom
    {
        Pupil pupil1;
        Pupil pupil2;
        Pupil pupil3;
        Pupil pupil4;

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            this.pupil4 = pupil4;
        }


    }

    class Pupil : ClassRoom
    {
        private string name { get { return name; } set { name = value; } }

        public Pupil(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4, string name)
            :  base(pupil1, pupil2, pupil3, pupil4)
        {
            this.name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pupil pupil1 = new Pupil()

            ClassRoom class1 = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        }
    }
}
