using System.Collections.Generic;
using System.Data.Entity;

namespace LibraryClasses
{
    public class DBInitializer : CreateDatabaseIfNotExists<ShopsCFModel>
    {
        protected override void Seed(ShopsCFModel context)
        {
            base.Seed(context);

            context.Countries.Add(new Country() { Id = 1, Name = "Ukraine" });
            context.Countries.Add(new Country() { Id = 2, Name = "England" });
            context.Countries.Add(new Country() { Id = 3, Name = "USA" });
            context.Countries.Add(new Country() { Id = 4, Name = "Poland" });
            context.Countries.Add(new Country() { Id = 5, Name = "Bulgaria" });
            context.Countries.Add(new Country() { Id = 6, Name = "Italy" });

            context.Cities.Add(new City() { Name = "Rivne", CountryId = 1, Id = 1 });
            context.Cities.Add(new City() { Name = "Kiev", CountryId = 1, Id = 2 });
            context.Cities.Add(new City() { Name = "Obzor", CountryId = 5, Id = 3 });
            context.Cities.Add(new City() { Name = "Sofia", CountryId = 5, Id = 4 });
            context.Cities.Add(new City() { Name = "New-York", CountryId = 3, Id = 5 });

            context.Shops.Add(new Shop() { Id = 1, Name = "Yellow", Address = "1", ParkingArea = 500, CityId = 1 });
            context.Shops.Add(new Shop() { Id = 2, Name = "Green", Address = "2", ParkingArea = 700, CityId = 1 });
            context.Shops.Add(new Shop() { Id = 3, Name = "Blue", Address = "3", ParkingArea = null, CityId = 1 });
            context.Shops.Add(new Shop() { Id = 4, Name = "Purple", Address = "4", ParkingArea = 300, CityId = 1 });
            context.Shops.Add(new Shop() { Id = 5, Name = "Red", Address = "5", ParkingArea = 200, CityId = 1 });
            context.Shops.Add(new Shop() { Id = 6, Name = "White", Address = "6", ParkingArea = 600, CityId = 1 });

            context.Categories.Add(new Category() { Name = "True", Id = 1 });
            context.Categories.Add(new Category() { Name = "False", Id = 2 });
            context.Categories.Add(new Category() { Name = "0", Id = 3 });
            context.Categories.Add(new Category() { Name = "1", Id = 4 });
            context.Categories.Add(new Category() { Name = "Techno", Id = 5 });
            context.Categories.Add(new Category() { Name = "Magic", Id = 6 });

            context.Products.Add(new Product() { Name = "Soap", Discount = 50, Price = 800, Quantity = 20, IsInStock = true, CategoryId = 1 });
            context.Products.Add(new Product() { Name = "Knife", Discount = 100, Price = 300, Quantity = 50, IsInStock = false, CategoryId = 1 });
            context.Products.Add(new Product() { Name = "Rubber", Discount = 10, Price = 400, Quantity = 50, IsInStock = true, CategoryId = 2 });
            context.Products.Add(new Product() { Name = "Wood", Discount = 200, Price = 700, Quantity = 50, IsInStock = true, CategoryId = 1 });
            context.Products.Add(new Product() { Name = "Bone", Discount = 80, Price = 30, Quantity = 50, IsInStock = true, CategoryId = 4 });
            context.Products.Add(new Product() { Name = "Chocolate", Discount = 40, Price = 100, Quantity = 50, IsInStock = true, CategoryId = 1 });

            context.Positions.Add(new Position() { Id = 1, Name = "Product Manager" });
            context.Positions.Add(new Position() { Id = 2, Name = "Guardian" });
            context.Positions.Add(new Position() { Id = 3, Name = "Seller" });
            context.Positions.Add(new Position() { Id = 4, Name = "Cleaner" });

            context.Workers.Add(new Worker() { Name = "Norington", Surname = "Kot", PhoneNumber = "1234567890", Salary = 5000, PositionId = 1, Email = "lollo@gmail.com", ShopId = 1 });
            context.Workers.Add(new Worker() { Name = "Tom", Surname = "Not", PhoneNumber = "1234567890", Salary = 2000, PositionId = 1, Email = "lollo@gmail.com", ShopId = 1 });
            context.Workers.Add(new Worker() { Name = "Kin", Surname = "Kot", PhoneNumber = "1234567890", Salary = 3000, PositionId = 1, Email = "lollo@gmail.com", ShopId = 1 });

            context.SaveChanges();
        }
    }
}
