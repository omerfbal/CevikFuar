using CF.Model.Entities;

namespace CF.Map.Options
{
    public class VisitorBrandMap : BaseMap<VisitorBrand>
    {
        public VisitorBrandMap()
        {
            ToTable("VisitorBrands");
            Ignore(x => x.Id);
            HasKey(x => new { x.VisitorId, x.BrandId });
        }
    }
}
