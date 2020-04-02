using System;
using System.Collections.Generic;
using System.Text;

namespace PrintRFIDLabelFromMailSubject
{
    class MailConnectionParam
    {
        
        private string Host { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private int Port { get; set; }
        private bool EnableSSL { get; set; }

        public MailConnectionParam(string host, string username, string password, int port, bool enablessl)
        {
            Host = host;
            Username = username;
            Password = password;
            Port = port;
            EnableSSL = enablessl;
        }
    }
}
