using ecommerce.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecommerce.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            return View(model.CreateModel());
        }

        public ActionResult About()
        {
            ViewBag.Message = "C'est une espace de vente en ligne ";

            return View();
        }

    }
}