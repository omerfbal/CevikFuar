using System;
using System.ComponentModel.DataAnnotations;

namespace CF.Model.Entities
{
    public class FairAreaImage : BaseEntity
    {
        [Required(ErrorMessage = "Görsel için isim girmelisiniz"), Display(Name = "Resim Adı")]
        public string ImageName { get; set; }

        [Required(ErrorMessage = "Alan görseli gereklidir"), Display(Name = "Görsel")]
        public string ImagePath { get; set; }

        public Guid FairId { get; set; }

        public virtual Fair Fair { get; set; }
    }
}
