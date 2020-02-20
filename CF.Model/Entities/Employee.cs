using CF.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CF.Model.Entities
{
    public class Employee : BaseEntity
    {
        [Required(ErrorMessage = "İsim girmelisiniz"), Display(Name = "İsim")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyisim girmelisiniz"), Display(Name = "Soyisim")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Lütfen geçerli bir e-posta adresi girin"), Display(Name = "E-Posta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre girmelisiniz"), Display(Name = "Şifre")]
        public string Password { get; set; }

        [NotMapped, Compare("Şifreler uyuşmuyor"), Display(Name = "Şifre Tekrar")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Profil Resmi")]
        public string ProfileImagePath { get; set; }

        [Display(Name = "Kullanıcı Rolü")]
        public Role Role { get; set; }

        [Display(Name = "Son Giriş Zamanı")]
        public DateTime? LastLogin { get; set; }

        [Display(Name = "Durumu")]
        public Active Active { get; set; }
    }
}
