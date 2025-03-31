using BlogSite.Business;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
