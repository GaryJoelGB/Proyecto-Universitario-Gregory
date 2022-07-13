using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_universitario.Model;

namespace Proyecto_universitario
{
    internal class Program

    {
        static void Main(string[] args)

        {
            GetBecas GetBecas = new GetBecas();
            Promedio SetPromedio = new Promedio();
            Cuatrimestres GetCuatrimestre = new Cuatrimestres();
            IntroducirNotas SetNotas = new IntroducirNotas();
            int numero = 1;
            int puntuaje = 0;
            int contador = 1;
            Console.WriteLine("Cantidad de cuatrimestre que contiene tu carrera");
            GetCuatrimestre.Cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < GetCuatrimestre.Cantidad; i++)
            {

                GetCuatrimestre.Carreras.Add(i);
                Console.WriteLine("***********************************************************");
                Console.WriteLine("Cuanta materia tiene este cuatrimestre " + numero++);
                GetCuatrimestre.CantidadMateria = int.Parse(Console.ReadLine());

                for (int j = 0; j < GetCuatrimestre.CantidadMateria; j++)
                {
                    
                    
                    Console.WriteLine("Ingrese materia de este cuatrimestre");
                    GetCuatrimestre.Materia.Add(Console.ReadLine());

                    Console.WriteLine("Ingrese la nota de examen de : " + GetCuatrimestre.Materia[puntuaje]);
                    SetNotas.Examene = int.Parse(Console.ReadLine());
                   

                    Console.WriteLine("Ingrese la nota de exposicion de : " + GetCuatrimestre.Materia[puntuaje]);
                    SetNotas.Exposicion = int.Parse(Console.ReadLine());
                   

                    Console.WriteLine("Ingrese la nota de Asistencia de : " + GetCuatrimestre.Materia[puntuaje]);
                    SetNotas.Asistencia = int.Parse(Console.ReadLine());
                   

                    SetNotas.SumaNotas = SetNotas.Examene + SetNotas.Exposicion + SetNotas.Asistencia;

                    SetNotas.DividirNotas = SetNotas.SumaNotas / 3; 

                    SetPromedio.PromedioPorMateria.Add(SetNotas.DividirNotas);
                    puntuaje++;
                    SetNotas.NotaParaCuatrimestre += SetNotas.DividirNotas;


                }

                
                SetPromedio.PromedioPorCuatrimestre.Add(SetNotas.NotaParaCuatrimestre / GetCuatrimestre.CantidadMateria);
                SetNotas.NotaParaCuatrimestre = 0;

            }
          


            foreach(var Promedio in SetPromedio.PromedioPorCuatrimestre)
            {

               SetPromedio.PromedioTotal += Promedio;

               SetPromedio.PromedioFinal = SetPromedio.PromedioTotal / SetPromedio.PromedioPorCuatrimestre.Count;

            }

            Console.Clear();

            for (int i = 0; i < GetCuatrimestre.Cantidad; i++)
            {
                Console.WriteLine($"Promedio de Calificaciones por cuatrimestre #{contador++}:"+"{0:N2}",  SetPromedio.PromedioPorCuatrimestre[i]);
          
            }

            Console.WriteLine();

           
            Console.WriteLine("Su calificacion final es: {0:N2} " , SetPromedio.PromedioFinal);

            Console.WriteLine("Pulse enter para comprobar si puede solicitar una beca");
            Console.ReadKey();

            double promedio = SetPromedio.PromedioFinal;


            GetBecas.GetDocumentos(promedio);

                Console.ReadKey();
        }


  

     }
}