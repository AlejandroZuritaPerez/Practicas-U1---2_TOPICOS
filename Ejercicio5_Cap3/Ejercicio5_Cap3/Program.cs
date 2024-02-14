using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_Cap3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿Qué desea calcular: perímetro o área?");
            string opcion = Console.ReadLine().ToLower();

            if (opcion == "perímetro")
            {
                CalcularPerimetro();
            }
            else if (opcion == "área")
            {
                CalcularArea();
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, escriba 'perímetro' o 'área'.");
            }
        }

        static void CalcularPerimetro()
        {
            Console.WriteLine("Ingrese el número de lados del polígono:");
            int numeroLados;
            while (!int.TryParse(Console.ReadLine(), out numeroLados) || numeroLados < 3)
            {
                Console.WriteLine("Número de lados inválido. Por favor, ingrese un número entero mayor o igual a 3:");
            }

            Console.WriteLine("Ingrese la longitud de un lado del polígono:");
            double longitudLado;
            while (!double.TryParse(Console.ReadLine(), out longitudLado) || longitudLado <= 0)
            {
                Console.WriteLine("Longitud de lado inválida. Por favor, ingrese un número real mayor que 0:");
            }

            double perimetro = numeroLados * longitudLado;
            Console.WriteLine($"El perímetro del polígono es: {perimetro}");
        }

        static void CalcularArea()
        {
            Console.WriteLine("Ingrese el número de lados del polígono:");
            int numeroLados;
            while (!int.TryParse(Console.ReadLine(), out numeroLados) || numeroLados < 3)
            {
                Console.WriteLine("Número de lados inválido. Por favor, ingrese un número entero mayor o igual a 3:");
            }

            Console.WriteLine("Ingrese la longitud de un lado del polígono:");
            double longitudLado;
            while (!double.TryParse(Console.ReadLine(), out longitudLado) || longitudLado <= 0)
            {
                Console.WriteLine("Longitud de lado inválida. Por favor, ingrese un número real mayor que 0:");
            }

            double apotema;
            Console.WriteLine("Ingrese la longitud del apotema del polígono:");
            while (!double.TryParse(Console.ReadLine(), out apotema) || apotema <= 0)
            {
                Console.WriteLine("Longitud de apotema inválida. Por favor, ingrese un número real mayor que 0:");
            }

            double area = (numeroLados * longitudLado * apotema) / 2;
            Console.WriteLine($"El área del polígono es: {area}");

        }
    }
}
