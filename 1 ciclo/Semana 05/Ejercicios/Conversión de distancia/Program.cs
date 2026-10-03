namespace Conversión_de_distancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metros, centimetos, milimetros;
            Console.WriteLine("Ingrese la distancia en metros:");
            metros = double.Parse(Console.ReadLine());

            centimetos = metros * 100;
            milimetros = metros * 1000;

            Console.WriteLine($"La cantidad en Centimetros es de: {centimetos}");
            Console.WriteLine($"La cantidad en Milimetros es de: {milimetros}" );
        }
    }
}
