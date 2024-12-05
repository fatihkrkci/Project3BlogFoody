using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project3BlogFoody.EntityLayer.Concrete;
using Project3BlogFoody.PresentationLayer.Areas.Author.Models;

namespace Project3BlogFoody.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> EditMyProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.Email = values.Email;
            model.Username = values.UserName;
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditMyProfile(UserEditViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = model.Name;
            user.Surname = model.Surname;
            user.Email = model.Email;
            user.UserName = model.Username;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("CategoryList", "Category"/*, new {Area="AreaAdı"}*/);
            }
            return View();
        }
    }
}
