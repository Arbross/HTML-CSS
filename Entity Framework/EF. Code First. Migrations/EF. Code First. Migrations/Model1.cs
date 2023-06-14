using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EF.Code_First.Migrations
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=MusicCollectionModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
