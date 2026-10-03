namespace Interes_simnple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capital, tasa, tiempo, interes;

            Console.Write("Ingrese capital: ");
            capital = double.Parse(Console.ReadLine());

            Console.Write("Ingrese tasa (ejemplo 0.05 para 5%): ");
            tasa = double.Parse(Console.ReadLine());

            Console.Write("Ingrese tiempo (años): ");
            tiempo = double.Parse(Console.ReadLine());

            interes = capital * tasa * tiempo;

            Console.WriteLine("Interés simple: " + interes);
        }
    }
}
