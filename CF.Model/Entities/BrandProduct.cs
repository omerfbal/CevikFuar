using System;

namespace CF.Model.Entities
{
    public class BrandProduct : BaseEntity
    {
        public Guid BrandId { get; set; }
        public Guid ProductId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Product Product { get; set; }
    }
}
