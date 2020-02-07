using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Proveedor.Models.Comuna
{
    public class ComunaClase
    {

        [Display(Name = "Codigo")]
        public decimal Codigo { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Provincia")]
        public decimal Provincia { get; set; }
    }
}