using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Web;
using WebPractica2.Entities;

namespace WebPractica2.Models
{
    public class RegisVehiculosModel
    {
        public string RegisVehiculos(RegisVehiculosEnt entidad)
        {
            //LLAMAR WEB API PARA REGISTRAR VEHICULOS Y CARGAR LISTA DE VENDEDORES
            using (var client = new HttpClient())
            {
                var urlAPI = "https://localhost:44357/RegisVehi";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlAPI, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
    }
}