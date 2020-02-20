using System.ComponentModel.DataAnnotations;

namespace CF.Model.Entities
{
    public class FairArea : BaseEntity
    {
        [Required(ErrorMessage = "Fuar alanını girmelisiniz"), Display(Name = "Fuar Alanı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fuar adresini girmelisiniz"), Display(Name = "Fuar Adresi")]
        public string Address { get; set; }
    }
}
