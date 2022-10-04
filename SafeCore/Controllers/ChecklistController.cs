using Microsoft.AspNetCore.Mvc;

namespace SafeCore.Controllers
{
    public class ChecklistController : Controller
    {
        public IActionResult Crearcheck()
        {
            return View();
        }
        public IActionResult Responder()
        {
            return View();
        }
    }
}
