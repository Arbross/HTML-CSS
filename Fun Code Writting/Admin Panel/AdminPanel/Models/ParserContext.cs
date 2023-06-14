using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Models
{
    public class ParserContext : DbContext
    {
        public ParserContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=217.28.223.127,17160;User Id=user_07348;Password=sA_4+8YdPx6;Database=db_2b8fa;");
        }

        public DbSet<Link> Links { get; set; }
        public DbSet<BadLink> BadLinks { get; set; }
        public DbSet<Proxy> Proxies { get; set; }
    }
}
