using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LNGBaiThucHanh136.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Home";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Xin Chao";

            return View();
        }
    }
}