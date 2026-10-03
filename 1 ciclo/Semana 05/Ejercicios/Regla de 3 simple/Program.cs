namespace Regla_de_3_simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cantidadOriginal, precioTotalOriginal;
            double cantidadDeseada, precioTotalDeseado, precioPorUnidad;

            Console.Write("Ingrese la cantidad total de productos originales: ");
            cantidadOriginal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el precio total de los productos originales: ");
            precioTotalOriginal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la cantidad de productos que desea llevar: ");
            cantidadDeseada = Convert.ToDouble(Console.ReadLine());

            precioTotalDeseado = (cantidadDeseada * precioTotalOriginal) / cantidadOriginal;
            precioPorUnidad = precioTotalOriginal / cantidadOriginal;

            Console.WriteLine($"El precio total de los productos que desea llevar es: {precioTotalDeseado}");
            Console.WriteLine($"El precio por unidad del producto es: {precioPorUnidad}");
        }
    }
}
