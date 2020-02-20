using CF.Model.Entities;

namespace CF.Map.Options
{
    public class CompanyTypeMap : BaseMap<CompanyType>
    {
        public CompanyTypeMap()
        {
            ToTable("CompanyTypes");
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.ListOrder).IsOptional();
        }
    }
}
