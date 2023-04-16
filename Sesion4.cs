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
            Console.WriteLine("\n ############# Ejercicio 1 #############");
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

        /// <summary>
        /// Ejercicio 2 - Do while
        /// Escribe un programa que realice estos pasos:
        /// - Reciba al menos un número por consola
        /// - Determine si el número es positivo o negativo
        /// - Presente un contador para cada tipo(positivo y negativo).
        /// 
        /// Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo.Tienes completa libertad para elegir el formato de la salida.
        /// </summary>
        public static void Ejercicio2()
        {
            Console.WriteLine("\n ############# Ejercicio 2 #############");
            int x = 0;
            char continua = 'Y';
            int pos = 0;
            int neg = 0;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                x = Convert.ToInt32(Console.ReadLine());

                if (x == 0)
                    Console.WriteLine("No pasa nada loko, esta todo bien");
                else if (x > 0)
                    pos++;
                else
                    neg++;

                Console.WriteLine("Desea continuar ? Y/N : ");
                continua = Convert.ToChar(Console.ReadLine());               

            } while (char.ToUpper(continua) == 'Y');

            Console.WriteLine("Se han ingresado :\n\t{0} Positivos\n\t{1} Negativos", pos, neg);
        }
    }
}
