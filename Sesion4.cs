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

        /// <summary>
        /// Ejercicio 3 - For
        /// Escribe un programa que realice estos pasos:
        /// Reciba 3 datos:
        /// ancho
        /// alto
        /// relleno o no
        /// Dibuje en consola con un mismo caracter, por ejemplo*, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno(tiene más * dentro) o no.
        /// En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
        /// Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla.Ejemplos:
        /// Input: 2,2,2, relleno = true
        /// Output:
        /// ** **
        /// ** **
        /// Input: 3, 4, 1, relleno = false
        /// Output:
        /// ***
        /// * *
        /// * *
        /// ***
        /// </summary>
        public static void Ejercicio3()
        {
            Console.WriteLine("\n ############# Ejercicio 3 #############");
            Console.WriteLine("Ingrese el Ancho: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el Alto: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Debe estar relleno ? Y/N : ");
            char filled = Convert.ToChar(Console.ReadLine());

            bool fill = false;

            if (char.ToUpper(filled) == 'Y')
                fill = true;

            Console.WriteLine("Cuantas copias desea: ");
            int cant = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n***RESULTADO***\n");
           
            for ( int i = 0; i < height; i++)
            {
                for (int h = 0; h < cant; h++) 
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (!fill && ((j != 0) && (j != width - 1)))
                            Console.Write(" ");
                        else
                            Console.Write("|");
                    }
                    Console.Write("\t");                    
                }                
                Console.WriteLine();
            }
        }
    }
}
