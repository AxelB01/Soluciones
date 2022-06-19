using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace LectorXml
{
    class Program
    {
        static void Main(string[] args)
        {

            string file = File.ReadAllText(@"C:\Users\Axel Bernard\Documents\UCE\UCE(C6)\Analisis y Optimizacion de Algoritmos (ISW-132-1)\Soluciones\LectorXml\Documents\XMLFile1.xml");

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(file);

            Dictionary<string, string> responseKeys = new Dictionary<string, string>();
            for (int i = 0; i < xmlDocument.DocumentElement.ChildNodes.Count; i++)
            {
                var keyName = xmlDocument.DocumentElement.ChildNodes.Item(i).Name;
                var keyValue = xmlDocument.DocumentElement.ChildNodes.Item(i).InnerText;
                responseKeys.Add(keyName, keyValue);
            }

            Console.Write(responseKeys);
            Console.ReadKey();
        }
    }
}
