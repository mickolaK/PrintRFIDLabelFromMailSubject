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
            // return configuration;
        }
    }
}
