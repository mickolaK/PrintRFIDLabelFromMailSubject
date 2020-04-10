using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace PrintRFIDLabelFromMailSubject
{
    public interface IConfig
    {
        public IConfiguration GetConfig();
    }
}
