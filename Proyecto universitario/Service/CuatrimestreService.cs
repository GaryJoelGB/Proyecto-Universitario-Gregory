using Proyecto_universitario.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_universitario.Data;

namespace Proyecto_universitario.Service
{
    public class CuatrimestreService
    {
        readonly List<string> _Materia;
        public CuatrimestreService()
        {
            var CuatrimestreData = new CuatrimestreDatas();
            _Materia = CuatrimestreData.Materia;
        }


        public void IntroducirMateria()
        {
            for(int i = 0; i < 5; i++)
            {
                _Materia.Add(Console.ReadLine());

            }

        }

        public void MostrarMateria()
        {
            for(int i = 0; i < _Materia.Count; i++)
            {

                Console.WriteLine(_Materia[i]);

            }


        }
              
    }
}
