using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CF.Model.Entities
{
    public class City : BaseEntity
    {
        [Required(ErrorMessage = "İl adını girmelisiniz"), Display(Name = "İl Adı")]
        public string CityName { get; set; }

        [Required(ErrorMessage = "Plaka numarasını girmelisiniz"), Display(Name = "Plaka Numarası")]
        public int LicensePlate { get; set; }

        [Display(Name = "Gösterim Sırası")]
        public int ListOrder { get; set; }

        public virtual List<Town> Towns { get; set; }
    }
}
