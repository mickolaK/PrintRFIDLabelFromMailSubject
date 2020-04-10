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

    public class GetConfigFromJson:IConfig
    {
        public IConfiguration GetConfig()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appconfig.json", optional: false, reloadOnChange: true)
                .Build();
            return configuration;
        }
    }

    public class GetConfigFromEnvironment:IConfig
    {
        public IConfiguration GetConfig()
        {
            var configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();
            return configuration;
        }
    }

    public class GetConfigFromDatabase : IConfig
    {
        public IConfiguration GetConfig()
        {
            // read from DB here
            // return configuration;
        }
    }
}
