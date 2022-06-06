using TheArtOfUntTesting.Interfaces;
using TheArtOfUntTesting.Managers;

namespace TheArtOfUntTesting
{
    public static class ExtensionManagerFactory
    {
        private static IExtensionManager _customManager = null;

        public static IExtensionManager Create()
        {
            if (_customManager != null)
                return _customManager;

            return new FileExtensionManager();
        }

        public static void SetManager(IExtensionManager manager)
        {
            _customManager = manager;
        }
    }
}
