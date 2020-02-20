using CF.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CF.Model.Entities
{
    public class Visitor : BaseEntity
    {
        [Required(ErrorMessage = "Ziyaretçi adını girmelisiniz"), Display(Name = "Ziyaretçi Adı")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Ziyaretçi soyadını girmelisiniz"), Display(Name = "Ziyaretçi Soyadı")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Firma adını girmelisiniz"), Display(Name = "Firma Adı")]
        public string CompanyName { get; set; }

        [Display(Name = "Ziyaretçi Ünvanı")]
        public string Position { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Firma Adresi")]
        public string Address { get; set; }

        [Display(Name = "Not")]
        public string Note { get; set; }

        [Display(Name = "Kartvizit Görseli")]
        public string BusinessCardImagePath { get; set; }

        [Required(ErrorMessage = "E-Posta adresini girmelisiniz"), Display(Name = "E-Posta")]
        public string Email { get; set; }

        [Display(Name = "Durumu")]
        public Active Active { get; set; }

        public Guid NewsletterLeaveCode { get; set; }
        public bool NewsletterActive { get; set; }
        public Guid ResponsibleEmployeeId { get; set; }
        public Guid FairId { get; set; }
        public Guid CityId { get; set; }
        public Guid TownId { get; set; }

        public virtual Employee ResponsibleEmployee { get; set; }
        public virtual Fair Fair { get; set; }
        public virtual List<VisitorBrand> VisitorBrands { get; set; }
        public virtual List<VisitorProduct> VisitorProducts { get; set; }
        public virtual List<VisitorSector> VisitorSectors { get; set; }
        public virtual List<VisitorRegion> VisitorRegions { get; set; }
        public virtual List<VisitorCompanyType> VisitorCompanyTypes { get; set; }
    }
}
