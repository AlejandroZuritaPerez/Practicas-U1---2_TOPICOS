using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Cap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime un Número?");
            int X;

            //Leer el número dado por el usuario

            while (!int.TryParse(Console.ReadLine(), out X) || X < 0)
            {
                Console.WriteLine("El numero dado por el usuario es invalido. Favor de ingresar un numero mayor a 0");
                Console.WriteLine("Digame otro numero:");
            }

            //Detención Par e Impar
            if ((X % 2) == 0)
            {
                Console.WriteLine("El numero es Par");
            }
            else
            {
                Console.WriteLine("El numero es Impar");
            }


        }
    }
}
