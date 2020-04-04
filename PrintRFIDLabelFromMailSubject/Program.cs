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

            SubjectFromMail(configuration["MailHost"], configuration["MailUsername"], configuration["MailPassword"], configuration["MailPort"], configuration["MailEnableSSL"]);
            
            
            var client = new TcpClient(Configuration["PrinterIP"], Int32.Parse(Configuration["PrinterPort"]));

        
        }
    }
}
