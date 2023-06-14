using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class DALModel : DbContext
    {
        public DALModel()
            : base("name=DALModel")
        {
            Database.SetInitializer(new ChatBotInitializer());
        }

        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Categoria> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
