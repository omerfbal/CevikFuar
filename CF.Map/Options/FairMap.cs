using CF.Model.Entities;

namespace CF.Map.Options
{
    public class FairMap : BaseMap<Fair>
    {
        public FairMap()
        {
            ToTable("Fairs");
            Property(x => x.FairName).IsRequired().HasMaxLength(100);
            Property(x => x.FairLogoImagePath).IsRequired().HasMaxLength(500);
            Property(x => x.StartDate).IsRequired().HasColumnType("datetime2");
            Property(x => x.EndDate).IsRequired().HasColumnType("datetime2");
            Property(x => x.InstallDate).IsRequired().HasColumnType("datetime2");
            Property(x => x.HallName).IsRequired().HasMaxLength(50);
            Property(x => x.StandName).IsRequired().HasMaxLength(50);
            Property(x => x.FairSize).IsRequired();
        }
    }
}
