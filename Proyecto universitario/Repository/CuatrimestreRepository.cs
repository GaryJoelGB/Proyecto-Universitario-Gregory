using Proyecto_universitario.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_universitario.Repository
{
    public class CuatrimestreRepository
    {
        CuatrimestreDatas cuatrimestreD = new CuatrimestreDatas();
        Calificaciones calificaciones = new Calificaciones();
        Promedio SetPromedio = new Promedio();
        int puntuaje = 1;
        int contador = 0;
        public void GetCuatrimestre()
        {
           
            

            Console.WriteLine("Cuanto cuatrimestre tiene tu carrera");
            string cuatrimestre = Console.ReadLine();
              cuatrimestreD.Cantidad = Convert.ToInt32(cuatrimestre);
                                    
             for (int i = 0; i < cuatrimestreD.Cantidad; i++)
             {
               Console.WriteLine($"Cuantas materia tiene este cuatrimestre {puntuaje++}");
               cuatrimestreD.CantidadMateria += int.Parse(Console.ReadLine());
               GetNotas();
             }
                
            
        }
        public void GetNotas()
        {
            while(cuatrimestreD.CantidadMateria == 0)
            {
                Console.WriteLine("Ingrese materia de este cuatrimestre");
                cuatrimestreD.Materia.Add(Console.ReadLine());

                for(int i = 0; i < cuatrimestreD.Materia.Count; i++)
                {
                    Console.WriteLine("Ingrese la nota de examen de : " + cuatrimestreD.Materia[puntuaje]);
                    calificaciones.Examene = int.Parse(Console.ReadLine());


                    Console.WriteLine("Ingrese la nota de exposicion de : " + cuatrimestreD.Materia[puntuaje]);
                    calificaciones.Exposicion = int.Parse(Console.ReadLine());


                    Console.WriteLine("Ingrese la nota de Asistencia de : " + cuatrimestreD.Materia[puntuaje]);
                    calificaciones.Asistencia = int.Parse(Console.ReadLine());


                    calificaciones.SumaNotas = calificaciones.Examene + calificaciones.Exposicion + calificaciones.Asistencia;

                    calificaciones.DividirNotas = calificaciones.SumaNotas / 3;

                    SetPromedio.PromedioPorMateria.Add(calificaciones.DividirNotas);
                    puntuaje++;
                    calificaciones.NotaParaCuatrimestre += calificaciones.DividirNotas;
                }

                SetPromedio.PromedioPorCuatrimestre.Add(calificaciones.NotaParaCuatrimestre / cuatrimestreD.CantidadMateria);
                calificaciones.NotaParaCuatrimestre = 0;
            }

            SacarPromedio();
        }

           public double SacarPromedio()
        {
            foreach (var Promedio in SetPromedio.PromedioPorCuatrimestre)
            {

                SetPromedio.PromedioTotal += Promedio;

                SetPromedio.PromedioFinal = SetPromedio.PromedioTotal / SetPromedio.PromedioPorCuatrimestre.Count;

            }

            return SetPromedio.PromedioFinal;
         
        }

        public void GetBeca()
        {
            for (int i = 0; i < cuatrimestreD.Cantidad; i++)
            {
                Console.WriteLine($"Promedio de Calificaciones por cuatrimestre #{contador++}:" + "{0:N2}", SetPromedio.PromedioPorCuatrimestre[i]);

            }

            Console.WriteLine();


            Console.WriteLine("Su calificacion final es: {0:N2} ", SetPromedio.PromedioFinal);

            Console.WriteLine("Pulse enter para comprobar si puede solicitar una beca");
            Console.ReadKey();


        }
    }

}
