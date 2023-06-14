using AdminPanel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace AdminPanel.Infrastructure
{
    public class Database
    {
        public static List<Link> GetLinks()
        {
            using(var db = new ParserContext())
            {
                var links = db.Links.ToList();
                return links;
            }
        }

        public static List<Proxy> GetProxies()
        {
            using (var db = new ParserContext())
            {
                var proxies = db.Proxies.ToList();
                return proxies;
            }
        }

        public static List<BadLink> GetBadLinks()
        {
            using (var db = new ParserContext())
            {
                var badLinks = db.BadLinks.ToList();
                return badLinks;
            }
        }
        public static void Test()
        {
            using (var context = new ParserContext())
            {
                var links = File.ReadAllText(@"C:\Users\Алёна\Desktop\links.txt").Split(';');
                foreach (var l in links)
                {
                    if (!string.IsNullOrEmpty(l))
                    {
                        Debug.Write(l);
                        var s = l.Split(',');
                        context.Links.Add(new Link
                        {
                            Name = s[0],
                            Url = s[1],
                            Status = true
                        });
                    }

                }
                var badlinks = File.ReadAllText(@"C:\Users\Алёна\Desktop\badlinks.txt").Split(';');
                foreach (var l in badlinks)
                {
                    if (!string.IsNullOrEmpty(l))
                    {
                        Debug.Write(l);

                        context.BadLinks.Add(new BadLink
                        {
                            Url = l,
                        });
                    }

                }
                var proxy = File.ReadAllText(@"C:\Users\Алёна\Desktop\proxy.txt").Split(';');
                foreach (var l in proxy)
                {
                    if (!string.IsNullOrEmpty(l))
                    {
                        Debug.Write(l);

                        context.Proxies.Add(new Proxy
                        {
                            Host = l
                        });
                    }

                }
                context.SaveChanges();
            }

        }
        public static Link FindLink(Guid id)
        {
            using (var db = new ParserContext())
            {
                var link = db.Links.Find(id);
                return link;
            }
        }

        public static BadLink FindBadLinks(Guid id)
        {
            using (var db = new ParserContext())
            {
                var badLink = db.BadLinks.Find(id);
                return badLink;
            }
        }

        public static async void InsertLink(Link link)
        {
            using (var db = new ParserContext())
            {
                db.Links.Add(link);
                await db.SaveChangesAsync();
            }
        }

        public static async void InsertBadLink(BadLink badLink)
        {
            using (var db = new ParserContext())
            {
                db.BadLinks.Add(badLink);
                await db.SaveChangesAsync();
            }
        }

        public static async void InsertProxy(Proxy proxy)
        {
            using (var db = new ParserContext())
            {
                db.Proxies.Add(proxy);
                await db.SaveChangesAsync();
            }
        }

        public static async void DeleteLink(Guid id)
        {
            using (var db = new ParserContext())
            {
                db.Links.Remove(db.Links.Find(id));
                await db.SaveChangesAsync();
            }
        }

        public static async void DeleteBadLink(Guid id)
        {
            using (var db = new ParserContext())
            {
                db.BadLinks.Remove(db.BadLinks.Find(id));
                await db.SaveChangesAsync();
            }
        }

        public static async void DeleteProxy(Guid id)
        {
            using (var db = new ParserContext())
            {
                db.Proxies.Remove(db.Proxies.Find(id));
                await db.SaveChangesAsync();
            }
        }

        public static async void UpdateLink(Link link)
        {
            using (var db = new ParserContext())
            {
                db.Entry(link).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }

        public static async void UpdateBadLink(BadLink badLink)
        {
            using (var db = new ParserContext())
            {
                db.Entry(badLink).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }

        public static async void UpdateProxy(Proxy proxy)
        {
            using (var db = new ParserContext())
            {
                db.Entry(proxy).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }
    }
}
