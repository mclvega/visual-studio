using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cementerio.Models.Sectores
{
    public class Sector
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "capacidad")]
        public int capacidad { get; set; }

        [Display(Name = "extension_variable")]
        public decimal extension_variable { get; set; }
    }
}