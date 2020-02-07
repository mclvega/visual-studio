using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Proveedor.Models.Proveedor
{
    public class ProveedorClase
    {
        [Display(Name = "Codigo")]
        public decimal Codigo { get; set; }

        [Display(Name = "Rut")]
        public string Rut { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Usuario")]
        public string Usuario { get; set; }

        [Display(Name = "Pass")]
        public string Pass { get; set; }

        [Display(Name = "Correo")]
        public string Correo { get; set; }

        [Display(Name = "Telefono")]
        public decimal Telefono { get; set; }

        [Display(Name = "Activo")]
        public decimal Activo { get; set; }
    }
}