using System.Net;
using DomainChecker.Classes;
using DomainChecker.Interfaces;

namespace DomainChecker.Helpers
{
    public class FileProxyProvider : IProxyProvider
    {
        private readonly string _fileName;
        private ILogger<FileProxyProvider> _logger;
        public FileProxyProvider(ILogger<FileProxyProvider> logger)
        {
            _fileName = "proxies.txt";
            _logger = logger;
        }

        public List<CustomProxy> GetProxy()
        {
            if (File.Exists(_fileName))
            {
                return ConvertStringToWebProxy(File.ReadAllLines(_fileName));
            }
            else
            {
                _logger.LogError("File proxy not exists");
                throw new Exception($"File proxy not exists!! {_fileName}");
            }
        }

        private List<CustomProxy> ConvertStringToWebProxy(string[] Proxies)
        {
            List<CustomProxy> ProxysResult = new List<CustomProxy>();
            foreach (string Proxy in Proxies)
            {
                CustomProxy customProxy = new CustomProxy();
                customProxy._webProxy = new WebProxy();
                var list = Proxy.Split('@');
                var loginpass = list[0].Split(':');
                var ipport = list[1].Split(':');
                //IpProxy = list[1];
                customProxy._webProxy = new WebProxy
                {
                    Address = new Uri($"http://{ipport[0]}:{ipport[1]}"),
                    BypassProxyOnLocal = false,
                    UseDefaultCredentials = false,

                    // *** These creds are given to the proxy server, not the web server ***
                    Credentials = new NetworkCredential(
                    userName: loginpass[0],
                    password: loginpass[1])
                };
                customProxy._host = ipport[0];
                customProxy._port = ipport[1];
                customProxy._userName = loginpass[0];
                customProxy._passwordProxy = loginpass[1];
                ProxysResult.Add(customProxy);
            }
            return ProxysResult;
        }
    }
}
