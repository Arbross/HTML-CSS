namespace CF.MusicCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changes : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Playlists", name: "Categoria_Id", newName: "Category_Id");
            RenameColumn(table: "dbo.Trecks", name: "Playlists_Id", newName: "Playlist_Id");
            RenameIndex(table: "dbo.Playlists", name: "IX_Categoria_Id", newName: "IX_Category_Id");
            RenameIndex(table: "dbo.Trecks", name: "IX_Playlists_Id", newName: "IX_Playlist_Id");
            DropColumn("dbo.Trecks", "Rate");
            DropColumn("dbo.Trecks", "TreckText");
            DropColumn("dbo.Trecks", "Listening");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trecks", "Listening", c => c.Int(nullable: false));
            AddColumn("dbo.Trecks", "TreckText", c => c.String(maxLength: 2000));
            AddColumn("dbo.Trecks", "Rate", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Trecks", name: "IX_Playlist_Id", newName: "IX_Playlists_Id");
            RenameIndex(table: "dbo.Playlists", name: "IX_Category_Id", newName: "IX_Categoria_Id");
            RenameColumn(table: "dbo.Trecks", name: "Playlist_Id", newName: "Playlists_Id");
            RenameColumn(table: "dbo.Playlists", name: "Category_Id", newName: "Categoria_Id");
        }
    }
}
