namespace Litros_a_Mililitros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double litros, mililitros;

            Console.Write("Ingrese litros: ");
            litros = double.Parse(Console.ReadLine());

            mililitros = litros * 1000;

            Console.WriteLine(litros + " litros son " + mililitros + " mililitros.");
        }
    }
}
