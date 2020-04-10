using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MainWorker(new EmailSubjectProvider(), new ConsolePrintService());
            test.DoWork();
            Console.ReadKey();
        }
    }
}
