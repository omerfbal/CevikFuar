using CF.Model.Entities;

namespace CF.Map.Options
{
    public class BrandProductMap : BaseMap<BrandProduct>
    {
        public BrandProductMap()
        {
            ToTable("BrandProducts");
            Ignore(x => x.Id);
            HasKey(x => new { x.BrandId, x.ProductId });
        }
    }
}
