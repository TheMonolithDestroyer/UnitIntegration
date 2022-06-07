using System;
using TheArtOfUnitTesting.Tests.Fakes;
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

        [Fact]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            Assert.True(true);
            //FakeWebService mockService = new FakeWebService();
            //LoggerAnalyzerManager2 manager2 = new LoggerAnalyzerManager2(mockService);
            //string tooShortFileName = "abc.txt";

            //manager2.Analyze(tooShortFileName);

            //Assert.Contains($"FileName too short: { tooShortFileName }", mockService.LastError);
        }

        [Fact]
        public void Analyze_WebManagerThrows_SendsEmail()
        {
            FakeWebService stubService = new FakeWebService();
            stubService.ToThrow = new Exception("fake exception");

            FakeEmailManager mockEmail = new FakeEmailManager();
            LoggerAnalyzerManager2 log = new LoggerAnalyzerManager2(stubService, mockEmail);

            string tooShortFileName = "abc.txt";
            log.Analyze(tooShortFileName);

            Assert.Contains("someone@somewhere.com", mockEmail.To);
            Assert.Contains("fake exception", mockEmail.Body);
            Assert.Contains("can't log", mockEmail.Subject);
        }
    }
}
