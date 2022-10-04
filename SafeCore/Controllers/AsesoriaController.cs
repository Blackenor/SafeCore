using Microsoft.AspNetCore.Mvc;

namespace SafeCore.Controllers
{
    public class AsesoriaController : Controller
    {
        public IActionResult IngresarAsesoria()
        {
            return View();
        }
        public IActionResult AsesoriaEspecial()
        {
            return View();
        }
    }
}
