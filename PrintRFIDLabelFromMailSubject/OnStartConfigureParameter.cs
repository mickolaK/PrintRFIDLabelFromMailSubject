using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;


namespace PrintRFIDLabelFromMailSubject
{
    public class OnStartConfigureParameter
    {
        public OnStartConfigureParameter()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appconfig.json");

        }
        

    }
}
