using CF.Model.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CF.Model.Entities
{
    public class Sector : BaseEntity
    {
        [Required(ErrorMessage = "Sektör adını girmelisiniz"), Display(Name = "Sektör Adı")]
        public string SectorName { get; set; }

        [Display(Name = "Gösterim Sırası")]
        public int ListOrder { get; set; }

        [Display(Name = "Durumu")]
        public Active Active { get; set; }

        public virtual List<VisitorSector> VisitorSectors { get; set; }
    }
}
