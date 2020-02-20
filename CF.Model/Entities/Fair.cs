using CF.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CF.Model.Entities
{
    public class Fair : BaseEntity
    {
        [Required(ErrorMessage = "Fuar adınızı girmelisiniz"), Display(Name = "Fuar Adı")]
        public string FairName { get; set; }

        [Required(ErrorMessage = "Fuar logosunu seçmelisiniz"), Display(Name = "Fuar Logosu")]
        public string FairLogoImagePath { get; set; }

        [Required(ErrorMessage = "Fuar başlangıç tarihini girmelisiniz"), Display(Name = "Fuar Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Fuar bitiş tarihini girmelisiniz"), Display(Name = "Fuar Bitiş Tarihi")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Fuar başlangıç tarihini girmelisiniz"), Display(Name = "Fuar Başlangıç Tarihi")]
        public DateTime InstallDate { get; set; }

        [Required(ErrorMessage = "Salon adını girmelisiniz"), Display(Name = "Salon Adı")]
        public string HallName { get; set; }

        [Required(ErrorMessage = "Stant numarasını girmelisiniz"), Display(Name = "Stant Numarası")]
        public string StandName { get; set; }

        [Required(ErrorMessage = "Stant ölçüsünü girmelisiniz"), Display(Name = "Stant Ölçüsü")]
        public decimal FairSize { get; set; }

        [Display(Name = "Durumu")]
        public Active Active { get; set; }

        public Guid FairAreaId { get; set; }

        public virtual FairArea FairArea { get; set; }
        public virtual List<FairAreaImage> FairAreaImages { get; set; }
        public virtual List<FairInstallEmployee> FairInstallEmployees { get; set; }
        public virtual List<FairAttendantEmployee> FairAttendantEmployees { get; set; }
        public virtual List<Visitor> Visitors { get; set; }
    }
}
