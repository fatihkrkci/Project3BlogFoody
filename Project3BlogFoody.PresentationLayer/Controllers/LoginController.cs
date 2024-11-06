using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project3BlogFoody.EntityLayer.Concrete;
using System.Runtime.CompilerServices;

namespace Project3BlogFoody.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
