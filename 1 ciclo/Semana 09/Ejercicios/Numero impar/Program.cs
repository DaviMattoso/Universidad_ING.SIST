namespace Numero_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Ingrese un numero:");
            num = double.Parse(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}
