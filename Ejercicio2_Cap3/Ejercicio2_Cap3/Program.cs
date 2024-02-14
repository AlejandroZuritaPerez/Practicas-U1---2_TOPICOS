using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Cap3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿Qué desea convertir: Grados o Radianes?");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "grados")
            {
                Console.WriteLine("Ingrese el valor en grados:");
                double grados;
                while (!double.TryParse(Console.ReadLine(), out grados))
                {
                    Console.WriteLine("Valor inválido. Por favor, ingrese un número válido:");
                }
                ConvertirAGrados(grados);
            }
            else if (respuesta == "radianes")
            {
                Console.WriteLine("Ingrese el valor en radianes:");
                double radianes;
                while (!double.TryParse(Console.ReadLine(), out radianes))
                {
                    Console.WriteLine("Valor inválido. Por favor, ingrese un número válido:");
                }
                ConvertirARadianes(radianes);
            }
            else
            {
                Console.WriteLine("Respuesta no válida. Por favor, ingrese 'grados' o 'radianes'.");
            }
        }

        static void ConvertirAGrados(double radianes)
        {
            double grados = (radianes * 180) / Math.PI;
            Console.WriteLine($"{radianes} radianes equivalen a {grados} grados.");
        }

        static void ConvertirARadianes(double grados)
        {
            double radianes = (grados * Math.PI) / 180;
            Console.WriteLine($"{grados} grados equivalen a {radianes} radianes.");
        }
    }
}
