using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cementerio.Models.Materiales
{
    public class Material
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "nombre")]
        public string nombre { get; set; }

        [Display(Name = "descripcion")]
        public string descripcion { get; set; }
    }
}