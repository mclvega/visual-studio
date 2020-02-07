using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosProveedor
{
    public class AlimentoClase
    {
        public decimal Codigo { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }

        public string DatosSucursal { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal ProveedorC { get; set; }
        public decimal SucursalC { get; set; }
        public System.DateTime Fecha_elaboracion { get; set; }
        public System.DateTime Fecha_vencimiento { get; set; }
        public decimal Stock { get; set; }
        public decimal Sucursal { get; set; }
        public decimal Activo { get; set; }
        public decimal TipoAlimento { get; set; }
        public decimal CategoriaAlimento { get; set; }

        public string DatosTipo { get; set; }
        public string DatosCategoria { get; set; }
    }
}