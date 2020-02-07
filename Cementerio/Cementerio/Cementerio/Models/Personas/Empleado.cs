using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cementerio.Models.Personas
{
    public class Empleado
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "salario")]
        public int salario { get; set; }

        [Display(Name = "antiguedad")]
        public DateTime antiguedad { get; set; }

        [Display(Name = "persona_id")]
        public int persona_id { get; set; }


        [Display(Name = "user")]
        public string empleado_rut { get; set; }

        [Display(Name = "pass")]
        public string empleado_nombre { get; set; }


        [Display(Name = "empleado_apellidoPaterno")]
        public string empleado_apellidoPaterno { get; set; }

        [Display(Name = "empleado_apellidoMaterno")]
        public string empleado_apellidoMaterno { get; set; }

        [Display(Name = "empleado_edad")]
        public int empleado_edad { get; set; }

        [Display(Name = "empleado_telefono")]
        public int empleado_telefono { get; set; }

        [Display(Name = "categoria_id")]
        public int categoria_id { get; set; }

        [Display(Name = "categoria_nombre")]
        public string categoria_nombre { get; set; }

        [Display(Name = "jornada_laboral_id")]
        public int jornada_laboral_id { get; set; }

        [Display(Name = "jornada_laboral_nombre")]
        public string jornada_laboral_nombre { get; set; }
    }
}