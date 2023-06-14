using DomainChecker.Classes;

namespace DomainChecker.Interfaces
{
    public interface IProxyProvider
    {
        List<CustomProxy> GetProxy();
    }
}
