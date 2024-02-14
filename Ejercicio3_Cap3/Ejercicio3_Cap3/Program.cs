using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Cap3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿El producto es medicina? (responda 'si' o 'no'):");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "si")
            {
                Console.WriteLine("El producto es medicina. El impuesto es del 0%.");
            }
            else if (respuesta == "no")
            {
                Console.WriteLine("Ingrese el precio del producto:");
                double precio;
                while (!double.TryParse(Console.ReadLine(), out precio) || precio < 0)
                {
                    Console.WriteLine("Precio inválido. Por favor, ingrese un número válido mayor o igual a 0:");
                }
                CalcularImpuesto(precio);
            }
            else
            {
                Console.WriteLine("Respuesta no válida. Por favor, responda 'si' o 'no'.");
            }
        }

        static void CalcularImpuesto(double precio)
        {
            // Suponiendo un impuesto del 16% para productos que no son medicina
            double impuesto = precio * 0.16;
            double precioTotal = precio + impuesto;
            Console.WriteLine($"El impuesto del producto es del 16%.");
            Console.WriteLine($"El impuesto a pagar es: {impuesto:C}");
            Console.WriteLine($"El precio total a pagar es: {precioTotal:C}");

        }
    }
}
