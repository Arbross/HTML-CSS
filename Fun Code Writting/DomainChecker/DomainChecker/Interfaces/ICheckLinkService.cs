using DomainChecker.Helpers;

namespace DomainChecker.Interfaces
{
    public interface ICheckLinkService
    {
        Task<CheckedLinkResponse> Check(string link, bool AlwaysRequestFromBrowser);
    }
}
