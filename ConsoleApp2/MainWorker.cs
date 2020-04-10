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
        public MainWorker(ISubjectsProvider subjectProvider, IPrintService printService)
        {
            this.subjectprovider = subjectProvider;
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

    public class EmailSubjectProvider : ISubjectsProvider
    {
        public PrintableDto[] GetSubjects()
        {
            Console.WriteLine($"GetSubjects");
            return new PrintableDto[] { new PrintableDto("String#1"), new PrintableDto("String#2") };
            //throw new NotImplementedException();
        }
    }

    public class ConsolePrintService : IPrintService
    {
        public void Print(PrintableDto[] strings)
        {
            foreach (var VARIABLE in strings)
            {
                Console.WriteLine($"{VARIABLE.Title}");
            }

            //throw new NotImplementedException();
        }
    }

}


