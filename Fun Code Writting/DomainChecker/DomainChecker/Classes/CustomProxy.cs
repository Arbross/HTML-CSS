using System.Net;

namespace DomainChecker.Classes
{
    public class CustomProxy
    {
        public CustomProxy() { }

        public WebProxy _webProxy;
        public string _userName = "";
        public string _passwordProxy = "";
        public string _host = "";
        public string _port = "";
    }
}
