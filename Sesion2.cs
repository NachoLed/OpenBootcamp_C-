using System;
using System.Collections.Generic;
using System.Text;

namespace Consolita
{
    class Sesion2_OpenBootcamp
    {
        /// <summary>
        /// Ejercicio 1
        /// Variables - Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje.Ej: nombre, apellido, edad, sabe programar, etc.
        /// </summary>
        public static void Ejercicio1()
        {
            Console.WriteLine("Como te llamas?");
            string name = Console.ReadLine();
            Console.WriteLine("Cuantos años tenes?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A que te dedicas?");
            string job = Console.ReadLine();
            Console.WriteLine("Alguna vez Programaste?");
            string developer = Console.ReadLine();
            Console.WriteLine("RESUMEN");

            Console.WriteLine("Hola, mi nombre es {0}, tengo {1} años. Me dedico a {2} y  {3} se programar", name, age, job, developer);

        }
        /// <summary>
        /// Ejercicio 2
        /// Tipos - Usando los tipos de variables más adecuados, describe los objetos siguientes:
        /// Coche: puertas, ruedas, marca, ITV vigente
        /// Mesa: peso, largo, material, color
        /// Nota: puedes escribir estos datos por consola si prefieres verlos.La idea del ejercicio es almacenar los datos en los tipos más adecuados.
        /// </summary>
        public static void Ejercicio2()
        {
            // Coche
            int puertas = 3;
            int ruedas = 4;
            string marca = "Renault";
            bool ITVVigente = true;

            // Mesa
            float peso = 25.304f;
            float largo = 1.80f;
            string material = "Madera";
            string color = "Nogal";

            Console.WriteLine("\nDatos del coche:");
            Console.WriteLine("Puertas: " + puertas);
            Console.WriteLine("Ruedas: " + ruedas);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("ITV vigente: " + ITVVigente);

            Console.WriteLine("\nDatos de la mesa:");
            Console.WriteLine("Peso: " + peso + " kg");
            Console.WriteLine("Largo: " + largo + " m");
            Console.WriteLine("Material: " + material);
            Console.WriteLine("Color: " + color);
        }
        
        /// <summary>
        /// Ejercicio 3
        /// Operadores - Determina los operadores para verificar las siguientes condiciones:
        /// Un número es mayor o igual a 18
        /// Un char es ‘a’
        /// Se cumplen dos conciones a la vez(ambas verdaderas)
        /// Se cumple una de dos condiciones a la vez(una true y otra false)
        /// Nota: puedes escribir estos datos por consola si prefieres verlos.La idea del ejercicio es almacenar los datos en los tipos más adecuados.
        /// </summary>
        public static void Ejercicio3()
        {            
            Console.Write("Ingrese un número: ");
            string numeroStr = Console.ReadLine();
            int numero = Convert.ToInt32(numeroStr);
            
            Console.Write("Ingrese un caracter: ");
            string caracterStr = Console.ReadLine();
            char caracter = Convert.ToChar(caracterStr);

            bool esMayorOIgualA18 = numero >= 18;
            Console.WriteLine("¿El número es mayor o igual a 18? " + esMayorOIgualA18);

            bool esLetraA = caracter == 'a';
            Console.WriteLine("¿El caracter es la letra 'a'? " + esLetraA);
           
       
            bool ambasCondiciones = esMayorOIgualA18 && esLetraA;
            Console.WriteLine("¿Se cumplen ambas condiciones? " + ambasCondiciones);

       
            bool unaDeLasCondiciones = esMayorOIgualA18 || esLetraA;
            Console.WriteLine("¿Se cumple una de las dos condiciones? " + unaDeLasCondiciones);

        }
    }
}
