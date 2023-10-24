using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPractica2.Entities;
using WebPractica2.Models;

namespace WebPractica2.Controllers
{
    public class HomeController : Controller
    {
        RegisVenderoresModel VendModel = new RegisVenderoresModel();
        RegisVehiculosModel VehiModel = new RegisVehiculosModel();
        //This controller has views

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RegisVendedores()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisVendedores(RegisVendedoresEnt entidad)
        {
            VendModel.RegisVendedores(entidad);
            return View();
        }

        [HttpGet]
        public ActionResult RegisVehiculos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisVehiculos(RegisVehiculosEnt entidad)
        {
            VehiModel.RegisVehiculos(entidad);
            return View();
        }

        [HttpGet]
        public ActionResult ConsulVehiculos()  
        { 
            return View(); 
        }

        //[HttpPost]
        //public ActionResult ConsulVehiculos()
        //{
        //    return View();
        //}

    }
}