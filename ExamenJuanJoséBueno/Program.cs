namespace Examen
{
    /*Desarrollar un programa en C# que permita determinar
     el elemento zodiacal de una persona, en función de su mes de nacimiento y signo zodiacal */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, solo escribir en minúscula para obtener respuesta");
            Console.WriteLine();

            //El programa debe: Solicitar al usuario que ingrese el mes de nacimiento (por ejemplo: "marzo").

            Console.WriteLine("Ingrese el mes de nacimiento (ej: marzo):");
            string mes = Console.ReadLine();

            Console.WriteLine("Ingrese el signo zodiacal (ej: aries):");
            string signo = Console.ReadLine();

            string elemento = ""; // vacio = no coincide

            /* Zuko. (Las opciones de respuesta son: El mes de nacimiento es: marzo, abril, julio, 
            agosto, noviembre o diciembre,Y El signo zodiacal es: Aries, Leo o Sagitario.*/

            if ((mes == "marzo" || mes == "abril" || mes == "julio" || mes == "agosto" || mes == "noviembre" || mes == "diciembre")
                &&
                (signo == "aries" || signo == "leo" || signo == "sagitario"))
            {
                elemento = "Fuego";
            }

            /* Toph. (Las opciones de respuesta son: El mes de nacimiento es: abril, mayo, agosto,
            septiembre, diciembre o enero, Y El signo zodiacal es: Tauro, Virgo o Capricornio..*/

            else if ((mes == "abril" || mes == "mayo" || mes == "agosto" || mes == "septiembre" || mes == "diciembre" || mes == "enero")
                     &&
                     (signo == "tauro" || signo == "virgo" || signo == "capricornio"))
            {
                elemento = "Tierra";
            }

            /* Aang. (El mes de nacimiento es: mayo, junio, septiembre, octubre, enero o febrero,
            Y El signo zodiacal es: Géminis, Libra o Acuario.)*/

            else if ((mes == "mayo" || mes == "junio" || mes == "septiembre" || mes == "octubre" || mes == "enero" || mes == "febrero")
                     &&
                     // manejar "géminis" con o sin tilde (Me avive, profe muajaja)
                     (signo == "géminis" || signo == "geminis" || signo == "libra" || signo == "acuario"))
            {
                elemento = "Aire";
            }

            /* Katara. El mes de nacimiento es: marzo, junio, julio, octubre, 
            noviembre, febrero, Y El signo zodiacal es: Cáncer, Escorpión o Piscis.*/

            else if ((mes == "marzo" || mes == "junio" || mes == "julio" || mes == "octubre" || mes == "noviembre" || mes == "febrero")
                     &&
                     (signo == "cáncer" || signo == "cancer" || signo == "escorpión" || signo == "escorpion" || signo == "piscis"))
            {
                elemento = "Agua";
            }

            // Mostrar resultado (o si no tiene semejante)
            if (elemento != "")
            {
                Console.WriteLine($"El elemento de la persona es {elemento}");
            }
            else
            {
                Console.WriteLine("Los datos no coinciden con ninguna categoría.");
            }
        }
    }
}