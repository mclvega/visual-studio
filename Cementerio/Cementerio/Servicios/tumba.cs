//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios
{
    using System;
    using System.Collections.Generic;
    
    public partial class tumba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tumba()
        {
            this.detalle_factura = new HashSet<detalle_factura>();
        }
    
        public int id { get; set; }
        public int tipo_tumba_id { get; set; }
        public int material_id { get; set; }
        public int fallecido_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_factura> detalle_factura { get; set; }
        public virtual fallecido fallecido { get; set; }
        public virtual material material { get; set; }
        public virtual tipo_tumba tipo_tumba { get; set; }
    }
}
