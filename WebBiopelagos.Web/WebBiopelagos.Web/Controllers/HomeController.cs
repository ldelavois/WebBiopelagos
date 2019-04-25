using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBiopelagos.Web.Models;

namespace WebBiopelagos.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "À propos de BIOPELAGOS";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Nous contacter";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Geojson()
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
