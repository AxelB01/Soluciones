using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCola
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            var opcion = 0;

            while (opcion != 3)
            {
                Console.WriteLine("Registro de libros " +
                "\n1.Agregar libro" +
                "\n2.Eliminar libro" +
                "\n3.Salir del menú");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Agregar(queue);
                        break;
                    case 2:
                        Eliminar(queue);
                        break;
                    default:
                        break;
                }

            }

            Console.ReadKey();
        }

        public static void Imprimir(Queue<string> queue)
        {
            Console.WriteLine();
            if (queue.Count > 0)
            {
                Console.WriteLine("Imprimiendo lista...");
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No se han ingresado elementos...");
            }
            Console.WriteLine();
        }

        public static void Agregar(Queue<string> queue)
        {
            Console.Write("Ingrese el título del libro a ingresar: ");
            var libro = Console.ReadLine().ToUpper().Trim();
            queue.Enqueue(libro);
            Imprimir(queue);
        }

        public static void Eliminar(Queue<string> queue)
        {
            Console.WriteLine($"El libro a eliminar es: {queue.Peek()}");
            var opcion = "";
            while (!opcion.Equals("Y") && !opcion.Equals("N"))
            {
                Console.Write("Seguro que deseas eliminarlo? (Y/N) ");
                opcion = Console.ReadLine().ToUpper().Trim();
            }

            if (opcion.Equals("Y"))
            {
                queue.Dequeue();
            }
            Imprimir(queue);
        }
    }
}
