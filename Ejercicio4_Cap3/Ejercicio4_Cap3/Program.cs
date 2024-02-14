using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Cap3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un número del 1 al 7:");
            int numeroDia;
            while (!int.TryParse(Console.ReadLine(), out numeroDia) || numeroDia < 1 || numeroDia > 7)
            {
                Console.WriteLine("Número inválido. Por favor, ingrese un número del 1 al 7:");
            }
            MostrarDiaSemana(numeroDia);
        }

        static void MostrarDiaSemana(int numeroDia)
        {
            string nombreDia;
            switch (numeroDia)
            {
                case 1:
                    nombreDia = "Lunes";
                    break;
                case 2:
                    nombreDia = "Martes";
                    break;
                case 3:
                    nombreDia = "Miércoles";
                    break;
                case 4:
                    nombreDia = "Jueves";
                    break;
                case 5:
                    nombreDia = "Viernes";
                    break;
                case 6:
                    nombreDia = "Sábado";
                    break;
                case 7:
                    nombreDia = "Domingo";
                    break;
                default:
                    nombreDia = "Día no válido";
                    break;
            }
            Console.WriteLine($"El número {numeroDia} corresponde al día {nombreDia}.");

        }
    }
}
