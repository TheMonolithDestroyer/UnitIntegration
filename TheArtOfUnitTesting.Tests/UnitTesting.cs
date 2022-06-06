using System;
using TheArtOfUnitTesting.Tests.ManagersTests;
using TheArtOfUntTesting;
using TheArtOfUntTesting.Managers;
using Xunit;

namespace TheArtOfUnitTesting.Tests
{
    public class UnitTesting
    {
        [Fact]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager
            {
                WillBeValid = true
            };

            LogAnalyzerManager lam = new LogAnalyzerManager(myFakeManager);

            bool actual = lam.IsValidLogFileName("file.ext");

            Assert.False(actual);
        }
    }
}
