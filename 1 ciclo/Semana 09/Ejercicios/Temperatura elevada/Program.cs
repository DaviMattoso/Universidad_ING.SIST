namespace Temperatura_elevada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp;

            Console.WriteLine("Ingrese la temperatura en grados celcius:");
            temp = double.Parse(Console.ReadLine());

            if (temp > 37.5)
            {
                Console.WriteLine("tienes fiebre");
            }
        }
    }
}
