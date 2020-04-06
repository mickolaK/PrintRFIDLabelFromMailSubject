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
                .AddJsonFile("appconfig.json",optional:false,reloadOnChange:true)
                .Build();
            var label = new RFIDLabel(configuration["PrinterIP"], configuration["PrinterPort"])
                .SendRFIDLabelToPrinter(RFIDString);
            var printerport = configuration.
            var mailport =configuration["MailPort"];
            var RFIDString = new SubjectFromMail(configuration["MailHost"], configuration["MailUsername"], configuration["MailPassword"], configuration["MailPort"], configuration["MailEnableSSL"])
                .GetSubjectFromMail();
            
            
        }
    }
}
