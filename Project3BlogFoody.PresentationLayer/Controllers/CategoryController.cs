using Microsoft.AspNetCore.Mvc;
using Project3BlogFoody.BusinessLayer.Abstract;

namespace Project3BlogFoody.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetAll();

            return View(values);
        }
    }
}
