using System;
using System.Collections.Generic;
using System.Text;
using TheArtOfUntTesting.Interfaces;

namespace TheArtOfUnitTesting.Tests.Fakes
{
    public class FakeEmailManager : IEmailManager
    {
        public string To;
        public string Body;
        public string Subject;
        public void SendEmail(string to, string subject, string body)
        {
            To = to;
            Body = body;
            Subject = subject;
        }
    }
}
