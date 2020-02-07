using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cementerio.Models.Tumbas
{
    public class Tumba
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "tipo_tumba_id")]
        public int tipo_tumba_id { get; set; }

        [Display(Name = "tipo_tumba_nombre")]
        public string tipo_tumba_nombre { get; set; }

        [Display(Name = "material_id")]
        public int material_id { get; set; }

        [Display(Name = "material_nombre")]
        public string material_nombre { get; set; }

        [Display(Name = "fallecido_id")]
        public int fallecido_id { get; set; }

        [Display(Name = "fallecido_rut")]
        public string fallecido_rut { get; set; }

        [Display(Name = "fallecido_nombre")]
        public string fallecido_nombre { get; set; }

        [Display(Name = "fallecido_apellidoPaterno")]
        public string fallecido_apellidoPaterno { get; set; }

        [Display(Name = "fallecido_apellidoMaterno")]
        public string fallecido_apellidoMaterno { get; set; }

        [Display(Name = "fallecido_edad")]
        public int fallecido_edad { get; set; }
    }
}