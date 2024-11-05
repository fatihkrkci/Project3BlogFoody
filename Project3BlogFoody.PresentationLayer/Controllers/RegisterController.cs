using Microsoft.AspNetCore.Mvc;

namespace Project3BlogFoody.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
