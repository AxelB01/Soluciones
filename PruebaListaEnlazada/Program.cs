using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaListaEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<string>();

            var opcion = 0;

            while (opcion != 7)
            {
                Console.WriteLine("Registro de alumnos " +
                "\n1.Agregar alumno como primero" +
                "\n2.Agregar alumno como último" +
                "\n3.Mover uno de los alumnos de último" +
                "\n4.Eliminar a un alumno" +
                "\n5.Buscar alumno" +
                "\n6.Imprimir lista de alumnos" +
                "\n7.Salir del menú");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarPrimero(linkedList);
                        break;
                    case 2:
                        AgregarUltimo(linkedList);
                        break;
                    case 3:
                        MoverUltimo(linkedList);
                        break;
                    case 4:
                        Eliminar(linkedList);
                        break;
                    case 5:
                        Buscar(linkedList);
                        break;
                    case 6:
                        Imprimir(linkedList);
                        break;
                    default:
                        break;
                }

            }

            Console.ReadKey();
        }

        public static void AgregarPrimero(LinkedList<string> list)
        {
            Console.Write("Escriba el nombre de alumno(a): ");
            var nombreAlumno = Console.ReadLine().ToUpper().Trim();
            list.AddFirst(nombreAlumno);
        }

        public static void AgregarUltimo(LinkedList<string> list)
        {
            Console.Write("Escriba el nombre de alumno(a): ");
            var nombreAlumno = Console.ReadLine().ToUpper().Trim();
            list.AddLast(nombreAlumno);
        }

        public static void MoverUltimo(LinkedList<string> list)
        {
            Console.Write("Escriba el nombre del alumno(a) que desea mover: ");
            var nombreAlumno = Console.ReadLine().ToUpper().Trim();
            var alumno = list.FirstOrDefault(a => a.Equals(nombreAlumno));

            if (alumno != null)
            {
                list.Remove(alumno);
                list.AddLast(alumno);

                Console.WriteLine($"El alumno {alumno} ha sido ajustado");
            }
            else
            {
                Console.WriteLine($"El alumno {alumno} no existe");
            }

        }

        public static void Eliminar(LinkedList<string> list)
        {
            Console.Write("Escriba el nombre del alumno(a) que desea eliminar: ");
            var nombreAlumno = Console.ReadLine().ToUpper().Trim();
            var alumno = list.FirstOrDefault(a => a.Equals(nombreAlumno));

            var test = list.Find("a");

            if (alumno != null)
            {
                list.Remove(alumno);
                Console.WriteLine($"El alumno {alumno} ha sido eliminado");
            }
            else
            {
                Console.WriteLine($"El alumno {alumno} no existe");
            }

        }

        public static void Buscar(LinkedList<string> list)
        {
            Console.Write("Escriba el nombre del alumno(a) que desea examinar: ");
            var nombreAlumno = Console.ReadLine().ToUpper().Trim();
            var alumno = list.FirstOrDefault(a => a.Equals(nombreAlumno));

            if (alumno != null)
            {
                Console.WriteLine($"El alumno {alumno} existe");
            }
            else
            {
                Console.WriteLine($"El alumno {alumno} no existe");
            }

        }

        public static void Imprimir(LinkedList<string> list)
        {
            Console.WriteLine("Imprimiendo...");
            foreach (var item in list)
            {
                Console.WriteLine($"Alumno(a): {item}");
            }
        } 
    }
}
