using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios
{
    public class DetalleFacturaC
    {
        public int id { get; set; }
        public int tumba_id { get; set; }
        public string tumba_tipo { get; set; }
        public string tumba_material { get; set; }
        public int sector_id { get; set; }
        public int sector_capacidad { get; set; }
        public decimal sector_extension_variable { get; set; }
        public int familiar_id { get; set; }
        public string familiar_rut { get; set; }
        public string familiar_nombre { get; set; }
        public string familiar_apellidoPaterno { get; set; }
        public string familiar_apellidoMaterno { get; set; }
        public int familiar_edad { get; set; }
        public int familiar_telefono { get; set; }
        public int fallecido_id { get; set; }
        public string fallecido_rut { get; set; }
        public string fallecido_nombre { get; set; }
        public string fallecido_apellidoPaterno { get; set; }
        public string fallecido_apellidoMaterno { get; set; }
        public int fallecido_edad { get; set; }
    }
}