namespace _9.B.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita calcular la factorial de un número dado por el usuario
             (5! = 1*2*3*4*5)*/

            int num = 0;
            int acumulador = 1;
            int contador = 1;

            Console.WriteLine("Ingrese un número para calcular su factorial");
            num=int.Parse(Console.ReadLine());

            while (contador <= num) 
            {
                acumulador=acumulador*contador;
                Console.WriteLine($"Contador: {contador} - FaSctorial: {acumulador}");
                contador++;
            }
            Console.WriteLine($"El factorial del número {num}, es {acumulador}");
        }
    }
}
