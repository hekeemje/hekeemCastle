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
}