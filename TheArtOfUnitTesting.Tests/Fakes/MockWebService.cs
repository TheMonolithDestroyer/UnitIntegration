using System;
using System.Collections.Generic;
using System.Text;
using TheArtOfUntTesting.Interfaces;

namespace TheArtOfUnitTesting.Tests.Fakes
{
    public class MockWebService : IWebService
    {
        public string LastError;

        public void LogError(string message)
        {
            LastError = message;
        }
    }
}
