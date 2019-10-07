using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CEManager.Models;

namespace CEManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserManager()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult CollegeManager()
        {
            return View();
        }

        
        public IActionResult ExpensesManager()
        {
            return View();
        }
        public IActionResult UserInfo()
        {
            return View();
        }
        public IActionResult CollegeInfo()
        {
            return View();
        }
    }
}
