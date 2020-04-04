using System;
using System.Collections.Generic;
using Spire.Email;
using Spire.Email.Pop3;

public class SubjectFromMail
{
    public string MailHost { get; }
    public string MailUsername { get; }
    public string MailPassword { get; }
    public int MailPort { get; }
    public bool MailEnableSSL { get; }

    public SubjectFromMail(string mailhost, string mailusername, string mailpassword, int mailport, bool mailenableSSL)
    {
        MailHost = mailhost;
        MailUsername = mailusername;
        MailPassword = mailpassword;
        MailPort = mailport;
        MailEnableSSL = mailenableSSL;
    }
    public List<string> GetSubjectFromMail()
    {
        var RFIDString = new List<string>();
        var pop = new Pop3Client
        {
            Host = MailHost,
            Username = MailUsername,
            Password = MailPassword,
            Port = MailPort,
            EnableSsl = MailEnableSSL
        };
        pop.Connect();
        int messageCount = pop.GetMessageCount();
        Console.WriteLine("Subject added to list:");
        for (int i = 1; i <= messageCount; i++)
        {
            MailMessage message = pop.GetMessage(i);
            Console.WriteLine($"{i}. { message.Subject}");
            RFIDString.Add(message.Subject);
        }
        pop.Disconnect();
        pop.Dispose();
        return RFIDString;
        
	}
}
