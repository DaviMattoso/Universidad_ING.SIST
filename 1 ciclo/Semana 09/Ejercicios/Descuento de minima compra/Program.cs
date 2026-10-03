namespace Descuento_de_minima_compra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio;

            Console.WriteLine("Ingrese el precio total de la compra");
            precio = double.Parse(Console.ReadLine());

            if (precio >= 100)
            {
                Console.WriteLine("La compra tiene un descuento de 20%");
            }
        }
    }
}
