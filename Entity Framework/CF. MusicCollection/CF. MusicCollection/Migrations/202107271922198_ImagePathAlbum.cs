namespace CF.MusicCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagePathAlbum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "ImagePath", c => c.String());
            DropColumn("dbo.Albums", "Rate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Albums", "Rate", c => c.Int(nullable: false));
            DropColumn("dbo.Albums", "ImagePath");
        }
    }
}
