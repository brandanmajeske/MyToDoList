using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyToDoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Info about the app.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is my contact info.";

            return View();
        }
    }
}