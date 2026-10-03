namespace Dias_a_segundos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias, segundos;

            Console.Write("Ingrese cantidad de días: ");
            dias = int.Parse(Console.ReadLine());

            segundos = dias * 24 * 60 * 60;

            Console.WriteLine(dias + " días tienen " + segundos + " segundos.");
        }
    }
}
