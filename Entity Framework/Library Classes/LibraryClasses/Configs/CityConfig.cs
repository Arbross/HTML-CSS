using System.Data.Entity.ModelConfiguration;

namespace LibraryClasses
{
    public class CityConfig : EntityTypeConfiguration<City>
    {
        public CityConfig()
        {
            // One to Many
            HasRequired(f => f.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey(f => f.CountryId)
                .WillCascadeOnDelete(false);
        }
    }
}
