using System;
using System.Collections.Generic;
using System.Text;

namespace Consolita
{
    class Sesion4_OpenBootcamp
    {
        /// <summary>
        /// Ejercicio 1 - While
        /// Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola.Es decir, un programa que presente para el 1:
        ///     1 x 1 = 1
        ///     1 x 2 = 2
        ///     1 x 10 = 10
        /// </summary>
        public static void Ejercicio1()
        {
            Console.WriteLine("Ingrese un numero: ");
            string x = Console.ReadLine();
            int num = Convert.ToInt32(x);

            int i = 1;

            while ( i <= 10 )
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
                i++;
            }
        }
    }
}
