using CF.Model.Entities;

namespace CF.Map.Options
{
    public class TownMap : BaseMap<Town>
    {
        public TownMap()
        {
            ToTable("Towns");
            Property(x => x.TownName).IsRequired().HasMaxLength(100);
            Property(x => x.ListOrder).IsOptional();
        }
    }
}
