using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosProveedor
{
    public class DatosBancariosClase
    {
        public decimal Codigo { get; set; }
        public decimal NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public decimal Banco { get; set; }
        public decimal ProveedorC { get; set; }
        public string NombreBanco { get; set; }
        public decimal TipoCuenta { get; set; }
        public string NombreTipo { get; set; }
        public decimal Sucursal { get; set; }
        public string NombreSucursal { get; set; }
        public decimal Activo { get; set; }
    }
}