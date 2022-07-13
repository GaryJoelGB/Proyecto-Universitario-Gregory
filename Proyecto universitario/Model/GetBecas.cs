using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_universitario.Model
{
    public class GetBecas
    {
        Documentos SolicitudBeca = new Documentos();
        Promedio GetPromedio = new Promedio();
        public void GetDocumentos(double Promedio)
        {
            GetPromedio.PromedioFinal = Promedio;

                if (Promedio > 80 && Promedio < 100)
                {
                    Console.Clear();

                    Console.WriteLine("Puede solicitar una beca");
                    Console.WriteLine("Introduzca su nombre ");
                    SolicitudBeca.Nombre = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Introduzca su apellido");
                    SolicitudBeca.Apellido = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Introduzca su Edad");
                    SolicitudBeca.Edad = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Introduzca su Cedula");
                    SolicitudBeca.Cedula = Int64.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Introduzca tipo de sexo");
                    SolicitudBeca.TipodeSexo = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Introduzca tipo de sangre");
                    SolicitudBeca.TipodeSangre = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Introduzca su telefono");
                    SolicitudBeca.Telefono = Int64.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Introduzca su correo electronico");
                    SolicitudBeca.Correo = Console.ReadLine();

                     SetPerfil();
            }

              
                else
                {

                Console.Clear();
                Console.WriteLine("No puedes, su puntuaje es demasiado bajo: {0:N2} ", Promedio);
                Console.WriteLine("La nota debe ser minima: 80.00");
                Console.ReadKey();

                }

                 
    

        }

        public void SetPerfil()
        {
            Console.Clear();
            Console.WriteLine($"Bienvenido joven {SolicitudBeca.GetNombreCompleto}");

            Console.WriteLine("Informacion inscripta");
            Console.WriteLine("Nombre: " + SolicitudBeca.Nombre);
            Console.WriteLine("Apellido: " + SolicitudBeca.Apellido);
            Console.WriteLine("Edad: " + SolicitudBeca.Edad);
            Console.WriteLine("Tipo de sangre: " + SolicitudBeca.TipodeSangre);
            Console.WriteLine("Tipo de Sexo: " + SolicitudBeca.TipodeSexo);
            Console.WriteLine("Cedula: " + SolicitudBeca.Cedula);
            Console.WriteLine("Telefono: " + SolicitudBeca.Telefono);
            Console.WriteLine("Correo: " + SolicitudBeca.Correo);
            Console.WriteLine();
            Console.WriteLine("Esta informacion sera enviada a evaluar, deseas:");
            Console.WriteLine("1: Enviarla");
            Console.WriteLine("2: Editarla");
            int opciones = Convert.ToInt32(Console.ReadLine());

            switch (opciones)
            {
                case 1 : 
                    Console.WriteLine($"Su informacion ha sido enviada, y pronto tendra respuesta en el telefono {SolicitudBeca.Telefono} o correo {SolicitudBeca.Correo}");
                    Console.ReadKey();
                    break;
                case 2:
                    double Numero = GetPromedio.PromedioFinal;
                    GetDocumentos(Numero);
                    break;
                default:
                    Console.WriteLine("Escriba un numero correcto");
                    Console.ReadKey();
                    SetPerfil();

                    break;
                
            }
                   


        }

     
    }
}
