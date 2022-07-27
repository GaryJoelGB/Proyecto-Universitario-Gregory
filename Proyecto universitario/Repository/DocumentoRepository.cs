using Proyecto_universitario.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_universitario.Repository
{

    public class DocumentoRepository
    {
        DocumentoDatas DocumentoD = new DocumentoDatas();
        Promedio GetPromedio = new Promedio();
        public void SetDocumento()
        {
            {
                

                if (GetPromedio.PromedioFinal > 80 && GetPromedio.PromedioFinal < 100)
                {
                    Console.Clear();

                    Console.WriteLine("Puede solicitar una beca");
                    Console.WriteLine("Introduzca su nombre ");
                    DocumentoD.Nombre = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Introduzca su apellido");
                    DocumentoD.Apellido = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Introduzca su Edad");
                    DocumentoD.Edad = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Introduzca su Cedula");
                    DocumentoD.Cedula = Int64.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Introduzca tipo de sexo");
                    DocumentoD.TipodeSexo = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Introduzca tipo de sangre");
                    DocumentoD.TipodeSangre = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Introduzca su telefono");
                    DocumentoD.Telefono = Int64.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Introduzca su correo electronico");
                    DocumentoD.Correo = Console.ReadLine();

                    SetPerfil();
                }


                else
                {

                    Console.Clear();
                    Console.WriteLine("No puedes, su puntuaje es demasiado bajo: {0:N2} ", GetPromedio.PromedioFinal);
                    Console.WriteLine("La nota debe ser minima: 80.00");
                    Console.ReadKey();

                }




            }


        }

        public void SetPerfil()
        {
            Console.Clear();
            Console.WriteLine($"Bienvenido joven {DocumentoD.GetNombreCompleto}");

            Console.WriteLine("Informacion inscripta");
            Console.WriteLine("Nombre: " + DocumentoD.Nombre);
            Console.WriteLine("Apellido: " + DocumentoD.Apellido);
            Console.WriteLine("Edad: " + DocumentoD.Edad);
            Console.WriteLine("Tipo de sangre: " + DocumentoD.TipodeSangre);
            Console.WriteLine("Tipo de Sexo: " + DocumentoD.TipodeSexo);
            Console.WriteLine("Cedula: " + DocumentoD.Cedula);
            Console.WriteLine("Telefono: " + DocumentoD.Telefono);
            Console.WriteLine("Correo: " + DocumentoD.Correo);
            Console.WriteLine();
            Console.WriteLine("Esta informacion sera enviada a evaluar, deseas:");
            Console.WriteLine("1: Enviarla");
            Console.WriteLine("2: Editarla");
            int opciones = Convert.ToInt32(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    Console.WriteLine($"Su informacion ha sido enviada, y pronto tendra respuesta en el telefono {DocumentoD.Telefono} o correo {DocumentoD.Correo}");
                    Console.ReadKey();
                    break;
                case 2:
                    SetDocumento();
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
