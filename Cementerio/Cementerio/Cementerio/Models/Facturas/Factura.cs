using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cementerio.Models.Facturas
{
    public class Factura
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "total")]
        public int total { get; set; }

        [Display(Name = "fecha_emision")]
        public DateTime fecha_emision { get; set; }

        [Display(Name = "detalle_factura_id")]
        public int detalle_factura_id { get; set; }

        [Display(Name = "tumba_id")]
        public int tumba_id { get; set; }

        [Display(Name = "tumba_tipo")]
        public string tumba_tipo { get; set; }

        [Display(Name = "tumba_material")]
        public string tumba_material { get; set; }

        [Display(Name = "sector_id")]
        public int sector_id { get; set; }

        [Display(Name = "sector_capacidad")]
        public int sector_capacidad { get; set; }

        [Display(Name = "sector_extension_variable")]
        public decimal sector_extension_variable { get; set; }

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