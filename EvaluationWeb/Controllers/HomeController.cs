using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EvaluationWeb.Models;

namespace EvaluationWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

        public IActionResult UserCenter()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult EvalCenter()
        {
            return View();
        }
        public IActionResult EvalPlan()
        {
            return View();
        }
        public IActionResult EvalStart()
        {
            return View();
        }
        public IActionResult EvalPlanSetting()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
