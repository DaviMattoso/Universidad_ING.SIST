namespace Minutos_a_horas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double minutos, horas;

            Console.Write("Ingrese minutos: ");
            minutos = double.Parse(Console.ReadLine());

            horas = minutos / 60;

            Console.WriteLine(minutos + " minutos son " + horas + " horas.");
        }
    }
}
