using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;

namespace PrintRFIDLabelFromMailSubject
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appconfig.json")
                .Build();
            var RFIDString = new SubjectFromMail()
                .GetSubjectFromMail(configuration["MailHost"], configuration["MailUsername"], configuration["MailPassword"], configuration["MailPort"], configuration["MailEnableSSL"]);
            var label = new RFIDLabel()
                .SendRFIDLabelToPrinter(RFIDString, configuration["PrinterIP"], configuration["PrinterPort"]);
        }
    }
}
