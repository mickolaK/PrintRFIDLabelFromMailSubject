using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;


namespace PrintRFIDLabelFromMailSubject
{
    public class OnStartConfigureParameter
    {
        public IConfiguration Configuration { get; set; }
        public OnStartConfigureParameter()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appconfig.json");
            Configuration = builder.Build();
            var mail = new MailConnectionParam(Configuration["Mail:Host"],
                Configuration["Mail:Username"],
                Configuration["Mail:Password"],
                Int32.Parse(Configuration["Mail:Port"]),
                Convert.ToBoolean(Configuration["Mail:EnableSSL"])
                );
            var printer = new PrinterConnectionParam(Configuration["Printer:IPAddress"],Int32.Parse(Configuration["Printer:Port"]));

        }
        

    }
}
