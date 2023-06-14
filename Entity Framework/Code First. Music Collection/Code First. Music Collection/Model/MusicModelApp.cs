using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Code_First.Music_Collection
{
    [NotMappedAttribute]
    public partial class MusicModelApp : DbContext
    {
        public MusicModelApp()
            : base("name=MusicModelApp")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public virtual DbSet<Artists> Artists { get; set; }
        public virtual DbSet<Trecks> Trecks { get; set; }
        public virtual DbSet<Playlists> Playlists { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Albums> Albums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
