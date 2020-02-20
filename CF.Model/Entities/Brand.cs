using CF.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace CF.Model.Entities
{
    public class Brand : BaseEntity
    {
        [Required(ErrorMessage = "Marka adını girmelisiniz"), Display(Name = "Marka Adı")]
        public string BrandName { get; set; }

        [Display(Name = "Marka Logosu")]
        public string LogoImagePath { get; set; }

        [Display(Name = "Gösterim Sırası")]
        public int ListOrder { get; set; }

        [Display(Name = "Durumu")]
        public Active Active { get; set; }

        public virtual List<BrandProduct> BrandProducts { get; set; }
    }
}