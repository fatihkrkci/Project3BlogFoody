using Microsoft.AspNetCore.Mvc;
using Project3BlogFoody.BusinessLayer.Abstract;

namespace Project3BlogFoody.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult ArticleList()
        {
            var values = _articleService.TArticleListWithCategory();
            return View(values);
        }
    }
}
