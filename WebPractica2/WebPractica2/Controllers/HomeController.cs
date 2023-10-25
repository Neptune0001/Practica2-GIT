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
        ConsultaVehiModel Consult = new ConsultaVehiModel();

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
            entidad.Estado = true;

            string res = VendModel.RegisVendedores(entidad);

            if (res == "OK")
            {
                ViewBag.Alert = "alert-success";
                ViewBag.Mensaje = "Registro Realizado";
                return View();
            }
            else
            {
                ViewBag.Alert = "alert-danger";
                ViewBag.Mensaje = "Ha ocurrido un error";
                return View();
            }

            
        }

        [HttpGet]
        public ActionResult RegisVehiculos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisVehiculos(RegisVehiculosEnt entidad)
        {
            string res = VehiModel.RegisVehiculos(entidad);

            if (res == "OK")
            {
                ViewBag.Alert = "alert-success";
                ViewBag.Mensaje = "Registro Realizado";
                return View();
            }
            else
            {
                ViewBag.Alert = "alert-danger";
                ViewBag.Mensaje = "Ha ocurrido un error";
                return View();
            }

        }

        [HttpGet]
        public ActionResult ConsulVehiculos()
        {
            //var datos = Consult.ConsulVend();
            //return View(datos);
            return View();
        }

    }
}