using DomainChecker.Helpers;
using DomainChecker.Interfaces;
using System.Net;

namespace DomainChecker.Services
{
    public class CheckLinkService : ICheckLinkService
    {
        private readonly IServiceProvider _serviceProvider;
        public CheckLinkService(IServiceProvider serviceProvider) 
        {
            _serviceProvider = serviceProvider;
        }

        private async Task<CheckedLinkResponse> CheckStatusCode(string url, int? code)
        {
            if (code == null)
            {
                return await Task.FromResult(new CheckedLinkResponse()
                {
                    Url = url,
                    StatusCode = 0,
                });
            }

            if (code >= 500 && code <= 511 || code >= 520 && code <= 526)
            {
                if (code == 525 || code == 526)
                {
                    return null;
                }

                return await Task.FromResult(new CheckedLinkResponse()
                {
                    Url = url,
                    StatusCode = code,
                });
            }
            else
            {
                return null;
            }
        }

        public async Task<CheckedLinkResponse> Check(string url, bool alwaysRequestFromBrowser)
        {
            using (IServiceScope scope = _serviceProvider.CreateScope())
            {
                IProductServiceManager productServiceManager = scope.ServiceProvider.GetRequiredService<IProductServiceManager>();

                if (alwaysRequestFromBrowser)
                {
                    int? statusCode = await productServiceManager.BrowserLoader(url);

                    return await CheckStatusCode(url, (int)statusCode);
                }
                else
                {
                    int? statusCode = await productServiceManager.HttpClientLoader(url);

                    return await CheckStatusCode(url, statusCode);
                }
            }
        }
    }
}
