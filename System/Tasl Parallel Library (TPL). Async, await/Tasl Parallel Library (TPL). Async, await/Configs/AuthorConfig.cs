using System.Data.Entity.ModelConfiguration;

namespace Tasl_Parallel_Library__TPL_.Async__await
{
    public class AuthorConfig : EntityTypeConfiguration<Author>
    {
        public AuthorConfig()
        {
            // Set primary key
            HasKey(x => x.Id);

            // Property
            Property(x => x.Name).IsRequired()
                                 .HasMaxLength(100);

            // Property
            Property(x => x.Surname).IsRequired()
                                    .HasMaxLength(100);

            // Many to Many
            //HasMany(x => x.Books).WithMany(x => x.Authors);
        }
    }
}
