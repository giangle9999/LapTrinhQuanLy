using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LNGBaiThucHanh136.Controllers
{
    public class Bai1Controller : Controller
    {
        // GET: Bai1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Bai1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Bai1(string Masinhvien, string Hoten, string Lop)
        {
            ViewBag.Thongtin = Masinhvien + "" + Hoten + "" + Lop;
            return View();
        }
    }
}