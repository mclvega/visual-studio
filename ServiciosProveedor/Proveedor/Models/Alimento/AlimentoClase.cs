using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Proveedor.Models.Alimento
{
    public class AlimentoClase
    {
        [Display(Name = "Codigo")]
        public decimal Codigo { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Foto")]
        public string Foto { get; set; }

        [Display(Name = "DatosSucursal")]
        public string DatosSucursal { get; set; }

        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        [Display(Name = "ProveedorC")]
        public decimal ProveedorC { get; set; }

        [Display(Name = "SucursalC")]
        public decimal SucursalC { get; set; }

        [Display(Name = "Fecha_elaboracion")]
        public System.DateTime Fecha_elaboracion { get; set; }

        [Display(Name = "Fecha_vencimiento")]
        public System.DateTime Fecha_vencimiento { get; set; }

        [Display(Name = "Stock")]
        public decimal Stock { get; set; }

        [Display(Name = "Sucursal")]
        public decimal Sucursal { get; set; }

        [Display(Name = "Activo")]
        public decimal Activo { get; set; }

        [Display(Name = "TipoAlimento")]
        public decimal TipoAlimento { get; set; }

        [Display(Name = "CategoriaAlimento")]
        public decimal CategoriaAlimento { get; set; }

        [Display(Name = "DatosTipo")]
        public string DatosTipo { get; set; }

        [Display(Name = "DatosCategoria")]
        public string DatosCategoria { get; set; }
    }
}