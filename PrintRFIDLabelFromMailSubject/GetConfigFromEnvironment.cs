using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace PrintRFIDLabelFromMailSubject
{
    public class GetConfigFromEnvironment : IConfig
    {
        public IConfiguration GetConfig()
        {
            var configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();
            return configuration;
        }
    }
}
