using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_universitario.Data
{
    public class CuatrimestreDatas
    {
        public int Cantidad { get; set; }
        public List<int> Carreras = new List<int>();
        public List<string> Materia = new List<string>();
        public int CantidadMateria { get; set; }
    }
}
