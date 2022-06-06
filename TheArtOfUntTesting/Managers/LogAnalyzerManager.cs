using System.IO;
using TheArtOfUntTesting.Interfaces;

namespace TheArtOfUntTesting.Managers
{
    public class LogAnalyzerManager : LogAnalyzerManagerFactory
    {
        public IExtensionManager Manager;
        public LogAnalyzerManager(IExtensionManager manager)
        {
            Manager = manager;
        }

        protected override IExtensionManager GetManager()
        {
            return Manager;
        }
    }
}
