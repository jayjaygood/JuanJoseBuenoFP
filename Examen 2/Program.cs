class Program
{
    static void Main(string[] args)
    {
        /*Don Alcides, un tendero, realiza la venta de 10 productos y 
        necesita calcular el valor total de la venta aplicando el IVA correspondiente a cada uno de ellos según las siguientes condiciones:
        Si el valor del producto es mayor a 10.000, se aplica un 15% de IVA.
        Si el valor del producto es menor o igual a 5.000, se aplica un 19% de IVA.

        El programa debe realizar lo siguiente:
        1. Solicitar por teclado el valor de cada uno de los 10 productos.
        2. Calcular el subtotal de cada producto, teniendo en cuenta el valor ingresado más el IVA correspondiente.
        3. Sumar los subtotales de los 10 productos.
        4. Mostrar en pantalla el valor total de la venta.
        */

        double totalVenta = 0; 

        Console.WriteLine("Saludos cordiales, consumidor promedio.");
        Console.WriteLine("Bienvenido a los Pollos Hermanos.");
        Console.WriteLine("Le pido que por favor ingrese el valor de los 10 productos que desea llevar.");
        Console.WriteLine("Recuerde:");
        Console.WriteLine("- Si el producto vale más de 10.000 se aplica 15% de IVA.");
        Console.WriteLine("- Si el producto vale 5.000 o menos se aplica 19% de IVA.");
        Console.WriteLine("- Si está entre 5.001 y 10.000 no se aplica IVA.");
        Console.WriteLine("-------------------------------------------------");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese el valor del producto " + i + ": ");
            double valor = double.Parse(Console.ReadLine());

            double iva = 0;

            if (valor > 10000)
            {
                iva = valor * 0.15;
            }
            else if (valor <= 5000)
            {
                iva = valor * 0.19;
            }
            else
            {
                iva = 0;
            }

            double subtotal = valor + iva;
            totalVenta += subtotal;
        }

        Console.WriteLine("\nEl valor total de la venta es: " + totalVenta);
    }
}
