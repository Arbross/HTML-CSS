using System.Text;
using PuppeteerSharp;
using System.Diagnostics;
using DomainChecker.Classes;
using DomainChecker.Interfaces;
using System.Net;
using System.Diagnostics.Metrics;

namespace DomainChecker.Services
{
    public class ProductServiceManager : IProductServiceManager
    {
        private static int _counter = 1;

        private readonly IConfiguration _configuration;
        private readonly IServiceProvider _serviceProvider;

        public Browser _browser;
        public Page _page;
        
        private readonly List<string> _myArray;
        private LaunchOptions _options = null;

        public ProductServiceManager(IConfiguration configuration, IServiceProvider serviceProvider)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            _configuration = configuration;
            _serviceProvider = serviceProvider;
            _myArray = new List<string>();// _configuration.GetSection("DisplaySettingUrls").Get<List<string>>();
        }

        private void CreateOptionForBrowser(CustomProxy customProxy, bool headlss)
        {
            List<string> _argsForOption = new()
            {
                    "--disable-gpu",
                    "--disable-dev-shm-usage",
                    "--disable-setuid-sandbox",
                    "--no-first-run",
                    "--no-sandbox",
                    "--no-zygote",
                    "--deterministic-fetch",
                    "--disable-features=IsolateOrigins",
                    "--disable-site-isolation-trials",
                    //"--start-maximized",
                    //"--ignore-certificate-errors",
                    $"--proxy-server=http://{customProxy._host}:{customProxy._port}"
            };

            _options = new LaunchOptions
            {
                Headless = headlss,
                Args = _argsForOption.ToArray(),
                IgnoredDefaultArgs = new string[]
                {
                    "--enable-automation"
                },
                ExecutablePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe",
                IgnoreHTTPSErrors = true
            };
        }

