namespace Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Temp;

            Console.WriteLine("Ingrese la temperatura en grados");
            Temp = double.Parse(Console.ReadLine());

            if (Temp <= 0)
            {
                Console.WriteLine("Hace frio");
            }
            else
            {
                Console.WriteLine("Hace calor");
            }

            Console.ReadKey();
        }
    }
}
