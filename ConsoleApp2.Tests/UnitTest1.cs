using NUnit.Framework;

namespace ConsoleApp2.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var app = new MainWorker(new EmailSubjectProvider(), new ConsolePrintService() );
            app.DoWork();
        }
    }
}