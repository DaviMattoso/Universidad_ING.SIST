namespace Numero_par_o_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Numero;

            Console.WriteLine("Ingrese un numero");
            Numero = double.Parse(Console.ReadLine());

            if (Numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");

            }
            else
            {
                Console.WriteLine("El numero es impar");
            }

            Console.ReadKey();
        }
    }
}
