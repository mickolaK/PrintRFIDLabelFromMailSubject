using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using Autofac;

namespace PrintRFIDLabelFromMailSubject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var builder = new ContainerBuilder();
            builder.RegisterType<SubjectFromMail>();
            builder.RegisterType<RFIDLabel>();
            var container = builder.Build();
            var config = container.Resolve<IConfig>();
            var rfidString = container.Resolve<SubjectFromMail>().GetSubjectFromMail();
            var label = container.Resolve<RFIDLabel>().SendRFIDLabelToPrinter(rfidString);

            //var config = new GetConfigFromJson();

            /*var rfidString = new SubjectFromMail(config)
                .GetSubjectFromMail();
            var label = new RFIDLabel(config)
                .SendRFIDLabelToPrinter(rfidString);*/
        }
    }
}
