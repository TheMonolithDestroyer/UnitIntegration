using System;
using TheArtOfUnitTesting.Tests.ManagersTests;
using TheArtOfUntTesting.Managers;
using Xunit;

namespace TheArtOfUnitTesting.Tests
{
    public class UnitTesting
    {
        [Fact]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();

            myFakeManager.WillThrow = new Exception("this is fake");

            LogAnalyzerManager log = new LogAnalyzerManager(myFakeManager);
            bool result = log.IsValidLogFileName("anything.anyextension");

            Assert.False(result);
        }
    }
}
