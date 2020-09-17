using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTN_QL_MamNon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() 
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
