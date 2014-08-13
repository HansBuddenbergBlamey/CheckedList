using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckedListBox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        [HttpPost]
        public ActionResult Index(string[] MyCheckList)
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            ViewBag.Checks = MyCheckList;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Checks(string[] values, string name)
        {
            ViewBag.Name = name;
            return View(values);
        }
    }
}
