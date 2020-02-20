using CF.Model.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CF.Model.Entities
{
    public class Product : BaseEntity
    {
        [Required(ErrorMessage = "Ürün grubunu girmelisiniz"), Display(Name = "Ürün Grubu")]
        public string ProductName { get; set; }

        [Display(Name = "Gösterim Sırası")]
        public int ListOrder { get; set; }

        [Display(Name = "Durumu")]
        public Active Active { get; set; }

        public virtual List<BrandProduct> BrandProducts { get; set; }
    }
}
