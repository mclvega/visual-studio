using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Proveedor.Models.Sucursal
{
    public class SucursalClase
    {

        [Display(Name = "Codigo")]
        public decimal Codigo { get; set; }

        [Display(Name = "NombreProveedor")]
        public string NombreProveedor { get; set; }

        [Display(Name = "NombreComuna")]
        public string NombreComuna { get; set; }

        [Display(Name = "CP")]
        public decimal CP { get; set; }

        [Display(Name = "Rut")]
        public string Rut { get; set; }

        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Display(Name = "Telefono")]
        public decimal Telefono { get; set; }

        [Display(Name = "Proveedor")]
        public decimal Proveedor { get; set; }

        [Display(Name = "Comuna")]
        public decimal Comuna { get; set; }

        [Display(Name = "Longitud")]
        public double Longitud { get; set; }

        [Display(Name = "Latitud")]
        public double Latitud { get; set; }

        [Display(Name = "Activo")]
        public decimal Activo { get; set; }
    }
}