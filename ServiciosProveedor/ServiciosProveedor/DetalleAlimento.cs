//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosProveedor
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleAlimento
    {
        public decimal codigo { get; set; }
        public decimal alimento { get; set; }
        public decimal categoria { get; set; }
        public decimal tipoAlimento { get; set; }
        public decimal activo { get; set; }
    
        public virtual Alimento Alimento1 { get; set; }
        public virtual Categoria Categoria1 { get; set; }
        public virtual TipoAlimento TipoAlimento1 { get; set; }
    }
}
