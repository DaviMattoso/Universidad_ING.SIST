namespace Peso_en_ascensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;

            Console.WriteLine("Ingrese el peso:");
            peso = double.Parse(Console.ReadLine());

            if (peso > 120)
            {
                Console.WriteLine("El peso limite para entrar en el ascensor es de 120 kg");
            }
        }
    }
}
