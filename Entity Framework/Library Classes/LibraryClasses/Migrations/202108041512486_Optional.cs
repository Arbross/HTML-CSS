namespace LibraryClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Optional : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Products", new[] { "CategoryId" });
            AlterColumn("dbo.Products", "CategoryId", c => c.Int());
            CreateIndex("dbo.Products", "CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "CategoryId" });
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryId");
        }
    }
}
