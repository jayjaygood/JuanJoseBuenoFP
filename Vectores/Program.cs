using System;

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que crea una matriz de 4 filas y 4 columnas y muestre por pantalla la suma de los elementos de cada columna.

            /*int[,] numeros = new int[4, 4];
            int[]sumaColumnas = new int[numeros.GetLength(1)];

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el numero para la posicion [{i},{j}]");
                    numeros[i, j] = int.Parse(Console.ReadLine());

                }
            }

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"{numeros[i, j]} |");

                }
            }

            for (int j = 0; j < numeros.GetLength(1); j++)
            {
                int suma = 0;
                for (int i = 0; i < numeros.GetLength(0); i++)
                {
                    sumaColumnas[i] += numeros[j, i];
                }
                Console.WriteLine($"La suma de la columna {j} es: {suma}");
            }  */

            //1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas
            //  y muestre por pantalla la suma de los elementos de cada columna.

            /*int filas = 10;
            int columnas = 20;
            int[,] matriz = new int[filas, columnas];
            int[] sumaColumnas = new int[columnas];

            Random rnd = new Random();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rnd.Next(1, 10); // números del 1 al 9
                }
            }

            for (int j = 0; j < columnas; j++)
            {
                int suma = 0;
                for (int i = 0; i < filas; i++)
                {
                    suma += matriz[i, j];
                }
                sumaColumnas[j] = suma;
            }

            Console.WriteLine("Matriz (10 filas x 20 columnas):\n");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSuma de cada columna:");
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(sumaColumnas[j].ToString().PadLeft(3));
            }

            Console.WriteLine(); */

            //2.Desarrollar un programa que crea una matriz de n filas * m columnas, 
            // el usuario ingresa caracteres en cada posición de la matriz hasta llenarla. 
            // El programa debe intercambiar la primera fila con la última fila de la matriz. 
            // Al final se debe imprimir la matriz original, y la matriz con el intercambio de filas.

            /* Console.Write("Ingrese el número de filas: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int m = int.Parse(Console.ReadLine());

            char[,] matriz = new char[n, m];

            Console.WriteLine("\nIngrese los caracteres de la matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Posición [{i},{j}]: ");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz original:");
            ImprimirMatriz(matriz, n, m);

            for (int j = 0; j < m; j++)
            {
                char temp = matriz[0, j];
                matriz[0, j] = matriz[n - 1, j];
                matriz[n - 1, j] = temp;
            }

            Console.WriteLine("\nMatriz después de intercambiar primera y última fila:");
            ImprimirMatriz(matriz, n, m);
        }
        static void ImprimirMatriz(char[,] matriz, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            //3. Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 
            // en una matriz de 5x5 llena de números aleatorios.

            /*int filas = 5;
            int columnas = 5;
            int[,] matriz = new int[filas, columnas];
            int[] frecuencia = new int[10]; 

            Random rnd = new Random();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rnd.Next(1, 11); 
                }
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int numero = matriz[i, j];
                    frecuencia[numero - 1]++; 
                }
            }

            Console.WriteLine("Matriz 5x5:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nFrecuencia de cada número (1 al 10):");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Número {i + 1}: {frecuencia[i]} veces");
            }*/

            //Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X"
            //en posiciones aleatorias. 
            //Luego, el algoritmo le debe permitir al usuario intentar adivinar la posición de una "X".
            
            int filas = 5, columnas = 5;
            char[,] tablero = new char[filas, columnas];

            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    tablero[i, j] = '-';

            Random rnd = new Random();
            int colocadas = 0;
            while (colocadas < 3)
            {
                int f = rnd.Next(0, filas);
                int c = rnd.Next(0, columnas);
                if (tablero[f, c] == '-') 
                {
                    tablero[f, c] = 'X';
                    colocadas++;
                }
            }

            bool acerto = false;

            for (int intento = 1; intento <= 3; intento++)
            {
                Console.WriteLine($"\nIntento {intento}/3");
                Console.Write("Ingrese fila (0 a 4): ");
                int fila = int.Parse(Console.ReadLine());

                Console.Write("Ingrese columna (0 a 4): ");
                int col = int.Parse(Console.ReadLine());

                if (fila >= 0 && fila < filas && col >= 0 && col < columnas)
                {
                    if (tablero[fila, col] == 'X')
                    {
                        Console.WriteLine("\n¡Éxito! Encontraste una 'X'.");
                        acerto = true;

                        for (int i = 0; i < filas; i++)
                        {
                            for (int j = 0; j < columnas; j++)
                            {
                                if (i == fila && j == col)
                                    Console.Write("X ");
                                else
                                    Console.Write("- ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aquí no hay una 'X'.");
                    }
                }
                else
                {
                    Console.WriteLine("Coordenadas fuera de rango, intenta de nuevo.");
                }
            }

            if (!acerto)
            {
                Console.WriteLine("\nSkill issue, no encontraste ninguna 'X'. Aquí estaba el tablero:");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(tablero[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
