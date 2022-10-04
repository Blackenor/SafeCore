using Microsoft.AspNetCore.Mvc;

namespace SafeCore.Controllers
{
    public class AdministracionController : Controller
    {
        public IActionResult Actividades()
        {
            return View();
        }
        public IActionResult CalculoA()
        {
            return View();
        }
        public IActionResult PlanificarVisita()
        {
            return View();
        }
        public IActionResult CrearCapacitacion()
        {
            return View();
        }
    }
}
