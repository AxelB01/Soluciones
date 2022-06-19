using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPila
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();

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
                        Agregar(stack);
                        break;
                    case 2:
                        Eliminar(stack);
                        break;
                    default:
                        break;
                }

            }

            Console.ReadKey();
        }

        public static void Imprimir(Stack<string> stack)
        {
            Console.WriteLine();
            if (stack.Count > 0 )
            {
                Console.WriteLine("Imprimiendo lista...");
                foreach (var item in stack)
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

        public static void Agregar(Stack<string> stack)
        {
            Console.Write("Ingrese el título del libro a ingresar: ");
            var libro = Console.ReadLine().ToUpper().Trim();
            stack.Push(libro);
            Imprimir(stack);
        }

        public static void Eliminar(Stack<string> stack)
        {
            Console.WriteLine($"El libro a eliminar es: {stack.Peek()}");
            var opcion = "";
            while (!opcion.Equals("Y") && !opcion.Equals("N"))
            {
                Console.Write("Seguro que deseas eliminarlo? (Y/N) ");
                opcion = Console.ReadLine().ToUpper().Trim();
            }

            if (opcion.Equals("Y"))
            {
                stack.Pop();
            }
            Imprimir(stack);
        }
    }
}
