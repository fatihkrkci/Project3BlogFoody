using Microsoft.AspNetCore.Mvc;

namespace Project3BlogFoody.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
