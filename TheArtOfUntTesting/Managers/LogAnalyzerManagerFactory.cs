using System.IO;
using TheArtOfUntTesting.Interfaces;

namespace TheArtOfUntTesting.Managers
{
    public class LogAnalyzerManagerFactory
    {
        public bool IsValidLogFileName(string fileName)
        {
            return GetManager().IsValid(fileName)
                && Path.GetFileNameWithoutExtension(fileName).Length > 5;
        }

        protected virtual IExtensionManager GetManager()
        {
            return new FileExtensionManager();
        }
    }
}
