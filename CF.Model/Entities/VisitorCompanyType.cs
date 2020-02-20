using System;

namespace CF.Model.Entities
{
    public class VisitorCompanyType : BaseEntity
    {
        public Guid VisitorId { get; set; }
        public Guid CompanyTypeId { get; set; }

        public virtual Visitor Visitor { get; set; }
        public virtual CompanyType CompanyType { get; set; }
    }
}
