using System;
using System.Collections.Generic;
using System.Text;

namespace Consolita
{
    class Sesion1_OpenBootcamp
    {
        /// <summary>
        /// Ejercicio 1
        ///     Escribe un programa que reciba tu nombre y lo escriba por consola.
        /// </summary>
        public static void Ejercicio1()
        {
            Console.WriteLine("Escribe tu nombre: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hola {0}", name);
        }

        /// <summary>
        /// Ejercicio 2
        ///     Escribe un programa que tome la hora y la escriba por pantalla.
        /// </summary>
        public static void Ejercicio2()
        {
            Console.WriteLine("La Hora Actual es {0}", DateTime.Now.ToString("HH:mm"));        
        }
    }
}
