using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace PrintRFIDLabelFromMailSubject
{
    public interface IConfig
    {
        public IConfiguration GetConfig();
    }

    class GetConfigFromJson:IConfig
    {
        public IConfiguration GetConfig()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appconfig.json", optional: false, reloadOnChange: true)
                .Build();
            return configuration;
        }
    }

    class GetConfigFromEnvironment:IConfig
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
