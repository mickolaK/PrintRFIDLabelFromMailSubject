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
            var mailenablessl = configuration.GetValue<bool>("MailEnableSSl"); 
            var mailport = configuration.GetValue<int>("MailPort");
            var RFIDString = new SubjectFromMail(configuration["MailHost"], configuration["MailUsername"], configuration["MailPassword"], mailport, mailenablessl)
                .GetSubjectFromMail();
            var printerport = configuration.GetValue<int>("PrinterPort");
            var label = new RFIDLabel(configuration["PrinterIP"], printerport)
                .SendRFIDLabelToPrinter(RFIDString);
        }
    }
}
