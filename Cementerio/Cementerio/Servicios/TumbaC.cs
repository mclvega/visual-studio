using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios
{
    public class TumbaC
    {
        public int id { get; set; }
        public int tipo_tumba_id { get; set; }
        public string tipo_tumba_nombre { get; set; }
        public int material_id { get; set; }
        public string material_nombre { get; set; }
        public int fallecido_id { get; set; }
        public string fallecido_rut { get; set; }
        public string fallecido_nombre { get; set; }
        public string fallecido_apellidoPaterno { get; set; }
        public string fallecido_apellidoMaterno { get; set; }
        public int fallecido_edad { get; set; }
    }
}