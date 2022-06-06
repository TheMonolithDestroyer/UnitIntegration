using System;
using TheArtOfUntTesting.Interfaces;

namespace TheArtOfUntTesting.Managers
{
    public class LoggerAnalyzerManager2
    {
        private readonly IWebService _webService;
        private readonly IEmailManager _emailManager;
        public LoggerAnalyzerManager2(IWebService webService, IEmailManager emailManager)
        {
            _webService = webService;
            _emailManager = emailManager;
        }

        public void Analyze(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName) && fileName.Length < 8)
            {
                try
                {
                    _webService.LogError("FileName too short: " + fileName);
                }
                catch (Exception ex)
                {
                    _emailManager.SendEmail("someone@somewhere.com", "can't log", "fake exception");
                }
            }
        }
    }
}
