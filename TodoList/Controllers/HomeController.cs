using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var logger = LogManager.GetCurrentClassLogger();
            logger.InfoFormat("Currently logged user is {0}", User.Identity.Name);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}