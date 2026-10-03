namespace Convertir_segundos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSegundos, horas, minutos, segundos, restoSegundos;

            Console.Write("Ingrese el total de segundos: ");
            totalSegundos = int.Parse(Console.ReadLine());

            horas = totalSegundos / 3600;                   // División entera para obtener horas completas
            restoSegundos = totalSegundos % 3600;           // Resto de segundos después de sacar las horas

            minutos = restoSegundos / 60;                   // División entera para minutos
            segundos = restoSegundos % 60;                  // Segundos restantes

            Console.WriteLine("Horas: " + horas);
            Console.WriteLine("Minutos: " + minutos);
            Console.WriteLine("Segundos: " + segundos);
        }
    }
}
