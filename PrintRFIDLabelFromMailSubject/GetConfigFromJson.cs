using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace PrintRFIDLabelFromMailSubject
{
    public class GetConfigFromJson : IConfig
    {
        public IConfiguration GetConfig()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appconfig.json", optional: false, reloadOnChange: true)
                .Build();
            return configuration;
        }
    }
}
