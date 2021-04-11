using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + $"\\files"; // генерируем путь к папке files относительно данного проекта
            Console.WriteLine("Work with DOC\n");
            DOCHandler docFile1 = new DOCHandler("ExampleFileForDoc");
            docFile1.Create(path);
            docFile1.Change("Test text in DOC.");
            docFile1.Open();
            docFile1.Save(); // не совсем понимаю что можно реализовать в методе Save , если я в методе Change уже закрываю поток после добавления текста чтобы пользователь не забывал
            Console.WriteLine("\nWork with TXT\n");
            TXTHandler txtFile1 = new TXTHandler("ExampleFileForTxt");
            txtFile1.Create(path);
            txtFile1.Change("Test text in TXT.");
            txtFile1.Open();
            txtFile1.Save();
            Console.WriteLine("\nWork with XML\n");
            XMLHandler xmlFile1 = new XMLHandler("ExampleFileForXML");
            xmlFile1.Create(path);
            xmlFile1.Change("Test text in XML.");
            xmlFile1.Open();
            xmlFile1.Save();
        }
    }
}
