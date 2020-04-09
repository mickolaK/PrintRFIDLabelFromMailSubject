using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MainWorker
    {
        private readonly ISubjectsProvider subjectprovider;
        private readonly IPrintService printService;

        public void DoWork()
        {
            var subjects = subjectprovider.GetSubjects();
            printService.Print(subjects);
        }
        public MainWorker(ISubjectsProvider subjectprovider, IPrintService printService)
        {
            this.subjectprovider = subjectprovider;
            this.printService = printService;
        }
    }

    public interface ISubjectsProvider
    {
        PrintableDto[] GetSubjects();
    }

    public interface IPrintService
    {
        void Print(PrintableDto[] strings);

    }

    public class PrintableDto
    {
        public PrintableDto(string title)
        {
            Title = title;
        }

        public string Title { get; }
    }

    public class EmailSubjctProvider : ISubjectsProvider
    {
        public PrintableDto[] GetSubjects()
        {
            throw new NotImplementedException();
        }
    }

    public class ConsolePrintService : IPrintService
    {
        public void Print(PrintableDto[] strings)
        {
            throw new NotImplementedException();
        }
    }

}


