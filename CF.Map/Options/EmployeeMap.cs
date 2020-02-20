using CF.Model.Entities;

namespace CF.Map.Options
{
    public class EmployeeMap : BaseMap<Employee>
    {
        public EmployeeMap()
        {
            ToTable("Employees");
            Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            Property(x => x.LastName).IsRequired().HasMaxLength(100);
            Property(x => x.Email).IsRequired().HasMaxLength(100);
            Property(x => x.Password).IsRequired().HasMaxLength(100);
            Ignore(x => x.ConfirmPassword);
            Property(x => x.ProfileImagePath).IsOptional().HasMaxLength(500);
            Property(x => x.Role).IsOptional();
            Property(x => x.LastLogin).IsOptional();
        }
    }
}
