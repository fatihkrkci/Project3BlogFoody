using Microsoft.AspNetCore.Mvc;
using Project3BlogFoody.BusinessLayer.Abstract;

namespace Project3BlogFoody.PresentationLayer.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _DefaultSocialMediaComponentPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.TGetAll();
            return View(values);
        }
    }
}
