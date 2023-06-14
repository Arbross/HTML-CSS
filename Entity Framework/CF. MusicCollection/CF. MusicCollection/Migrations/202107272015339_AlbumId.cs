namespace CF.MusicCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlbumId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Trecks", name: "Album_Id", newName: "AlbumId");
            RenameIndex(table: "dbo.Trecks", name: "IX_Album_Id", newName: "IX_AlbumId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Trecks", name: "IX_AlbumId", newName: "IX_Album_Id");
            RenameColumn(table: "dbo.Trecks", name: "AlbumId", newName: "Album_Id");
        }
    }
}
