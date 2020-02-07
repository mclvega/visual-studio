using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Proveedor.Models.DatosBancarios
{
    public class DatosBancariosClase
    {
        [Display(Name = "Codigo")]
        public decimal Codigo { get; set; }

        [Display(Name = "NumeroCuenta")]
        public decimal NumeroCuenta { get; set; }

        [Display(Name = "Saldo")]
        public decimal Saldo { get; set; }

        [Display(Name = "Banco")]
        public decimal Banco { get; set; }

        [Display(Name = "ProveedorC")]
        public decimal ProveedorC { get; set; }

        [Display(Name = "NombreBanco")]
        public string NombreBanco { get; set; }

        [Display(Name = "TipoCuenta")]
        public decimal TipoCuenta { get; set; }

        [Display(Name = "NombreTipo")]
        public string NombreTipo { get; set; }

        [Display(Name = "Sucursal")]
        public decimal Sucursal { get; set; }

        [Display(Name = "NombreSucursal")]
        public string NombreSucursal { get; set; }

        [Display(Name = "Activo")]
        public decimal Activo { get; set; }


    }
}