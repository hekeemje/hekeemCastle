using System;
using System.IO;


namespace something_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // OutputFS();
            // WorkWithDirectory();
            WorkWithFiles();

            Console.WriteLine("Hello World!");
        }

        private static void WorkWithFiles()
        {
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var customFolders = new string[]
                {
                    userFolder, "Code", "Test", "NewFolder"
                };


            string dir = Path.Combine(customFolders);
            Directory.CreateDirectory(dir);

            string textFile = Path.Combine(dir, "Text.txt");
            string backupFile = Path.Combine(dir, "Backup.bac");

            Console.WriteLine(File.Exists(textFile)); // проверяет существует ли этот файл

            using (StreamWriter textWriter = File.CreateText(textFile)) // открывает и закрывает поток и создает в textfile ( text.txt ) "hello"
            {
                textWriter.WriteLine("Hello");
            }

            File.Copy(textFile, backupFile); // скопирует текстфайл в бэкап

            using (StreamReader streamReader = File.OpenText(backupFile)) // прочитать с файла и вывести
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }

            Console.WriteLine(Path.GetRandomFileName());
        }

        private static void WorkWithDirectory()
        {
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var customFolders = new string[]
                {
                    userFolder, "Code", "Test", "NewFolder"
                };

            string dir = Path.Combine(customFolders);

            Directory.CreateDirectory(dir); // создать директорию с тем именем которое мы сделали

            // Directory.Delete(dir); - удалить ( только если папка пустая ) 

            Directory.Delete(dir, true); // удалить и со всеми внутренними файлами и тд 


        }

        private static void OutputFS()
        {
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine();
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine(Environment.CurrentDirectory);
        }
    }
}
