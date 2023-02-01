using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Controllers
{
    public class GradeCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GradeCalc()
        {
            return View();
        }
    }
}
