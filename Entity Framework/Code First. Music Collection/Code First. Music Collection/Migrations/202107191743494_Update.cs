namespace Code_First.Music_Collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Albums", "Rate");
            DropColumn("dbo.Trecks", "Rate");
            DropColumn("dbo.Trecks", "TreckText");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trecks", "TreckText", c => c.String());
            AddColumn("dbo.Trecks", "Rate", c => c.Single(nullable: false));
            AddColumn("dbo.Albums", "Rate", c => c.Single(nullable: false));
        }
    }
}
