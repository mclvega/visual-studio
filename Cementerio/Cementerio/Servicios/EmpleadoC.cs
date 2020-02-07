using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios
{
    public class EmpleadoC
    {

        public int id { get; set; }
        public int salario { get; set; }
        public DateTime antiguedad { get; set; }
        public int persona_id { get; set; }
        public string empleado_rut { get; set; }
        public string empleado_nombre { get; set; }
        public string empleado_apellidoPaterno { get; set; }
        public string empleado_apellidoMaterno { get; set; }
        public int empleado_edad { get; set; }
        public int empleado_telefono { get; set; }
        public int categoria_id { get; set; }
        public string categoria_nombre { get; set; }
        public int jornada_laboral_id { get; set; }
        public string jornada_laboral_nombre { get; set; }
    }
}