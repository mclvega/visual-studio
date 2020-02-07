using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosProveedor
{
    public class ProveedorClase
    {
        public decimal Codigo { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public string Correo { get; set; }
        public decimal Telefono { get; set; }
        public decimal Activo { get; set; }
    }
}