namespace Numero_positivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Ingrese un numero:");
            num = double.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("El numero es positivo");
            }
        }
    }
}
