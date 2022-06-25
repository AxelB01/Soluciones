using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setA = new HashSet<string>();

            setA.Add("Axel");
            setA.Add("Ericka");
            setA.Add("Liann");
            setA.Add("Xanders");

            HashSet<string> setB = new HashSet<string>();

            setB.Add("Miguel");
            setB.Add("Axel");
            setB.Add("María");
            setB.Add("Ericka");

            Operaciones(setA, setB);

            Console.ReadKey();
        }

        public static void Imprimir(HashSet<string> strings)
        {
            Console.WriteLine();
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void Operaciones(HashSet<string> stringsA, HashSet<string> stringsB)
        {
            var union = new HashSet<string>(stringsA);
            union.UnionWith(stringsB);
            Console.Write("Unión");
            Imprimir(union);

            var intersection = new HashSet<string>(stringsA);
            intersection.IntersectWith(stringsB);
            Console.Write("Intersección");
            Imprimir(intersection);

            var subtraction = new HashSet<string>(stringsA);
            subtraction.ExceptWith(stringsB);
            Console.WriteLine("Diferencia");
            Imprimir(subtraction);

            var symmetricDifference = new HashSet<string>(stringsA);
            symmetricDifference.SymmetricExceptWith(stringsB);
            Console.Write("Diferencia simétrica");
            Imprimir(symmetricDifference);

        }
    }
}
