using CF.Model.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CF.Model.Entities
{
    public class Region : BaseEntity
    {
        [Required(ErrorMessage = "Bölge adını girmelisiniz"), Display(Name = "Bölge Adı")]
        public string RegionName { get; set; }

        [Display(Name = "Gösterim Sırası")]
        public int ListOrder { get; set; }

        [Display(Name = "Durumu")]
        public Active Active { get; set; }

        public virtual List<VisitorRegion> VisitorRegions { get; set; }
    }
}
