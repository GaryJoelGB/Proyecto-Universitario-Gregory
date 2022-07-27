using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_universitario.Repository;
using Proyecto_universitario.Service;

namespace Proyecto_universitario
{
    internal class Program

    {
        static void Main(string[] args)

        {
            CuatrimestreService CuatrimestreS = new CuatrimestreService();

            CuatrimestreS.IntroducirMateria();

            CuatrimestreS.MostrarMateria(); 
            
            Console.ReadKey();


        }


  

     }
}