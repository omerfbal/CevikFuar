using System;

namespace CF.Model.Entities
{
    public class FairAttendantEmployee : BaseEntity
    {
        public Guid EmployeeId { get; set; }
        public Guid FairId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Fair Fair { get; set; }
    }
}
