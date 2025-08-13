using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _4.CondicionalesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Cree un algoritmo que permita ingresar el nombre y el sueldo de una persona,
             * si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, 
             * indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”. 
             
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if(sueldo>=3000)
            {
                //true
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else 
            {
                //False
                Console.WriteLine($"La persona {nombre}, no abona impuestos");
            }*/

            //Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje:
            //“Bienvenido a mi sitio web”. De lo contrario, mostrar el mensaje “No es apto para el contenido de este sitio web”.  

            /* string nombre = "";
             int edad = 0;

             Console.WriteLine("ingrese el nombre");
             nombre = Console.ReadLine();

             Console.WriteLine("ingrese la edad");
             edad = Int32.Parse(Console.ReadLine());

             if (edad >= 18)
             {
                 Console.WriteLine($"Bienvenido, consumidor promedio");
             }
             else
             {
                 Console.WriteLine($"No es apto para el contenido de este sitio web");
             }*/

            //Crear un algoritmo que permita ingresar dos números,
            //si el primer número es mayor al segundo número informar su suma y diferencia,
            //en caso contrario informar el producto y la división del primer número respecto al segundo número. 

            /*int numero1 = 0;
            int numero2 = 0;
          

            Console.WriteLine("ingrese un numero");
            numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro numero");
            numero2 = Int32.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"La suma es {numero1 + numero2} y su resta es {numero1 - numero2}");
            }
            else 
            {
                Console.WriteLine($"El producto de sus numeros es {numero1 * numero2} y la division es {numero1 / numero2}");
            }*/

            //Un cliente se hospeda varias noches en una hostería, el precio por noche es de 200 dólares. 
            // Si el usuario se queda más de 3 noches se le aplica un porcentaje de descuento del 17 %
            // y si no se aplica un porcentaje de descuento del 2 %.

            int noches = 0;
            float descuento = 0f;

            Console.WriteLine("¿Cuantas noches se va a quedar en Freddy Fazbear´s Pizzeria?");
            noches = Int32.Parse(Console.ReadLine());

            if (noches > 3)
            {
                descuento = 0.17f;
                Console.WriteLine($"Usted debe pagar {200*noches-(200*noches*descuento)} por su estadía");
            }
            else 
            {
                descuento = 0.2f;
                Console.WriteLine($"Usted debe pagar {200*noches-(200*noches*descuento)}");
            }
        }
    }
}