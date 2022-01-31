using System;

namespace Task2
{
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
}