﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios
{
    public class FallecidoC
    {
        public int id { get; set; }
        public int persona_id { get; set; }
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public int edad { get; set; }
        public int telefono { get; set; }

    }
}