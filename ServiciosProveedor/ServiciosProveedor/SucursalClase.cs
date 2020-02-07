using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosProveedor
{
    public class SucursalClase
    {

        public decimal Codigo { get; set; }
        public string NombreProveedor { get; set; }
        public string NombreComuna { get; set; }
        public decimal CP { get; set; }
        public string Rut { get; set; }
        public string Direccion { get; set; }
        public decimal Telefono { get; set; }
        public decimal Proveedor { get; set; }
        public decimal Comuna { get; set; }
        public double Longitud { get; set; }
        public double Latitud { get; set; }
        public decimal Activo { get; set; }
    }
}