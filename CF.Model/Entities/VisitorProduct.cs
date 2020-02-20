using System;

namespace CF.Model.Entities
{
    public class VisitorProduct : BaseEntity
    {
        public Guid VisitorId { get; set; }
        public Guid ProductId { get; set; }

        public virtual Visitor Visitor { get; set; }
        public virtual Product Product { get; set; }
    }
}
