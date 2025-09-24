using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        1. Escribir un algoritmo que permita llenar un vector[15] con números enteros, 
        y luego encuentre y muestre el valor máximo y mínimo de los números ingresados */

        /*int[] numeros = new int[15]; 

        Console.WriteLine("Ingrese 15 números enteros:");

        for (int i = 0; i < 15; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int max = numeros[0];
        int min = numeros[0];

        for (int i = 1; i < 15; i++)
        {
            if (numeros[i] > max)
            {
                max = numeros[i];
            }
            if (numeros[i] < min)
            {
                min = numeros[i];
            }
        }

        Console.WriteLine("\nEl número máximo es: " + max);
        Console.WriteLine("El número mínimo es: " + min);
        */

        /*2. 
        Escribe un algoritmo que permita ingresar caracteres en un vector,
        y luego invierta el orden de los elementos del vector. 
        Se deben mostrar los dos vectores.
        */

        /* 
        char[] vector = new char[5]; 

         Console.WriteLine("Ingrese 5 carácteres:");

         for (int i = 0; i < vector.Length; i++)
         {
             Console.Write("Carácter " + (i + 1) + ": ");
             vector[i] = char.Parse(Console.ReadLine());
         }

         // Mostrar vector original
         Console.WriteLine("\nVector original:");
         for (int i = 0; i < vector.Length; i++)
         {
             Console.Write(vector[i] + " ");
         }

         // Invertir el vector
         char[] invertido = new char[vector.Length];
         for (int i = 0; i < vector.Length; i++)
         {
             invertido[i] = vector[vector.Length - 1 - i];
         }

         // Mostrar vector invertido
         Console.WriteLine("\n\nVector invertido:");
         for (int i = 0; i < invertido.Length; i++)
         {
             Console.Write(invertido[i] + " ");
         }
         */

        /*
        3. Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre 0 y 50. 
        Luego le debe pedir al usuario un número para buscar en el vector. 
        Si encuentra el número, se debe mostrar en pantalla: 
        la posición en que se encuentra el número, y el vector resaltando el número en un color diferente. 
        Si no se encuentra el número, se debe devolver y mostrar -1.
        */

        /*
        int[] vector = new int[20];
        Random rnd = new Random();

        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = rnd.Next(0, 51); 
        }

        Console.WriteLine("Vector generado:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }

        Console.WriteLine("\n\nIngrese un número para buscar en el vector:");
        int numBuscado = int.Parse(Console.ReadLine());

        int posicion = -1;

        // Buscar el número
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] == numBuscado)
            {
                posicion = i;
                break; 
            }
        }

        if (posicion != -1)
        {
            Console.WriteLine("\nNúmero encontrado en la posición: " + posicion);

            Console.WriteLine("\nVector con el número resaltado:");
            for (int i = 0; i < vector.Length; i++)
            {
                if (i == posicion)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; 
                    Console.Write(vector[i] + " ");
                    Console.ResetColor(); 
                }
                else
                {
                    Console.Write(vector[i] + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("\n-1 (Número no encontrado)");
        }
        */

        /*
        4. Escribir un algoritmo que permita:
        Crear un vector con rango impar, exceptuando el 1,
        Pedirle al usuario un número entero y almacenarlo en la mitad del vector.
        Llenar la primera mitad del vector, con los números menores al número almacenado en la posición de la mitad.
        Llenar la parte inicial del vector, con los números menores al número almacenado en la posición de la mitad.
        Llenar la parte final del vector, con los números mayores al número almacenado en la
        posición de la mitad.
        Mostrar el vector en pantalla.
        */

        /*
        Console.WriteLine("Ingrese el tamaño del vector (impar y mayor que 1): ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0 || n <= 1)
        {
            Console.WriteLine("El tamaño debe ser un número impar mayor que 1.");
            return;
        }

        int[] vector = new int[n];
        int mitad = n / 2;

        Console.WriteLine("Ingrese un número entero para almacenar en la mitad del vector: ");
        int numCentral = int.Parse(Console.ReadLine());

        vector[mitad] = numCentral;

        for (int i = 0; i < mitad; i++)
        {
            vector[i] = numCentral - (mitad - i);
        }

        for (int i = mitad + 1; i < n; i++)
        {
            vector[i] = numCentral + (i - mitad);
        }

        Console.WriteLine("\nVector resultante:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(vector[i] + " ");
        }
        */

        /*
        5. Escribir un algoritmo que permita:
        Crear dos vectores, el rango para cada uno de los vectores los debe ingresar el usuario.
        LLenar el primer vector con números aleatorios entre 0 y su rango+1
        LLenar el segundo vector con números aleatorios entre rango y rango*2
        Combinar los dos vectores en uno solo.
        Mostrar en pantalla los tres vectores
        */

        Random rnd = new Random();

        Console.Write("Ingrese el tamaño del primer vector: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tamaño del segundo vector: ");
        int n2 = int.Parse(Console.ReadLine());

        int[] vector1 = new int[n1];
        int[] vector2 = new int[n2];
        int[] combinado = new int[n1 + n2];

        for (int i = 0; i < n1; i++)
        {
            vector1[i] = rnd.Next(0, n1 + 2);
        }

        for (int i = 0; i < n2; i++)
        {
            vector2[i] = rnd.Next(n2, n2 * 2 + 1);
        }

        for (int i = 0; i < n1; i++)
        {
            combinado[i] = vector1[i];
        }
        for (int i = 0; i < n2; i++)
        {
            combinado[n1 + i] = vector2[i];
        }

        Console.WriteLine("\nVector 1:");
        for (int i = 0; i < n1; i++)
        {
            Console.Write(vector1[i] + " ");
        }

        Console.WriteLine("\n\nVector 2:");
        for (int i = 0; i < n2; i++)
        {
            Console.Write(vector2[i] + " ");
        }

        Console.WriteLine("\n\nVector Combinado:");
        for (int i = 0; i < combinado.Length; i++)
        {
            Console.Write(combinado[i] + " ");
        }
    }
}
