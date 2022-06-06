using System.IO;
using TheArtOfUntTesting.Interfaces;

namespace TheArtOfUntTesting.Managers
{
    public class LogAnalyzerManager : LogAnalyzerManagerFactory
    {
        public bool IsSupported;
        public LogAnalyzerManager()
        {
        }

        protected override bool IsValid(string fileName)
        {
            return IsSupported;
        }
    }
}
