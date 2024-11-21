using Microsoft.AspNetCore.Mvc;
using Project3BlogFoody.BusinessLayer.Abstract;

namespace Project3BlogFoody.PresentationLayer.ViewComponents
{
    public class _DefaultCategoryListComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _DefaultCategoryListComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.TGetAll();
            return View(categories);
        }
    }
}
