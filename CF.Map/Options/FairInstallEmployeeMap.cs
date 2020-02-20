using CF.Model.Entities;

namespace CF.Map.Options
{
    public class FairInstallEmployeeMap : BaseMap<FairInstallEmployee>
    {
        public FairInstallEmployeeMap()
        {
            ToTable("FairInstallEmployees");
            Ignore(x => x.Id);
            HasKey(x => new { x.FairId, x.EmployeeId });
        }
    }
}
