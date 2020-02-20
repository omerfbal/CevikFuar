using CF.Model.Entities;

namespace CF.Map.Options
{
    public class VisitorProductMap : BaseMap<VisitorProduct>
    {
        public VisitorProductMap()
        {
            ToTable("VisitorProducts");
            Ignore(x => x.Id);
            HasKey(x => new { x.VisitorId, x.ProductId });
        }
    }
}
