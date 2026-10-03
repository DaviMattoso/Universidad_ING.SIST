namespace Metros_a_pulgadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metros, pulgadas;

            Console.Write("Ingrese metros: ");
            metros = double.Parse(Console.ReadLine());

            pulgadas = metros * 39.3701;

            Console.WriteLine(metros + " metros son " + pulgadas + " pulgadas.");
        }
    }
}
