using AdminPanel.Controllers;
using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Requests.Abstractions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace AdminPanel.Infrastructure
{
    class ManagerWeb
    {
        private static object LOCKER = new object();
        private static object LOG_LOCKER = new object();
        private static object STR_TO_FILE_LOCKER = new object();
        private static bool DEBUG = true;
        public List<Car> listCars = new List<Car>();
        List<string> badCars = new List<string>();

        private TelegramBotClient botClient;
        private User user = null;
        private Update[] updates = null;

        private string group_id = "-1001440202642";
        string telegramBotKey = "720511960:AAF-x3qFzMKtgfFKN8efiMW38XQBA4zPBTU";

        public static string proxy = "";

        public ManagerWeb()
        {
            HttpClient httpClient = null;
            botClient = new TelegramBotClient(telegramBotKey, httpClient); 
            user = botClient.GetMeAsync().Result;

            ReadBadCar();
        }

        private void ReadBadCar()
        {
            badCars = Database.GetBadLinks().Select(x => x.Url).ToList();
        }

        private async Task CheckCarsAsync()
        {
            ReadBadCar();
            try
            {
                for (int i = 0; i < listCars.Count; i++)
                {
                    string url = "";
                    if (listCars[i].url.Contains("autotrader"))
                    {
                        url = listCars[i].url.Substring(0, listCars[i].url.IndexOf("?"));
                    }
                    else
                        url = listCars[i].url;

                    if (badCars.Contains(url))
                    {
                        listCars.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        await botClient.SendTextMessageAsync((ChatId)group_id, $"1 car by subscription \"{listCars[i].name}\" \r\n{listCars[i].url}", ParseMode.Html, false, false, 0, (IReplyMarkup)null, new CancellationToken());

                        Database.InsertBadLink(new BadLink() { Url = url });
                        badCars.Add(url);
                    }

                }
            }
            catch(Exception ex)
            {

            }
        }
        public async Task CheckUrlAsync(string url, string _proxy)
        {
            proxy = _proxy;

            Debug.WriteLine(url);
            if (url.Contains("ebay"))
            {
                string patternUrl = @"(?<=class=s-item__link\ href=).*?(?=>)";
                string patternName = @"(?<=<img\ class=s-item__image-img\ alt="")[\w\W]*?(?="")";
                string str = getDataFromServer(url, "", "log.txt");
                MatchCollection matchList2 = Regex.Matches(str, patternUrl);
                MatchCollection matchList3 = Regex.Matches(str, patternName);
                for (int i = 0; i < matchList2.Count; i++)
                {
                    try
                    {
                        Car car = new Car(matchList2[i].Value, matchList3[i].Value, 0);
                        listCars.Add(car);
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }
            else if (url.Contains("autotrader"))
            {
                string patternUrl = @"(?<=<a\ class=""js-click-handler\ listing-fpa-link\ tracking-standard-link"")[\w\W]*?(?=></a>)";
                string patternName = @"(?<=<h3\ class=""product-card-details__title"">)[\w\W]*?(?=</h3)";
                string patternPrice = @"(?<=<div\ class=""product-card-pricing__price"">)[\w\W]*?(?=</span>)";
                string str = getDataFromServer(url, "", "log.txt");
                MatchCollection matchList2 = Regex.Matches(str, patternUrl);
                MatchCollection matchList3 = Regex.Matches(str, patternName);
                MatchCollection matchList4 = Regex.Matches(str, patternPrice);
                int price_to = 0;
                try
                {
                    price_to = Convert.ToInt32(Regex.Match(url, @"(?<=price-to=).*").Value);
                }
                catch(Exception ex)
                {
                    price_to = Convert.ToInt32(Regex.Match(url, @"(?<=price-to=).*?(?=&)").Value);
                }
                for (int i = 0; i < matchList2.Count; i++)
                {
                    try
                    {
                        string price = matchList4[i].Value.Replace("<span>£", "").Trim();

                        Car car = new Car("https://www.autotrader.co.uk" + matchList2[i].Value.Substring(matchList2[i].Value.IndexOf("/car-details")).Replace("\"", ""), matchList3[i].Value.Replace("\n", "").Trim(), int.Parse(price, NumberStyles.AllowThousands, new CultureInfo("en-au")));
                        if(price_to >= car.price)
                            listCars.Add(car);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            else if (url.Contains("gumtree"))
            {
                string patternUrl = @"href=""/p[\w\W]*?(?="")";
                string patternName = @"(?<=class=""data-lazy\ hide-fully-no-js\ main-image"")[\w\W]*?(?=/>)";
                string patternHour = @"(?<=<span\ class=""hide-visually"">Ad\ posted\ </span>)[\w\W]*?(?=</span>)";

                string str = TestRequest(url);

                MatchCollection matchList2 = Regex.Matches(str, patternUrl);
                MatchCollection matchList3 = Regex.Matches(str, patternName);

                if (matchList3.Count == 0)
                {
                    matchList3 = Regex.Matches(str, @"(?<=<h2\ class=""listing-title"">)[\w\W]*?(?=<)");
                }

                var ValidMatches = matchList3.Cast<Match>().Select(J => J.Value).ToList();

                if (ValidMatches[0] == "" || ValidMatches[0] == "\n")
                    ValidMatches.RemoveAt(0);

                MatchCollection matchList4 = Regex.Matches(str, patternHour);

                if (matchList4.Count == 0)
                {
                    matchList4 = Regex.Matches(str, @"(?<=Ad\ posted\ </span>)[\w\W]*?(?=<)");
                }

                for (int i = 0; i < matchList2.Count; i++)
                {
                    try
                    {
                        Console.WriteLine(matchList2[i].Value);
                        Console.WriteLine(ValidMatches[i]);
                        Console.WriteLine(matchList4[i].Value);
                        Car car = new Car("https://www.gumtree.com" + matchList2[i].Value.Substring(matchList2[i].Value.IndexOf("/p/")).Replace("\"", "").Replace("\n", ""), ValidMatches[i].Replace("\n", "").Replace("alt=\"", "").Trim(), 0);
                        car.hours = matchList4[i].Value.Replace("\n", "");
                        int hour = Convert.ToInt32(car.hours.Substring(0, car.hours.IndexOf(" ")));
                        bool minutes = car.hours.Contains("mins");
                        bool hourss = car.hours.Contains("hours");
                        if (car.hours.ToLower().Contains("day")) continue;
                        if (hour > HomeController.Hours && hourss) continue;
                        listCars.Add(car);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            await CheckCarsAsync();   
            listCars.Clear();
            Console.WriteLine("");
        }

        public string TestRequest(string url)
        {
            // Create a new request to the mentioned URL.        
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);

            // Obtain the 'Proxy' of the  Default browser.
            IWebProxy _proxy = myWebRequest.Proxy;
            // Print the Proxy Url to the console.
            if (_proxy != null)
            {
                Console.WriteLine("Proxy: {0}", _proxy.GetProxy(myWebRequest.RequestUri));
            }
            else
            {
                Console.WriteLine("Proxy is null; no proxy will be used");
            }

            var p = proxy.Split('@');
            var p2 = p[0].Split(':');

            WebProxy myProxy = new WebProxy();

            Console.WriteLine("\nPlease enter the new Proxy Address that is to be set:");
            Console.WriteLine("(Example:http://myproxy.example.com:port)");
            string proxyAddress;

            try
            {
                proxyAddress = "http://" + p[1];
                if (proxyAddress.Length > 0)
                {
                    Console.WriteLine("\nPlease enter the Credentials (may not be needed)");
                    Console.WriteLine("Username:");
                    string username = p2[0];
                    //username = Console.ReadLine();
                    Console.WriteLine("\nPassword:");
                    string password = p2[1];
                    //password = Console.ReadLine();
                    // Create a new Uri object.
                    Uri newUri = new Uri(proxyAddress);
                    // Associate the newUri object to 'myProxy' object so that new myProxy settings can be set.
                    myProxy.Address = newUri;
                    // Create a NetworkCredential object and associate it with the
                    // Proxy property of request object.
                    myProxy.Credentials = new NetworkCredential(username, password);
                    myWebRequest.Proxy = myProxy;
                }
                Console.WriteLine("\nThe Address of the  new Proxy settings are {0}", myProxy.Address);
                HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();


                Console.WriteLine("Content length is {0}", myWebResponse.ContentLength);
                Console.WriteLine("Content type is {0}", myWebResponse.ContentType);

                // Get the stream associated with the response.
                Stream receiveStream = myWebResponse.GetResponseStream();

                // Pipes the stream to a higher level stream reader with the required encoding format.
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                Console.WriteLine("Response stream received.");
                //Console.WriteLine(readStream.ReadToEnd());

                return readStream.ReadToEnd();
            }
            catch (Exception ex)
            {

            }
            return "";
        }

        public static string getDataFromServer(string _url, string _referer, string _path)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    WebProxy proxy = new WebProxy("45.147.182.69", 8000);
                    proxy.BypassProxyOnLocal = false;
                    proxy.UseDefaultCredentials = false;
                    proxy.Credentials = new NetworkCredential("CTvjzR", "X8vaca");

                    client.Proxy = proxy;

                    string htmlCode = client.DownloadString(_url);

                    if (string.IsNullOrEmpty(htmlCode))
                    {
                        return getDataFromServer(_url, _referer, _path);
                    }

                    return htmlCode;
                }
            }
            catch (WebException ex)
            {
                ManagerWeb.stringToFile("503", _path);
                ManagerWeb.log(nameof(getDataFromServer), ex.ToString() + "\n\n" + ex.StackTrace);
            }
            catch (Exception ex)
            {
                ManagerWeb.stringToFile("error", _path);
                ManagerWeb.log(nameof(getDataFromServer), "error " + ex.ToString() + "\n\n" + ex.StackTrace);
                return getDataFromServer(_url, _referer, _path);
            }
            return "";
        }
        public static void stringToFile(string str, string path)
        {
            try
            {
                lock (ManagerWeb.STR_TO_FILE_LOCKER)
                    System.IO.File.WriteAllText(path, str);
            }
            catch (Exception ex)
            {
                ManagerWeb.log(nameof(stringToFile), ex.ToString() + ex.StackTrace);
            }
        }

        public static void log(string function, string msg)
        {
            try
            {
                if (!ManagerWeb.DEBUG)
                    return;
                lock (ManagerWeb.LOG_LOCKER)
                {
                    string path = "logs\\JulianParserLog.txt";
                    if (!string.IsNullOrEmpty(path))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(path, true))
                            streamWriter.WriteLine("[" + (object)DateTime.Now + "] " + function + "  " + msg);
                    }
                }
            }
            catch (Exception ex)
            {
                string path = "DLL-Log-Error.txt";
                ManagerWeb.stringToFile("[" + (object)DateTime.Now + "] " + ex.Message + " || " + ex.Source + " || " + ex.StackTrace, path);
            }
        }
        private static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        private static string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                msi.Seek(0, SeekOrigin.Begin);
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }

        public class CookieAwareWebClient : WebClient
        {
            public CookieAwareWebClient()
            {
                CookieContainer = new CookieContainer();
                this.ResponseCookies = new CookieCollection();
            }

            public CookieContainer CookieContainer { get; private set; }
            public CookieCollection ResponseCookies { get; set; }

            protected override WebRequest GetWebRequest(Uri address)
            {
                var request = (HttpWebRequest)base.GetWebRequest(address);
                request.CookieContainer = CookieContainer;
                return request;
            }

            protected override WebResponse GetWebResponse(WebRequest request)
            {
                var response = (HttpWebResponse)base.GetWebResponse(request);
                this.ResponseCookies = response.Cookies;
                return response;
            }
        }
    }
}
