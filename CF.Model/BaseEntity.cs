using CF.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CF.Model
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Status = Status.Created;
        }

        public Guid Id { get; set; }

        [Display(Name = "Oluşturma Tarihi")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Oluşturan")]
        public Guid CreatedBy { get; set; }

        [Display(Name = "Değiştirme Tarihi")]
        public DateTime? ModifiedDate { get; set; }

        [Display(Name = "Değiştiren")]
        public Guid ModifiedBy { get; set; }

        [Display(Name = "Silen")]
        public Guid RemovedBy { get; set; }

        [Display(Name = "Silinme Tarihi")]
        public DateTime? RemovedDate { get; set; }

        [Display(Name = "Veri Durumu")]
        public Status Status { get; set; }
    }
}
