using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Proveedor.Models.Banco
{
    public class BancoClase
    {
        [Display(Name = "Codigo")]
        public decimal Codigo { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Activo")]
        public decimal Activo { get; set; }
    }
}