using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Areas.Login.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
