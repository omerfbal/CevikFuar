using System;

namespace CF.Model.Entities
{
    public class VisitorRegion : BaseEntity
    {
        public Guid VisitorId { get; set; }
        public Guid RegionId { get; set; }

        public virtual Visitor Visitor { get; set; }
        public virtual Region Region { get; set; }
    }
}
