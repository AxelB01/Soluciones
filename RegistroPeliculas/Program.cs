using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPeliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula[] peliculas = new Pelicula[10];

            var opcion = 0;

            while (Convert.ToInt32(opcion) != 4)
            {
                Console.WriteLine("Registro de película \nMenú \n1.Ingresar nueva película \n2.Ver listado de películas \n3.Imprimir lista");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    IngresarPelicula(peliculas);
                }

                if (opcion == 2)
                {
                    ImprimirPeliculas(peliculas);
                }

                if (opcion == 3)
                {
                    ImprimirDocumento(peliculas);
                }

            }

        }

        public static void IngresarPelicula(Pelicula[] lista)
        {

            Console.WriteLine("Revisando espacio...");

            var posicion = 0;

            foreach (var item in lista)
            {
                if (item != null)
                {
                    posicion++;
                }
            }

            if (posicion < 10)
            {
                Console.WriteLine("Ingresando nueva película...");

                var model = new Pelicula();

                Console.Write("Título: ");
                model.Titulo = Console.ReadLine();

                Console.Write("Director: ");
                model.Director = Console.ReadLine();

                Console.Write("Escritor: ");
                model.Escritor = Console.ReadLine();

                Console.Write("Género: ");
                model.Genero = Console.ReadLine();

                Console.Write("Duración en minutos: ");
                model.DuracionMinutos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Clasificación: ");
                model.Clasificacion = Console.ReadLine();

                Console.Write("Productora: ");
                model.Productora = Console.ReadLine();

                lista[posicion] = model;
            }
            else
            {
                Console.WriteLine("No queda espacio...");
            }

        }

        public static void ImprimirPeliculas(Pelicula[] lista)
        {
            foreach (var item in lista)
            {
                if (item != null)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Título: {item.Titulo} \nDirector: {item.Director} \nEscritor: {item.Escritor} \nGénero: {item.Genero} \nDuración en minutos: {item.DuracionMinutos} minutos " +
                    $"\nClasificación: {item.Clasificacion} \nProductora: {item.Productora}");
                    Console.WriteLine();
                }
            }
        }

        public static void ImprimirDocumento(Pelicula[] lista)
        {

            var nombreDocumento = @"C:\Users\Axel Bernard\Documents\UCE\UCE(C6)\Analisis y Optimizacion de Algoritmos (ISW-132-1)\Lista Peliculas.txt";

            using (var fs = new FileStream(nombreDocumento, FileMode.Create, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Listado de películas y series");

                    foreach (var item in lista)
                    {
                        if (item != null)
                        {
                            sw.WriteLine($"\nTítulo: {item.Titulo} \nDirector: {item.Director} \nEscritor: {item.Escritor} \nGénero: {item.Genero} \nDuración en minutos: {item.DuracionMinutos} minutos " +
                                     $"\nClasificación: {item.Clasificacion} \nProductora: {item.Productora}");
                        }
                    }
                }
            }

            Console.WriteLine("Archivo creado!");
        }
    }

    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Escritor { get; set; }
        public string Genero { get; set; }
        public int DuracionMinutos { get; set; }
        public string Clasificacion { get; set; }
        public string Productora { get; set; }
    }
}
