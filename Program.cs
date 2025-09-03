using System;

namespace ContarPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14.Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. 
            Al usuario le corresponde ingresar la cantidad de números que va a introducir.
            El algoritmo debe escribir en pantalla: 
            La cantidad de números introducidos que son mayores que 0
            La cantidad de números introducidos menores que 0
            La cantidad de números iguales a 0.*/

            /*Console.Write("Ingrese la cantidad de números que va a introducir: ");
            int cantidad = int.Parse(Console.ReadLine());
            int mayoresQueCero = 0;
            int menoresQueCero = 0;
            int igualesACero = 0;

            while (cantidad > 0)
            {
                Console.Write("Ingrese un número entero: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    mayoresQueCero++;
                }
                else if (numero < 0)
                {
                    menoresQueCero++;
                }
                else
                {
                    igualesACero++;
                }
                cantidad--;
            }

            Console.WriteLine($"Cantidad de números mayores que 0: {mayoresQueCero}");
            Console.WriteLine($"Cantidad de números menores que 0: {menoresQueCero}");
            Console.WriteLine($"Cantidad de números iguales a 0: {igualesACero}");*/

            /*15. Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, 
            si al final de cada mes deposita cantidades variables de dinero; además, 
            se quiere saber cuánto lleva ahorrado cada mes.

            int mes = 1;
            double deposito;
            double ahorroTotal = 0;

            while (mes <= 12)
            {
                Console.WriteLine("Ingrese la cantidad que depositará en el mes " + mes + ":");
                deposito = double.Parse(Console.ReadLine());

                ahorroTotal = ahorroTotal + deposito;

                Console.WriteLine("Ahorro acumulado hasta el mes " + mes + ": " + ahorroTotal);

                mes++;
            }

            Console.WriteLine("\nEl ahorro total en el año es: " + ahorroTotal);*/

            /*16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100.
            El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, 
            demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos
             hasta que el usuario adivine el número. */

            Random rand = new Random();
            int numeroSecreto = rand.Next(1, 101); // genera entre 1 y 100
            int intento = 0;

            Console.WriteLine("He pensado un número entre 1 y 100. ¡Adivina cuál es!");

            while (intento != numeroSecreto)
            {
                Console.Write("Ingresa tu intento: ");
                intento = int.Parse(Console.ReadLine());

                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Demasiado bajo, intenta otra vez.");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto, intenta otra vez.");
                }
                else
                {
                    Console.WriteLine("¡Correcto! El número era " + numeroSecreto);
                }
            }
        }
    }
}