namespace _5.Condicional_Anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONDICIONAL ANIDADO   
            /*1. Diseñar un algoritmo que lea tres números A, B, C y visualice en
             * pantalla el valor más grande. El usuario debe ingresr tres valores
             * diferentes*/

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El primer número: {num1}, es el mayor");
                }
                else
                {
                    Console.WriteLine($"El tercer número: {num3}, es el mayor");
                }
            }
            else 
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"El segundo número: {num2}, es el mayor");
                }
                else
                {
                    Console.WriteLine($"El tercer número: {num3}, es el mayor");
                }
            }
        }
    }
}
