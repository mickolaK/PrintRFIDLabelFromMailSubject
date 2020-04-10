using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using PrintRFIDLabelFromMailSubject;
using Spire.Email;
using Spire.Email.Pop3;

public class SubjectFromMail
{
    public string MailHost { get; }
    public string MailUsername { get; }
    public string MailPassword { get; }
    public int MailPort { get; }
    public bool MailEnableSSL { get; }

    public SubjectFromMail(IConfig cfg)
    {
        this.MailHost = cfg.GetConfig()["MailHost"];
        this.MailUsername = cfg.GetConfig()["MailUsername"];
        this.MailPassword = cfg.GetConfig()["MailPassword"];
        this.MailPort = cfg.GetConfig().GetValue<int>("MailPort");
        this.MailEnableSSL = cfg.GetConfig().GetValue<bool>("MailEnableSSL");
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
