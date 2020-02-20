using CF.Model.Entities;

namespace CF.Map.Options
{
    public class FairAttendantEmployeeMap : BaseMap<FairAttendantEmployee>
    {
        public FairAttendantEmployeeMap()
        {
            ToTable("FairAttendantEmployees");
            Ignore(x => x.Id);
            HasKey(x => new { x.FairId, x.EmployeeId });
        }
    }
}
