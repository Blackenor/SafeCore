using Microsoft.AspNetCore.Mvc;

namespace SafeCore.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult ReportClient()
        {
            return View();
        }
        public IActionResult ReportGlobal()
        {
            return View();
        }
        public IActionResult ReportAccidente()
        {
            return View();
        }

        public ActionResult Random2()
        {
            Random numerito = new Random();
            numerito.Next(99999);  
            ViewData["Numero"] = "Su numero id generado es: " + numerito;


            return View();
        }
    }
    
    
}



