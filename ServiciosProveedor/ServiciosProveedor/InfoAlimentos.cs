using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosProveedor
{
    public class InfoAlimentos
    {
        public string NombreProveedor { get; set; }
        public string CorreoProveedor { get; set; }
        public decimal TelefonoProveedor { get; set; }
        public string RutSucursal { get; set; }

        public string foto { get; set; }
        public string ComunaSucursal { get; set; }
        public string ProvinciaSucursal { get; set; }
        public string DireccionSucursal { get; set; }
        public decimal TelefonoSucursal { get; set; }
        public double longitud { get; set; }
        public double latitud { get; set; }
       // public decimal numeroCuentaSucursal { get; set; }
        //public string BancoSucursal { get; set; }
       // public string TipoCuentaSucursal { get; set; }
        public string CategoriaProducto { get; set; }
        public string TipoProducto { get; set; }
        public string NombreProducto { get; set; }
        public System.DateTime fecha_elaboracionProducto { get; set; }
        public System.DateTime fecha_vencimientoProducto { get; set; }
        public decimal stockProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal PrecioProducto { get; set; }
    }
}