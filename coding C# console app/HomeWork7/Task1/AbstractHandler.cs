using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class AbstractHandler
    {
        public string FileName { get; set; }
        public AbstractHandler(string fileName)
        {
            FileName = fileName;
        }

        public abstract void Open();
        public abstract void Create(string path);
        public abstract void Change(string text);
        public abstract void Save();

    }
}
