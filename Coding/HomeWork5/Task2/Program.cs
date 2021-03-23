using System;

namespace Task2
{
    class ClassRoom
    {
        Pupil pupil1, pupil2, pupil3, pupil4;

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
        }


        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            this.pupil4 = pupil4;
        }

        public void PrintInfo()
        {
            if (pupil1 != null)
            { Console.WriteLine($"Name of student : {pupil1.Name} .\n{pupil1.StudySkill}\n{pupil1.ReadingSkill}\n{pupil1.WritingSkill}\n{pupil1.RelaxingSkill}"); }
            if (pupil2 != null)
            { Console.WriteLine($"Name of student : {pupil2.Name} .\n{pupil2.StudySkill}\n{pupil2.ReadingSkill}\n{pupil2.WritingSkill}\n{pupil2.RelaxingSkill}"); }
            if (pupil3 != null)
            { Console.WriteLine($"Name of student : {pupil3.Name} .\n{pupil3.StudySkill}\n{pupil3.ReadingSkill}\n{pupil3.WritingSkill}\n{pupil3.RelaxingSkill}"); }
            if (pupil4 != null)
            { Console.WriteLine($"Name of student : {pupil4.Name} .\n{pupil4.StudySkill}\n{pupil4.ReadingSkill}\n{pupil4.WritingSkill}\n{pupil4.RelaxingSkill}"); }
        }
    }

    class Pupil
    {
        public string Name;
        public string StudySkill;
        public string ReadingSkill;
        public string WritingSkill;
        public string RelaxingSkill;


        public Pupil(string name)
        {
            Name = name;
            Study();
            Read();
            Write();
            Relax();
        }

        public void InfoAboutStudent()
        {
            Console.WriteLine($"Name of student : {Name} .\n{StudySkill}\n{ReadingSkill}\n{WritingSkill}\n{RelaxingSkill}");
        }

        public virtual void Study()
        {
            StudySkill = $"Student {Name} can study.";
        }

        public virtual void Read()
        {
            ReadingSkill = $"Student {Name} can read.";
        }

        public virtual void Write()
        {
            WritingSkill = $"Student {Name} can write.";
        }

        public virtual void Relax()
        {
            RelaxingSkill = $"Student {Name} can relax.";
        }

    }

    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name)
            : base(name)
        {
            Name = name;
            Study();
            Read();
            Write();
            Relax();
        }

        public override void Study()
        {
            StudySkill = $"Student {Name} have excelent skill of study.";
        }

        public override void Read()
        {
            ReadingSkill = $"Student {Name} have excelent skill of reading.";
        }

        public override void Write()
        {
            WritingSkill = $"Student {Name} have excelent skill of writing.";
        }

        public override void Relax()
        {
            RelaxingSkill = $"Student {Name} can relax so excellent.";
        }
    }

    class GoodPupil : Pupil
    {
        public GoodPupil(string name)
            : base(name)
        {
            Name = name;
            Study();
            Read();
            Write();
            Relax();
        }

        public override void Study()
        {
            StudySkill = $"Student {Name} have good skill of study.";
        }

        public override void Read()
        {
            ReadingSkill = $"Student {Name} have good skill of reading.";
        }

        public override void Write()
        {
            WritingSkill = $"Student {Name} have good skill of writing.";
        }

        public override void Relax()
        {
            RelaxingSkill = $"Student {Name} can relax so good.";
        }
    }

    class BadPupil : Pupil
    {
        public BadPupil(string name)
            : base(name)
        {
            Name = name;
            Study();
            Read();
            Write();
            Relax();
        }

        public override void Study()
        {
            StudySkill = $"Student {Name} have bad skill of study.";
        }

        public override void Read()
        {
            ReadingSkill = $"Student {Name} have bad skill of reading.";
        }

        public override void Write()
        {
            WritingSkill = $"Student {Name} have bad skill of writing.";
        }

        public override void Relax()
        {
            RelaxingSkill = $"Student {Name} can relax so badly.";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Pupil student1 = new BadPupil("Ivan");
            Pupil student2 = new ExcelentPupil("Maksim");
            Pupil student3 = new GoodPupil("Danylo");
            Pupil student4 = new ExcelentPupil("Kirill");
            ClassRoom class1 = new ClassRoom(student1, student2, student3, student4);
            class1.PrintInfo();
        }
    }
}