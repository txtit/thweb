using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using taoGioHang.Models;

namespace taoGioHang.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductModel db = new ProductModel();
            return View(db.FindAll().ToList()) ;
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