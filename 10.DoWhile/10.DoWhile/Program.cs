using System;

namespace AdivinaNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que genera y suma los primeros 5 números enteros

            /*int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador = acumulador + contador;
            } while (contador < 5);

            Console.WriteLine("la suma de los cinco primeros números enteros es: " + acumulador);*/

            //17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10.
            //Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar

            int numero = 0;
            string respuesta = "";
            int contador = 1;

            do
            {
                Console.WriteLine("Ingrese un número para calcular su tabla de multiplicar:");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                    contador++;
                } while (contador <= 10);

               
                contador = 1;
                Console.WriteLine("Desea generar una nueva taba de multiplicar: s:sí , n:no");
                respuesta = Console.ReadLine().ToLower();
                
            } while (respuesta == "s");  
        }
    }
}
