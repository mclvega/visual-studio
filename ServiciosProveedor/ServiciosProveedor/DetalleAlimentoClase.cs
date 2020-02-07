using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosProveedor
{
    public class DetalleAlimentoClase
    {
        public decimal codigo { get; set; }
        public decimal producto { get; set; }
        public decimal categoria { get; set; }
        public decimal tipoProducto { get; set; }
        public decimal activo { get; set; }
    }
}