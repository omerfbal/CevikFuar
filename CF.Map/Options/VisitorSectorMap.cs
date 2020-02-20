using CF.Model.Entities;

namespace CF.Map.Options
{
    public class VisitorSectorMap : BaseMap<VisitorSector>
    {
        public VisitorSectorMap()
        {
            ToTable("VisitorSectors");
            Ignore(x => x.Id);
            HasKey(x => new { x.VisitorId, x.SectorId });
        }
    }
}
