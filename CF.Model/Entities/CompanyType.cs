using CF.Model.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CF.Model.Entities
{
    public class CompanyType : BaseEntity
    {
        [Required(ErrorMessage = "Faaliyet adını girmelisiniz"), Display(Name = "Faaliyet Adı")]
        public string Name { get; set; }

        [Display(Name = "Gösterim Sırası")]
        public int ListOrder { get; set; }

        [Display(Name = "Durumu")]
        public Active Active { get; set; }

        public virtual List<VisitorCompanyType> VisitorCompanyTypes { get; set; }
    }
}