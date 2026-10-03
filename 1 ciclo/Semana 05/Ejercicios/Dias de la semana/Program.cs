namespace Dias_de_la_semana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias, diassobrando, semanas;

            Console.WriteLine("Ingrese la cantidad de dias:");
            dias = int.Parse(Console.ReadLine());

            semanas = dias / 7; //DIV división entera
            diassobrando = dias % 7; //MOD resto de la división

            Console.WriteLine($"{dias} días equivalen a {semanas} semanas y {diassobrando} días.");

        }
    }
}
