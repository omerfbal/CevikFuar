using CF.Model.Entities;

namespace CF.Map.Options
{
    public class FairAreaImageMap : BaseMap<FairAreaImage>
    {
        public FairAreaImageMap()
        {
            ToTable("FairAreaImages");
            Property(x => x.ImageName).IsRequired().HasMaxLength(100);
            Property(x => x.ImagePath).IsRequired().HasMaxLength(500);
        }
    }
}
