using Microsoft.AspNetCore.Mvc;

namespace Project3BlogFoody.PresentationLayer.ViewComponents
{
    public class _DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
