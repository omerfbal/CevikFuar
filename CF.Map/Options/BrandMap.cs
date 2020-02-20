using CF.Model.Entities;

namespace CF.Map.Options
{
    public class BrandMap : BaseMap<Brand>
    {
        public BrandMap()
        {
            ToTable("Brands");
            Property(x => x.BrandName).IsRequired().HasMaxLength(100);
            Property(x => x.LogoImagePath).IsOptional().HasMaxLength(500);
            Property(x => x.ListOrder).IsOptional();
        }
    }
}
