﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_universitario
{
    public class Documentos
    {

        public Int64 Cedula { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }


        public string GetNombreCompleto { get { return this.Nombre + " " + this.Apellido; } }

        public int Edad { get; set; }
        
        public string TipodeSexo { get; set; }

        public string TipodeSangre { get; set; }

        public string Correo { get; set; }

        public Int64 Telefono { get; set; }



    }
}
