using Microsoft.AspNetCore.Mvc;

namespace SafeCore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
