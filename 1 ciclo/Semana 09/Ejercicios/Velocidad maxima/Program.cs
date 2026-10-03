namespace Velocidad_maxima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double velocidad;

            Console.WriteLine("Ingrese la velocidad del vehículo:");
            velocidad = double.Parse(Console.ReadLine());

            if (velocidad > 50)
            {
                Console.WriteLine("Se ultrapaso el limite de velocidad");
            }
        }
    }
}
