namespace Task2
{
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