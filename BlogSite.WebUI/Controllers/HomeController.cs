using BlogSite.Business;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogSite.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        private readonly ICvItemService _cvItemService;

        public HomeController(IPostService postService, ICvItemService cvItemService)
        {
            _postService = postService;
            _cvItemService = cvItemService;
        }

        public IActionResult Index()
        {
            var posts = _postService.GetAll().OrderByDescending(p => p.CreatedDate).ToList();
            return View(posts);
        }

        public IActionResult Cv()
        {
            var cvItems = _cvItemService.GetAll().OrderBy(c => c.Order).ToList();
            return View(cvItems);
        }
    }
}
