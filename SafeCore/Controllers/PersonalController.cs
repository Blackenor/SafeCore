using Microsoft.AspNetCore.Mvc;

namespace SafeCore.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult HistorialAtrasos()
        {
            return View();
        }
        public IActionResult Profesionales()
        {
            return View();
        }
        public IActionResult PagosClientes()
        {
            return View();
        }
        public IActionResult Clientes()
        {
            return View();
        }
    }
}
