using TheArtOfUntTesting.Interfaces;

namespace TheArtOfUntTesting.Managers
{
    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}
