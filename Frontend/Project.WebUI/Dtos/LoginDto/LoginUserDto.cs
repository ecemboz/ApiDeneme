﻿using System.ComponentModel.DataAnnotations;

namespace Project.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullanıcı adını giriniz!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre giriniz!")]
        public string Password { get; set; }
    }
}
