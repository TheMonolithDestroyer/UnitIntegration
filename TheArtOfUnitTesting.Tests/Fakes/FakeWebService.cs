using System;
using System.Collections.Generic;
using System.Text;
using TheArtOfUntTesting.Interfaces;

namespace TheArtOfUnitTesting.Tests.Fakes
{
    public class FakeWebService : IWebService
    {
        public string LastError;
        public Exception ToThrow;

        public void LogError(string message)
        {
            if (ToThrow != null)
                throw ToThrow;
        }
    }
}
