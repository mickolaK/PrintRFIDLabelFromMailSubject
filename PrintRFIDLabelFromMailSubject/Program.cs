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
            builder.RegisterType<GetConfigFromJson>().As<IConfig>();
            var container = builder.Build();
            var config = container.Resolve<IConfig>();
            var rfidString = new SubjectFromMail(config)
                .GetSubjectFromMail();
            var label = new RFIDLabel(config)
                .SendRFIDLabelToPrinter(rfidString);
        }
    }
}
