using TheArtOfUntTesting.Interfaces;

namespace TheArtOfUntTesting.Managers
{
    public class LogAnalyzerManager
    {
        private readonly IExtensionManager _manager;
        public LogAnalyzer(IExtensionManager manager)
        {
            _manager = manager;
        }

        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }
    }
}
