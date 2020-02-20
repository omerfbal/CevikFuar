using CF.Model.Entities;

namespace CF.Map.Options
{
    public class SectorMap : BaseMap<Sector>
    {
        public SectorMap()
        {
            ToTable("Sectors");
            Property(x => x.SectorName).IsRequired().HasMaxLength(100);
            Property(x => x.ListOrder).IsOptional();
        }
    }
}