        public async Task<int?> HttpClientLoader(string url, int countRequest = 0, int? statusCode = null)
        {
            using (IServiceScope scope = _serviceProvider.CreateScope())
            {
                ILogger<ProductServiceManager> logger = scope.ServiceProvider.GetRequiredService<ILogger<ProductServiceManager>>();
                ProxyGenerator _proxyGenerator = new ProxyGenerator(scope.ServiceProvider.GetRequiredService<IProxyProvider>().GetProxy());

                var proxy = _proxyGenerator.GetRandomProxy();
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                HttpResponseMessage response = null;

                try
                {
                    var cookieContainer = new CookieContainer();
                    using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
                    {
                        handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

                        using (var client = new HttpClient(handler))
                        {
                            if (proxy != null)
                            {
                                handler.Proxy = proxy._webProxy;
                            }

                            if (!url.Contains("https://") || !url.Contains("http://") && countRequest == 0)
                            {
                                url = "https://" + url;
                            }

                            client.BaseAddress = new Uri(url);

                            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)");
                            response = await client.GetAsync(url, HttpCompletionOption.ResponseContentRead);

                            if ((int)response.StatusCode == 524 && countRequest < 2)
                            {
                                statusCode = (int)response.StatusCode;
                                countRequest++;
                                return await HttpClientLoader(url, countRequest, statusCode);
                            }

                            if (response.StatusCode == HttpStatusCode.NotFound && !url.Contains("www") && countRequest < 3)
                            {
                                statusCode = (int)response.StatusCode;
                                countRequest++;
                                url = url.Replace("://", "://www.");
                                return await HttpClientLoader(url, countRequest, statusCode);
                            }

                            statusCode = (int)response.StatusCode;

                            stopWatch.Stop();

                            TimeSpan ts = stopWatch.Elapsed;
                            var sec = ts.TotalSeconds;

                            _counter++;
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                logger.LogInformation($"HttpCliet; {_counter}; {url}; {response.StatusCode}; {string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)}; {DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}");
                            }
                            else
                            {
                                logger.LogWarning($"HttpCliet; {_counter}; {url}; {response.StatusCode}; {string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)}; {DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}");
                            }

                            return (int)statusCode;
                        }
                    }
                }
                catch (Exception ex)
                {
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;

                    if (countRequest < 3)
                    {
                        countRequest++;
                        logger.LogError($"HttpCliet; {_counter}; {url}; {response?.StatusCode}; {string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)}; {DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}");
                        return await HttpClientLoader(url, countRequest, statusCode);
                    }

                    ++_counter;
                    logger.LogError($"HttpCliet; {_counter}; {url}; {response?.StatusCode}; {string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)}; {DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}");

                    if (ex.Message.Contains("502"))
                    {
                        return 502;
                    }

                    return statusCode;
                }
            }
        }

        public async Task<int?> BrowserLoader(string url, int countRequest = 0, int? statusCode = null)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Browser browser = null;

            using (IServiceScope scope = _serviceProvider.CreateScope())
            {
                ILogger<ProductServiceManager> logger = scope.ServiceProvider.GetRequiredService<ILogger<ProductServiceManager>>();
                ProxyGenerator _proxyGenerator = new ProxyGenerator(scope.ServiceProvider.GetRequiredService<IProxyProvider>().GetProxy());

                var proxy = _proxyGenerator.GetRandomProxy();

                if (!url.Contains("https://") || !url.Contains("http://") && countRequest == 0)
                {
                    url = "https://" + url;
                }

                var uri = new Uri(url);

                try
                {
                    browser = await InitBrowserAsync(proxy, !_myArray.Contains(uri.Host));
                    string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4767.0 Safari/537.36 Edg/99.0.1113.0";
                    Page page = (Page)browser.PagesAsync().Result.First();

                    await page.AuthenticateAsync(new Credentials() { Username = proxy._userName, Password = proxy._passwordProxy });
                    await page.SetUserAgentAsync(UserAgent);
                    await page.SetCacheEnabledAsync(false);
                    await page.DeleteCookieAsync();

                    NavigationOptions options = new NavigationOptions();
                    var response = await page.GoToAsync(url, timeout: 120000);

                    if ((int)response.Status == 524 && countRequest < 2)
                    {
                        statusCode = (int)response.Status;
                        countRequest++;
                        return await BrowserLoader(url, countRequest, statusCode);
                    }

                    if (response.Status == HttpStatusCode.NotFound && !url.Contains("www") && countRequest < 10)
                    {
                        statusCode = (int)response.Status;
                        countRequest++;
                        url = url.Replace("://", "://www.");
                        return await BrowserLoader(url, countRequest, statusCode);
                    }

                    statusCode = (int)response.Status;

                    stopWatch.Stop();

                    TimeSpan ts = stopWatch.Elapsed;
                    var sec = ts.TotalSeconds;

                    _counter++;
                    if (statusCode == (int)HttpStatusCode.OK)
                    {
                        logger.LogInformation($"BrowserRequest; {_counter}; {url}; {statusCode}; {string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)}; {DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}");
                    }
                    else
                    {
                        logger.LogWarning($"BrowserRequest; {_counter}; {url}; {statusCode}; {string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)}; {DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}");
                    }

                    await browser.CloseAsync();

                    return (int)statusCode;
                }
                catch (Exception ex)
                {
                    if (browser != null)
                    {
                        await browser.CloseAsync();
                    }

                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;


                    if (countRequest < 10)
                    {
                        countRequest++;
                        logger.LogError($"BrowserRequest; {url}; {ex.Message}; {string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)}; {DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}");
                        return await BrowserLoader(url, countRequest, statusCode);
                    }

                    _counter++;
                    logger.LogError($"BrowserRequest; {url}; {ex.Message}; {string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)}; {DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}");

                    return statusCode;
                }
            }
        }

        private async Task<Browser> InitBrowserAsync(CustomProxy customProxy, bool headless)
        {
            CreateOptionForBrowser(customProxy, headless);
            return (Browser)await Puppeteer.LaunchAsync(_options);
        }
    }
}
