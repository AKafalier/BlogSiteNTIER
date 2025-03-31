using BlogSite.Business;
using BlogSite.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogSite.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IPostService _postService;
        private readonly ICvItemService _cvItemService;
        private readonly IUserService _userService;

        public AdminController(IPostService postService, ICvItemService cvItemService, IUserService userService)
        {
            _postService = postService;
            _cvItemService = cvItemService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var posts = _postService.GetAll();
            return View(posts);
        }

        public IActionResult CvItems()
        {
            var items = _cvItemService.GetAll();
            return View(items);
        }
    }
}
