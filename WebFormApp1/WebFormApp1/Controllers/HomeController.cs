using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WebFormApp1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            return base.View();
        }
        public ActionResult MyIndex()
        {
            base.ViewBag.Title = "My Home Page";
            return base.View();
        }
        public ActionResult Contact()
        {
            base.ViewBag.Title = "My Contact Page";
            return base.View();
        }
    }  
}
