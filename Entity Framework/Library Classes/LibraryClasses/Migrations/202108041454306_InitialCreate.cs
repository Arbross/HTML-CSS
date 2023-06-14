namespace LibraryClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Single(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        IsInStock = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 20),
                        CityId = c.Int(nullable: false),
                        ParkingArea = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Surname = c.String(nullable: false, maxLength: 20),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Email = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                        PositionId = c.Int(nullable: false),
                        ShopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Positions", t => t.PositionId)
                .ForeignKey("dbo.Shops", t => t.ShopId)
                .Index(t => t.PositionId)
                .Index(t => t.ShopId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductShops",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Shop_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Shop_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Shops", t => t.Shop_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Shop_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductShops", "Shop_Id", "dbo.Shops");
            DropForeignKey("dbo.ProductShops", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Workers", "ShopId", "dbo.Shops");
            DropForeignKey("dbo.Workers", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Shops", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ProductShops", new[] { "Shop_Id" });
            DropIndex("dbo.ProductShops", new[] { "Product_Id" });
            DropIndex("dbo.Workers", new[] { "ShopId" });
            DropIndex("dbo.Workers", new[] { "PositionId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.Shops", new[] { "CityId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.ProductShops");
            DropTable("dbo.Positions");
            DropTable("dbo.Workers");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Shops");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
