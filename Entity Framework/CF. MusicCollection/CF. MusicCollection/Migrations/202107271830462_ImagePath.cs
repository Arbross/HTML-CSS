namespace CF.MusicCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagePath : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Year = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                        Artist_Id = c.Int(),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artists", t => t.Artist_Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .Index(t => t.Artist_Id)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Surname = c.String(nullable: false, maxLength: 25),
                        Country_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trecks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Duration = c.Time(nullable: false, precision: 7),
                        Rate = c.Int(nullable: false),
                        TreckText = c.String(maxLength: 2000),
                        Listening = c.Int(nullable: false),
                        Album_Id = c.Int(),
                        Playlists_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Playlists", t => t.Playlists_Id)
                .ForeignKey("dbo.Albums", t => t.Album_Id)
                .Index(t => t.Album_Id)
                .Index(t => t.Playlists_Id);
            
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        ImagePath = c.String(),
                        Categoria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Categoria_Id)
                .Index(t => t.Categoria_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trecks", "Album_Id", "dbo.Albums");
            DropForeignKey("dbo.Trecks", "Playlists_Id", "dbo.Playlists");
            DropForeignKey("dbo.Playlists", "Categoria_Id", "dbo.Categories");
            DropForeignKey("dbo.Albums", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Artists", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Albums", "Artist_Id", "dbo.Artists");
            DropIndex("dbo.Playlists", new[] { "Categoria_Id" });
            DropIndex("dbo.Trecks", new[] { "Playlists_Id" });
            DropIndex("dbo.Trecks", new[] { "Album_Id" });
            DropIndex("dbo.Artists", new[] { "Country_Id" });
            DropIndex("dbo.Albums", new[] { "Genre_Id" });
            DropIndex("dbo.Albums", new[] { "Artist_Id" });
            DropTable("dbo.Categories");
            DropTable("dbo.Playlists");
            DropTable("dbo.Trecks");
            DropTable("dbo.Genres");
            DropTable("dbo.Countries");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
