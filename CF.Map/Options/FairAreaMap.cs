using CF.Model.Entities;

namespace CF.Map.Options
{
    public class FairAreaMap : BaseMap<FairArea>
    {
        public FairAreaMap()
        {
            ToTable("FairAreas");
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.Address).IsRequired().HasMaxLength(500);
        }
    }
}
