using TheArtOfUntTesting.Interfaces;

namespace TheArtOfUntTesting.Managers
{
    public class LogAnalyzerManager
    {
        private IExtensionManager _manager;
        public IExtensionManager ExtensionManager
        {
            get { return _manager; }
            set { _manager = value; }
        }

        public LogAnalyzerManager()
        {
            _manager = new FileExtensionManager();
        }

        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }
    }
}
