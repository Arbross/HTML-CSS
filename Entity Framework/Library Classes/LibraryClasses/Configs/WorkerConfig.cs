using System.Data.Entity.ModelConfiguration;

namespace LibraryClasses.Configs
{
    public class WorkerConfig : EntityTypeConfiguration<Worker>
    {
        public WorkerConfig()
        {
            // One to Many
            HasRequired(f => f.Position)
                .WithMany(c => c.Workers)
                .HasForeignKey(f => f.PositionId)
                .WillCascadeOnDelete(false);

            HasRequired(f => f.Shop)
                .WithMany(c => c.Workers)
                .HasForeignKey(f => f.ShopId)
                .WillCascadeOnDelete(false);
        }
    }
}
