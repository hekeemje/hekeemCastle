using System;

namespace Task4
{

    class Program
    {
        static void Main(string[] args)
        {
            int keyForPro = 12345;
            int keyForExp = 54321;
            Console.WriteLine("Введите серийный ключ.");
            try
            {
                int check = int.Parse(Console.ReadLine());
                DocumentWorker user1;

                if (check == keyForPro)
                {
                    user1 = new ProDocumentWorker();
                }
                else if (check == keyForExp)
                {
                    user1 = new ExpertDocumentWorker();
                }
                else
                {
                    user1 = new DocumentWorker();
                }
                Console.WriteLine();
                user1.OpenDocument();
                user1.EditDocument();
                user1.SaveDocument();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
