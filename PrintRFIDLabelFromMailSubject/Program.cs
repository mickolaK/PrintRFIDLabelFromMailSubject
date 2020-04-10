using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;

namespace PrintRFIDLabelFromMailSubject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var config = new GetConfigFromJson();
            var rfidString = new SubjectFromMail(config)
                .GetSubjectFromMail();
            var label = new RFIDLabel(config)
                .SendRFIDLabelToPrinter(rfidString);
        }
    }
}
