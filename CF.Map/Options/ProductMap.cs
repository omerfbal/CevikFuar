using CF.Model.Entities;

namespace CF.Map.Options
{
    public class ProductMap : BaseMap<Product>
    {
        public ProductMap()
        {
            ToTable("Products");
            Property(x => x.ProductName).IsRequired().HasMaxLength(100);
            Property(x => x.ListOrder).IsOptional();
        }
    }
}
