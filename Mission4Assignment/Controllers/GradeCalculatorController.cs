using Microsoft.AspNetCore.Mvc;
using Mission4Assignment.Models;

namespace Mission4Assignment.Controllers
{
    public class GradeCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GradeCalc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeCalc(GradeCalcModel model)
        {
            return View();
        }
    }
}
