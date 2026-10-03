namespace Tiempo_en_segundos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double horas, minutos, segundos, totalSegundos;

            Console.Write("Ingrese la cantidad de horas: ");
            horas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la cantidad de minutos: ");
            minutos = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la cantidad de segundos: ");
            segundos = Convert.ToDouble(Console.ReadLine());

            totalSegundos = (horas * 3600) + (minutos * 60) + segundos;

            Console.WriteLine($"El total de segundos es: {totalSegundos}");
        }
    }
}
