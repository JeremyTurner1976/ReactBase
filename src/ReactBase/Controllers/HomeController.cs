using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ReactBase.Data;

namespace ReactBase.Controllers
{
    public class HomeController : Controller
    {
        public Repository Repository { get; set; }

        public HomeController(Repository repository)
        {
            Repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        4
        public IActionResult ReactIndex()
        {
            var test = Repository.GetAllErrors();
            return View();
        }

        public IActionResult About()5
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
