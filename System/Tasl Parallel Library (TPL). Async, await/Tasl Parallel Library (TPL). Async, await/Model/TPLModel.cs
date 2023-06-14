using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace Tasl_Parallel_Library__TPL_.Async__await
{
    public partial class TPLModel : DbContext
    {
        public TPLModel()
            : base("name=TPLModel")
        {
            Database.SetInitializer(new DBInitializer());
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
