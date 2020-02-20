using CF.Model.Entities;

namespace CF.Map.Options
{
    public class VisitorRegionMap : BaseMap<VisitorRegion>
    {
        public VisitorRegionMap()
        {
            ToTable("VisitorRegions");
            Ignore(x => x.Id);
            HasKey(x => new { x.VisitorId, x.RegionId });
        }
    }
}
