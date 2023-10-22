using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPractica2.Controllers
{
    public class HomeController : Controller
    {

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //This controller has views

        public ActionResult RegisVendedores()
        {
            return View();
        }

        public ActionResult RegisVehiculos()
        {
            return View();
        }

        public ActionResult ConsulVehiculos()  
        { 
            return View(); 
        }

    }
}