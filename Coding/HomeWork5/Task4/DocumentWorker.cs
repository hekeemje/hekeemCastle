﻿using System;

namespace Task4
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт.");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про.");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Эксперт.");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }

    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован.");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате.");
        }
    }
}
