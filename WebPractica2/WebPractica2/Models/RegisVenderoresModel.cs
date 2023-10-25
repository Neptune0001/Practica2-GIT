using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;
using WebPractica2.Entities;

namespace WebPractica2.Models
{
    public class RegisVenderoresModel
    {
        public string RegisVendedores(RegisVendedoresEnt entidad)
        {
            //LLAMAR AL WEB API PARA REGISTRAR A LOS VENDEDORES
            using (var client = new HttpClient())
            {
                var urlAPI = "https://localhost:44357/RegisVend";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlAPI, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result; 
            }
        }
    }
}