using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdminPanel.Models;
using AdminPanel.Service;
using AdminPanel.Infrastructure;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static ParserService Service;
        private HomeViewModel model;
        private static bool IsStarted = false;
        public static int Hours = 1;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
            model = new HomeViewModel
            {
                Hours = Hours,
                Links = Database.GetLinks(),
                IsStarted = IsStarted,
            };
        }

        public IActionResult Proxy()
        {
            var proxies = Database.GetProxies();
            return View(proxies);
        }

        [HttpPost]
        public IActionResult SetHours(int hours = 1)
        {
            Hours = hours;
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(model);
        }

        [HttpPost]
        public IActionResult Start(int interval = 0)
        {
            if (interval != 0 && IsStarted == false)
            {
                var links = Database.GetLinks().Where(x => x.Status).Select(x => x.Url).ToList();
                Service = new ParserService(links, interval);
                Service.Start();
                IsStarted = true;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Ошибка: введите интервал";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Stop()
        {
            Service.Stop();
            IsStarted = false;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteLink(Guid id)
        {
            Database.DeleteLink(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteProxy(Guid id)
        {
            Database.DeleteProxy(id);
            return RedirectToAction("Proxy");
        }
        [HttpPost]
        public IActionResult CreateLink(Link link)
        {
            if (link.Name == null || link.Name == "")
            {
                ViewBag.ErrorMessage = "Ошибка: пустое поле 'Имя'";
                return RedirectToAction("Index");
            }

            if (link.Url == null || link.Url == "")
            {
                ViewBag.ErrorMessage = "Ошибка: пустое поле 'Ссылка'";
                return RedirectToAction("Index");
            }

            Database.InsertLink(link);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddProxy(string proxies)
        {
            var list = new List<Proxy>();
            if (!string.IsNullOrEmpty(proxies))
            {
                var proxiesList = proxies.Split('\n').ToList();
                foreach (var a in proxiesList)
                {

                    if (!string.IsNullOrEmpty(a.Replace("\r", string.Empty)) && a != "\r")
                        list.Add(new Proxy { Host = a.Replace("\r", string.Empty) });
                }
            }
            if (list.Any())
            {
                using (var db = new ParserContext())
                {
                    db.Proxies.AddRange(list);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Proxy");
        }

        [HttpGet]
        public IActionResult EditStatus(Guid id, string status)
        {
            var link = Database.FindLink(id);
            if(status == "on")
            {
                link.Status = true;
                Database.UpdateLink(link);
            }
            else
            {
                link.Status = false;
                Database.UpdateLink(link);
            }
            return RedirectToAction("Index");
        }

        public IActionResult EditLink(Guid id)
        {
            var link = Database.FindLink(id);
            return View(link);
        }
        [HttpPost]
        public IActionResult EditLink(Link link)
        {
            Database.UpdateLink(link);
            return RedirectToAction("Index");   
        }

        public IEnumerable<Link> GetLinks()
        {
            return Database.GetLinks();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
