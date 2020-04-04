﻿using System;
using System.Collections.Generic;
using Spire.Email;
using Spire.Email.Pop3;

public class SubjectFromMail
{
    public SubjectFromMail()
    {

    }
    public List<string> GetSubjectFromMail(string mailhost, string mailusername, string mailpassword, string mailport, string mailenableSSL)
    {
        var RFIDString = new List<string>();
        var pop = new Pop3Client
        {
            Host = mailhost,
            Username = mailusername,
            Password = mailpassword,
            Port = Int32.Parse(mailport),
            EnableSsl = Convert.ToBoolean(mailenableSSL)
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
