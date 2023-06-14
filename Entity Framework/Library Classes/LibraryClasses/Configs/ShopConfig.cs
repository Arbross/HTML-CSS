using System.Data.Entity.ModelConfiguration;

namespace LibraryClasses
{
    public class ShopConfig : EntityTypeConfiguration<Shop>
    {
        public ShopConfig()
        {
            // One to Many
            HasRequired(f => f.City)
                .WithMany(c => c.Shops)
                .HasForeignKey(f => f.CityId)
                .WillCascadeOnDelete(false);
        }
    }
}
