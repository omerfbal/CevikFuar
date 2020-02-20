using CF.Model.Entities;

namespace CF.Map.Options
{
    public class CityMap : BaseMap<City>
    {
        public CityMap()
        {
            ToTable("Cities");
            Property(x => x.CityName).IsRequired().HasMaxLength(100);
            Property(x => x.LicensePlate).IsRequired();
            Property(x => x.ListOrder).IsOptional();
        }
    }
}
