using System.ComponentModel.DataAnnotations;

namespace Project.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad Alanı Gereklidir!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı Gereklidir!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail Alanı Gereklidir!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Gereklidir!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir!")
        , Compare(nameof(Password), ErrorMessage = "Sifreler Aynı Olmalıdır!")]
        public string ConfirmPassword { get; set; }
    }
}
