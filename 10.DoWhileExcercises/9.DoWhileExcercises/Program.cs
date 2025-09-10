using System;

class Program
{
    static void Main()
    {
        /*19. En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y 
        cuántos son mujeres, además se desea saber cuántos son mayores de edad y cuántos no.  */

        /* 
        int hombres = 0;
        int mujeres = 0;
        int mayores = 0;
        int menores = 0;

        Console.Write("¿Cuántos estudiantes quiere ingresar?: ");
        int total = Convert.ToInt32(Console.ReadLine());

        int i = 1;

        while (i <= total)
        {
            Console.WriteLine("Estudiante #" + i);

            // --- Sexo ---
            string sexo;
            do
            {
                Console.Write("Ingrese sexo (H/M): ");
                sexo = Console.ReadLine();
            } while (sexo != "H" && sexo != "M" && sexo != "h" && sexo != "m");

            if (sexo == "H" || sexo == "h")
                hombres++;
            else
                mujeres++;

            // --- Edad ---
            Console.Write("Ingrese edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
                mayores++;
            else
                menores++;

            Console.WriteLine("----------------------");
            i++;
        }

        // --- Los Resultados ---
        Console.WriteLine("=== RESULTADOS ===");
        Console.WriteLine("Hombres: " + hombres);
        Console.WriteLine("Mujeres: " + mujeres);
        Console.WriteLine("Mayores de edad: " + mayores);
        Console.WriteLine("Menores de edad: " + menores);*/


        /*20. Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
        El número de partidos perdidos  
        El número de partidos empatados  
        El número de partidos ganados  
        El porcentaje de partidos perdidos  
        El porcentaje de partidos empatados  
        El porcentaje de partidos ganados */

        int ganados = 0;
        int perdidos = 0;
        int empatados = 0;

        int i = 1;
        int totalPartidos = 30;

        while (i <= totalPartidos)
        {
            Console.WriteLine("Partido #" + i);

            string resultado;
            do
            {
                Console.Write("Ingrese resultado (G=Ganado, P=Perdido, E=Empatado): ");
                resultado = Console.ReadLine();
            } while (resultado != "G" && resultado != "g" &&
                     resultado != "P" && resultado != "p" &&
                     resultado != "E" && resultado != "e");

            if (resultado == "G" || resultado == "g")
                ganados++;
            else if (resultado == "P" || resultado == "p")
                perdidos++;
            else
                empatados++;

            Console.WriteLine("----------------------");
            i++;
        }

        // --- Calcular porcentajes ---
        double porcGanados = (ganados * 100.0) / totalPartidos;
        double porcPerdidos = (perdidos * 100.0) / totalPartidos;
        double porcEmpatados = (empatados * 100.0) / totalPartidos;

        // --- Resultados ---
        Console.WriteLine("=== RESULTADOS ===");
        Console.WriteLine("Ganados: " + ganados + " (" + porcGanados + "%)");
        Console.WriteLine("Perdidos: " + perdidos + " (" + porcPerdidos + "%)");
        Console.WriteLine("Empatados: " + empatados + " (" + porcEmpatados + "%)");
    }
}
