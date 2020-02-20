using CF.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CF.Model.Entities
{
    public class Town : BaseEntity
    {
        [Required(ErrorMessage = "İlçe adını girmelisiniz"), Display(Name = "İlçe Adı")]
        public string TownName { get; set; }

        [Display(Name = "Gösterim Sırası")]
        public int ListOrder { get; set; }

        [Display(Name = "Durumu")]
        public Active Active { get; set; }

        public Guid CityId { get; set; }

        public virtual City City { get; set; }
    }
}
