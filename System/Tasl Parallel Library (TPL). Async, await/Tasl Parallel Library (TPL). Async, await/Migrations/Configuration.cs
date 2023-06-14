namespace Tasl_Parallel_Library__TPL_.Async__await.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Tasl_Parallel_Library__TPL_.Async__await.TPLModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Tasl_Parallel_Library__TPL_.Async__await.TPLModel";
        }

        protected override void Seed(Tasl_Parallel_Library__TPL_.Async__await.TPLModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
