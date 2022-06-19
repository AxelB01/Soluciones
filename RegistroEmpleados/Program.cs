using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            var opcion = 0;

            while (Convert.ToInt32(opcion) != 7)
            {
                Console.WriteLine("Registro de empleados \nMenú \n1.Ingresar empleados \n2.Ver Empleado por Código \n3.Buscar empleado \n4.Eliminar empleado \n5.Número de empleados \n6.Lista de empleados");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    IngresarEmpleado(empleados);
                }

                if (opcion == 2)
                {
                    MostrarEmpleado(empleados);
                }

                if (opcion == 3)
                {
                    BuscarEmpleado(empleados);
                }

                if (opcion == 4)
                {
                    EliminarEmpleado(empleados);
                }

                if (opcion == 5)
                {
                    Console.WriteLine($"El número de empleados registrados es: {empleados.Count}");
                }

                if (opcion == 6)
                {
                    if (empleados.Count > 0)
                    {
                        foreach (var item in empleados)
                        {
                            item.Imprimir();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay registros");
                    }
                    
                }
            }

        }

        public static void IngresarEmpleado(List<Empleado> empleados)
        {
            Console.WriteLine("Preparando registro...");
            Console.Write("Ingresar el número de empleados a ingresar ");
            int numeroEmpleados = Convert.ToInt32(Console.ReadLine());
            var empleadosIngresados = 0;

            while (empleadosIngresados < numeroEmpleados)
            {
                var empleado = new Empleado();

                Console.Write("Nombres: ");
                empleado.Nombres = Console.ReadLine();

                Console.Write("Apellidos: ");
                empleado.Apellidos = Console.ReadLine();

                Console.Write("Cargo: ");
                empleado.Cargo = Console.ReadLine();

                Console.Write("Sueldo: ");
                empleado.Sueldo = Convert.ToDouble(Console.ReadLine());

                var id = empleados.Count + 1;
                empleado.Id = id;

                empleados.Add(empleado);

                empleadosIngresados++;

                Console.WriteLine($"Empleado registrado con el ID:{empleado.Id}");
            }

            Console.WriteLine("Listo!");
        }

        public static void MostrarEmpleado(List<Empleado> empleados)
        {
            Console.Write("Ingresar código del empleado: ");
            int codigoEmpleado = Convert.ToInt32(Console.ReadLine());
            var empleado = empleados.FirstOrDefault(e => e.Id == codigoEmpleado);
            if (empleado != null)
            {
                empleado.Imprimir();
            }
            else
            {
                Console.WriteLine("No existe un empleado con ese código");
            }
        }

        public static void BuscarEmpleado(List<Empleado> empleados)
        {
            Console.Write("Ingresar el nombre del empleado: ");
            string nombreEmpleado = Console.ReadLine();
            var resultado = empleados.Where(e => e.Nombres.Contains(nombreEmpleado)).ToList();
            foreach (var item in resultado)
            {
                item.Imprimir();
            }
        }

        public static void EliminarEmpleado(List<Empleado> empleados)
        {
            Console.Write("Ingresar código del empleado a eliminar: ");
            int codigoEmpleado = Convert.ToInt32(Console.ReadLine());
            var empleado = empleados.First(e => e.Id == codigoEmpleado);
            empleados.Remove(empleado);
            Console.WriteLine("Empleado eliminado");
        }
    }

    public class Empleado
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cargo { get; set; }
        public double Sueldo { get; set; }
        public double AFP
        {
            get
            {
                return (Sueldo * 0.0287);
            }
        }
        public double SFS
        {
            get
            {
                return (Sueldo * 0.0304);
            }
        }
        public double TD 
        {
            get
            {
                return (AFP + SFS);
            }
        }
        public double SueldoNeto
        {
            get
            {
                return (Sueldo - TD);
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"\nCódigo: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Sueldo: RD$ {string.Format("{0:n2}", Sueldo)}");
            Console.WriteLine($"AFP: RD$ {string.Format("{0:n2}", AFP)}");
            Console.WriteLine($"SFS: RD$ {string.Format("{0:n2}", SFS)}");
            Console.WriteLine($"Total descuentos: RD$ {string.Format("{0:n2}", TD)}");
            Console.WriteLine($"Sueldo neto: {string.Format("{0:n2}", SueldoNeto)}");
            Console.WriteLine();
        }
    }
}
