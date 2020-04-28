using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace PrintRFIDLabelFromMailSubject
{
    public class GetConfigFromDatabase : IConfig
    {
        public IConfiguration GetConfig()
        {
            // read from DB here
            Console.WriteLine("Inside GetConfigFromDatabase");
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appconfig.json", optional: false, reloadOnChange: true)
                .Build();
            return configuration;
        }
    }
}
