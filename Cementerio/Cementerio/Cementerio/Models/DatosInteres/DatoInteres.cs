using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cementerio.Models.DatosInteres
{
    public class DatoInteres
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "familiar_id")]
        public int familiar_id { get; set; }

        [Display(Name = "familiar_rut")]
        public string familiar_rut { get; set; }

        [Display(Name = "familiar_nombre")]
        public string familiar_nombre { get; set; }

        [Display(Name = "familiar_apellidoPaterno")]
        public string familiar_apellidoPaterno { get; set; }

        [Display(Name = "familiar_apellidoMaterno")]
        public string familiar_apellidoMaterno { get; set; }

        [Display(Name = "familiar_edad")]
        public int familiar_edad { get; set; }

        [Display(Name = "familiar_telefono")]
        public int familiar_telefono { get; set; }

        [Display(Name = "dato_interes_id")]
        public int dato_interes_id { get; set; }

        [Display(Name = "dato_interes_nombre")]
        public string dato_interes_nombre { get; set; }

        [Display(Name = "dato_interes_descripcion")]
        public string dato_interes_descripcion { get; set; }
    }
}