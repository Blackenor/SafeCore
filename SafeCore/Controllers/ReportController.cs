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
    }
}
