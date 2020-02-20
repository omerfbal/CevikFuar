using System;

namespace CF.Model.Entities
{
    public class VisitorBrand : BaseEntity
    {
        public Guid VisitorId { get; set; }
        public Guid BrandId { get; set; }

        public virtual Visitor Visitor { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
