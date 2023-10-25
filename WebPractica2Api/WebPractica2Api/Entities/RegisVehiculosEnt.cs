using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPractica2Api.Entities
{
    public class RegisVehiculosEnt
    {
        public long IdVehiculo { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Color { get; set; }

        public decimal Precio { get; set; }

        public long IdVendedor { get; set; }
    }
}