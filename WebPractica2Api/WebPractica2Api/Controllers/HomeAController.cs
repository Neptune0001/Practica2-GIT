using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebPractica2Api.Entities;

namespace WebPractica2Api.Controllers
{
    public class HomeAController : ApiController
    {
        [HttpPost]
        [Route("RegisVend")]
        public string RegisVendedores(RegisVendedoresEnt entidad)
        {

            try
            { 

                using( var context = new Practica2Entities())
                {
                //Esto es con LINQ
                //Realizamos una instancia
                //Vendedores tVendedores = new Vendedores();

                //tVendedores.Cedula = entidad.Cedula;
                //tVendedores.Nombre = entidad.Nombre;
                //tVendedores.Correo = entidad.Correo;
                //tVendedores.Estado = entidad.Estado;

                //context.Vendedores.Add(tVendedores);
                //context.SaveChanges();

                    context.RegistrarVendedorSP(entidad.Cedula,entidad.Nombre,entidad.Correo.ToLower(),entidad.Estado);


                    return "OK";
                }
            }
            catch (Exception)
            {
                //En caso de que falle
                return string.Empty;
            }
        }

        [HttpPost]
        [Route("RegisVehi")]
        public string RegisVehiculos(RegisVehiculosEnt entidad)
        {
            using( var context = new Practica2Entities())
            {
                try
                {
                    context.RegistrarVehiculoSP(entidad.Marca, entidad.Modelo, entidad.Color, entidad.Precio, entidad.IdVendedor);

                    return "OK";
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }

        [HttpGet]
        [Route("ConsultVend")]
        public List<Vendedores> ConsultaUsuarios()
        {
            try
            {
                using (var context = new Practica2Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var datos = (from x in context.Vendedores
                                 select x).ToList();

                    return datos;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }

        [HttpGet]
        [Route("ConsultVende")]
        public List<System.Web.Mvc.SelectListItem> ConsultarVendedor()
        {
            try
            {
                using (var context = new Practica2Entities())
                {
                    var datos = (from x in context.Vendedores
                                 select x).ToList();

                    List<System.Web.Mvc.SelectListItem> direcciones = new List<System.Web.Mvc.SelectListItem>();
                    foreach (var item in datos)
                    {
                        direcciones.Add(new System.Web.Mvc.SelectListItem { Value = item.Cedula.ToString(), Text = item.Nombre });
                    }

                    return direcciones;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
