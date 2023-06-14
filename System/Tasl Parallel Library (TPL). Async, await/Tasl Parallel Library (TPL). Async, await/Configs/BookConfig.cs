using System.Data.Entity.ModelConfiguration;

namespace Tasl_Parallel_Library__TPL_.Async__await
{
    public class BookConfig : EntityTypeConfiguration<Book>
    {
        public BookConfig()
        {
            // Set primary key
            HasKey(x => x.Id);

            // Property
            Property(x => x.BookName).IsRequired()
                                     .HasMaxLength(100);

            // Many to Many
            //HasMany(x => x.Authors).WithMany(x => x.Books);
        }
    }
}
