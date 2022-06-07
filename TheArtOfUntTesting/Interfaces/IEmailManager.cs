namespace TheArtOfUntTesting.Interfaces
{
    public interface IEmailManager
    {
        void SendEmail(string to, string subject, string body);
    }
}
