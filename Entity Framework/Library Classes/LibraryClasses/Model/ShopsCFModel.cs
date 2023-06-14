using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LibraryClasses
{
    public partial class ShopsCFModel : DbContext
    {
        public ShopsCFModel()
            : base("name=ShopsCFEntities")
        {
            Database.SetInitializer<ShopsCFModel>(new DBInitializer());
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add Configuration Classes
            modelBuilder.Configurations.Add(new ShopConfig());
            modelBuilder.Configurations.Add(new Configs.ProductsConfig());
            modelBuilder.Configurations.Add(new Configs.WorkerConfig());
            modelBuilder.Configurations.Add(new CityConfig());
        }
    }
}
