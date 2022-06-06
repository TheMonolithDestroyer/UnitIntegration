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
        public void OverrideTestWithoutStub()
        {
            LogAnalyzerManager manager = new LogAnalyzerManager();
            manager.IsSupported = true;

            bool result = manager.IsValidLogFileName("file.ext");

            Assert.True(result, "...");
        }

        [Fact]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            Assert.True(true);
            //FakeExtensionManager myFakeManager = new FakeExtensionManager
            //{
            //    WillBeValid = true
            //};

            //LogAnalyzerManager lam = new LogAnalyzerManager(myFakeManager);

            //bool actual = lam.IsValidLogFileName("file.ext");

            //Assert.False(actual);
        }
    }
}
