using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios
{
    public class DetalleDatoInteresC
    {
        public int id { get; set; }
        public  int familiar_id { get; set; }
        public string familiar_rut { get; set; }
        public string familiar_nombre { get; set; }
        public string familiar_apellidoPaterno { get; set; }
        public string familiar_apellidoMaterno { get; set; }
        public int familiar_edad { get; set; }
        public int familiar_telefono { get; set; }
        public int dato_interes_id { get; set; }
        public string dato_interes_nombre { get; set; }
        public string dato_interes_descripcion { get; set; }
    }
}