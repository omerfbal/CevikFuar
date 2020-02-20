using CF.Model;
using System.Data.Entity.ModelConfiguration;

namespace CF.Map
{
    public class BaseMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap()
        {
            Property(x => x.CreatedDate).IsRequired();
            Property(x => x.CreatedBy).IsRequired();
            Property(x => x.ModifiedDate).IsOptional();
            Property(x => x.ModifiedBy).IsOptional();
            Property(x => x.RemovedDate).IsOptional();
            Property(x => x.RemovedBy).IsOptional();
            Property(x => x.Status).IsRequired();
        }
    }
}
