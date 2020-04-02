using System;
using System.Collections.Generic;
using System.Text;

namespace PrintRFIDLabelFromMailSubject
{
    public class PrinterConnectionParam
    {
        private string IPAddress { get; set; }
        private int Port { get; set; }
        public PrinterConnectionParam(string ipaddress, int port)
        {
            IPAddress = ipaddress;
            Port = port;
        }
    }
}
