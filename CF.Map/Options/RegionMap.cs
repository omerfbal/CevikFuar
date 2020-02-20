using CF.Model.Entities;

namespace CF.Map.Options
{
    public class RegionMap : BaseMap<Region>
    {
        public RegionMap()
        {
            ToTable("Regions");
            Property(x => x.RegionName).IsRequired().HasMaxLength(100);
            Property(x => x.ListOrder).IsOptional();
        }
    }
}
