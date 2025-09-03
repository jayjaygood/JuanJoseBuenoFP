using System;

namespace SumaNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*11. Realizar un algoritmo que pida números enteros positivos y los sume,
             hasta que se ingrese un número entero negativo. 
             Se debe mostrar por pantalla el total de la suma de los números ingresados.*/

            /*int numero;
            int suma = 0;

            Console.WriteLine("Ingrese un número entero positivo (negativo para terminar):");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                suma = suma + numero;

                Console.WriteLine("Ingrese otro número entero positivo (negativo para terminar):");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La suma total de los números ingresados es: " + suma);*/


            //12. Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99. 

            /*int numero = 1;   // empezamos en el primer impar
            int suma = 0;

            while (numero <= 99)
            {
                suma = suma + numero;
                numero = numero + 2; // pasamos al siguiente impar
            }

            Console.WriteLine("La suma de todos los números impares hasta 99 es: " + suma);*/


            //13. Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n. 

            Console.WriteLine("Ingrese un número entero positivo (n):");
            int n = int.Parse(Console.ReadLine());

            int numero = 1;
            int contadorPares = 0;

            while (numero <= n)
            {
                if (numero % 2 == 0) // condición de par
                {
                    contadorPares++;
                }
                numero++;
            }

            Console.WriteLine("La cantidad de números pares entre 1 y " + n + " es: " + contadorPares);
        }
    }
}

