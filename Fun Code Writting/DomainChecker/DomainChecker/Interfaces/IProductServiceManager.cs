namespace DomainChecker.Interfaces
{
    public interface IProductServiceManager
    {
        Task<int?> BrowserLoader(string url, int countRequest = 0, int? statusCode = null);
        Task<int?> HttpClientLoader(string url, int countRequest = 0, int? statusCode = null);
    }
}
