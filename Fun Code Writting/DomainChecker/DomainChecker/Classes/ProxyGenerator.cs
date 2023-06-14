namespace DomainChecker.Classes
{
    public class ProxyGenerator
    {
        private List<CustomProxy> _proxies = new();
        public ProxyGenerator(IEnumerable<CustomProxy> webProxies)
        {
            _proxies = webProxies.ToList();
        }

        public CustomProxy GetRandomProxy()
        {
            if (_proxies.Count == 0) return null;
            Random rand = new Random();
            return _proxies[rand.Next(_proxies.Count)];
        }

        public CustomProxy GetRandomProxy(string host)
        {
            Random rand = new Random();
            var filterProxys = _proxies.Where(p => p._host != host).ToList();
            return filterProxys[rand.Next(filterProxys.Count)];
        }
    }
}
