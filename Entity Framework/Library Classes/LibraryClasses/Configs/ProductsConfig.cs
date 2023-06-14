using System.Data.Entity.ModelConfiguration;

namespace LibraryClasses.Configs
{
    public class ProductsConfig : EntityTypeConfiguration<Product>
    {
        public ProductsConfig()
        {
            // One to Many
            HasOptional(f => f.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(f => f.CategoryId)
                .WillCascadeOnDelete(false);

            HasMany(f => f.Shops).WithMany(c => c.Products);
        }
    }
}
