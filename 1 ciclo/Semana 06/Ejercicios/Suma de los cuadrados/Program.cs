namespace Suma_de_los_cuadrados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.Write("Ingrese dos números (a y b): ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            double sumaCuadrados = Math.Pow(a, 2) + Math.Pow(b, 2);

            Console.WriteLine("Suma de cuadrados: " + sumaCuadrados);
        }
    }
}
