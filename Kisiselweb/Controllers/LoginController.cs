using Microsoft.AspNetCore.Mvc;

namespace Kisiselweb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
