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
    
    public partial class Sucursal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sucursal()
        {
            this.Alimento = new HashSet<Alimento>();
            this.DatosBancarios = new HashSet<DatosBancarios>();
        }
    
        public decimal codigo { get; set; }
        public string rut { get; set; }
        public string direccion { get; set; }
        public decimal telefono { get; set; }
        public decimal proveedor { get; set; }
        public decimal comuna { get; set; }
        public double longitud { get; set; }
        public double latitud { get; set; }
        public decimal activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alimento> Alimento { get; set; }
        public virtual Comuna Comuna1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosBancarios> DatosBancarios { get; set; }
        public virtual Proveedor Proveedor1 { get; set; }
    }
}
