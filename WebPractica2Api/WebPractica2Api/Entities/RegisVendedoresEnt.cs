using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPractica2Api.Entities
{
    public class RegisVendedoresEnt
    {
        public long IdVendedor { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public bool Estado { get; set; }
    }
}