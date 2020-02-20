using System;

namespace CF.Model.Entities
{
    public class VisitorSector : BaseEntity
    {
        public Guid VisitorId { get; set; }
        public Guid SectorId { get; set; }

        public virtual Visitor Visitor { get; set; }
        public virtual Sector Sector { get; set; }
    }
}
