using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Cementerio.Models.Categorias
{
    public class Categorias
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "nombre")]
        public string nombre { get; set; }

        [Display(Name = "descripcion")]
        public string descripcion { get; set; }
    }
}