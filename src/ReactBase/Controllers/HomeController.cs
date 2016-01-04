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

        public IActionResult ReactIndex()
        {
            var test = Repository.GetAllErrors();
            return View();
        }

        public IActionResult About()
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
            //This works perfectly, will want to keep Controllers in a try/catch
            //We will log the exception to the DB and keep the current output if in Dev Mode
            //Will show a more basic view if in non Dev Mode (do not want to show details - vulnerability)
            return View();
        }
    }
}
