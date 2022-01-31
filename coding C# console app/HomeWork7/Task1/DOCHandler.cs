using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName) : base(fileName)
        {
        }

        public string FilePath { get; set; }

        public override void Open()
        {
            Console.WriteLine($"Open DOC file {FileName}.");
            using (StreamReader streamReader = File.OpenText(FilePath))
            {
                Console.WriteLine($"Text from {FileName}");
                Console.Write(streamReader.ReadToEnd());
            }
        }

        public override void Create(string path)
        {
            Console.WriteLine($"Create DOC file {FileName}.");
            DirectoryInfo fileCreate = new DirectoryInfo(path);
            if (!fileCreate.Exists)
            {
                fileCreate.Create();
            }
            FilePath = Path.Combine(path, FileName + ".doc");
            StreamWriter createFile = new StreamWriter(FilePath);
            createFile.Close();
        }
        public override void Change(string text)
        {
            Console.WriteLine($"Change DOC file {FileName}.");
            StreamWriter change = new StreamWriter(FilePath);
            change.WriteLine(text);
            change.Close();
        }
        public override void Save()
        {
            Console.WriteLine($"Save DOC file {FileName}.");
        }
    }
}
