namespace Volumen_del_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado, volumen;

            Console.Write("Ingrese el valor del lado del cubo: ");
            lado = double.Parse(Console.ReadLine());

            volumen = Math.Pow(lado, 3);  // lado al cubo

            Console.WriteLine("El volumen del cubo es de: " + volumen);
        }
    }
}
