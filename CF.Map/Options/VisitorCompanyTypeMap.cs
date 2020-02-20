using CF.Model.Entities;

namespace CF.Map.Options
{
    public class VisitorCompanyTypeMap : BaseMap<VisitorCompanyType>
    {
        public VisitorCompanyTypeMap()
        {
            ToTable("VisitorCompanyTypes");
            Ignore(x => x.Id);
            HasKey(x => new { x.VisitorId, x.CompanyTypeId });
        }
    }
}
