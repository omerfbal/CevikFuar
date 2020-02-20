using CF.Model.Entities;

namespace CF.Map.Options
{
    public class VisitorMap : BaseMap<Visitor>
    {
        public VisitorMap()
        {
            ToTable("Visitors");
            Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            Property(x => x.LastName).IsRequired().HasMaxLength(100);
            Property(x => x.CompanyName).IsRequired().HasMaxLength(100);
            Property(x => x.Position).IsOptional().HasMaxLength(100);
            Property(x => x.PhoneNumber).IsOptional().HasMaxLength(20);
            Property(x => x.Address).IsOptional().HasMaxLength(500);
            Property(x => x.Note).IsOptional().HasMaxLength(1000);
            Property(x => x.BusinessCardImagePath).IsOptional().HasMaxLength(500);
            Property(x => x.Email).IsRequired().HasMaxLength(100);
        }
    }
}
