using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.PowerBI.Api.Models;
using Project.WebUI.Dtos.RegisterDto;
using Project.EntityLayer.Concrete;

namespace Project.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<EntityLayer.Concrete.AppUser> _userManager;

        public RegisterController(UserManager<EntityLayer.Concrete.AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new EntityLayer.Concrete.AppUser()
            {
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                Surname = createNewUserDto.Surname,
                UserName = createNewUserDto.Username
            };

            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }
    }
}
