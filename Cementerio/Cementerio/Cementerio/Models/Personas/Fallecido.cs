using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cementerio.Models.Personas
{
    public class Fallecido
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "persona_id")]
        public int persona_id { get; set; }

        [Display(Name = "rut")]
        public string rut { get; set; }

        [Display(Name = "nombre")]
        public string nombre { get; set; }

        [Display(Name = "apellidoPaterno")]
        public string apellidoPaterno { get; set; }

        [Display(Name = "apellidoMaterno")]
        public string apellidoMaterno { get; set; }

        [Display(Name = "edad")]
        public int edad { get; set; }

        
    }
}