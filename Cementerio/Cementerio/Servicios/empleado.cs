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
    
    public partial class empleado
    {
        public int id { get; set; }
        public int salario { get; set; }
        public System.DateTime antiguedad { get; set; }
        public int persona_id { get; set; }
        public int categoria_id { get; set; }
        public int jornada_laboral_id { get; set; }
    
        public virtual categoria categoria { get; set; }
        public virtual jornada_laboral jornada_laboral { get; set; }
        public virtual persona persona { get; set; }
    }
}
