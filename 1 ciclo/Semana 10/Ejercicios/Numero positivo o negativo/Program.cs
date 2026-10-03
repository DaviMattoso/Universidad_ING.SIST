namespace Numero_positivo_o_negativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine("Ingrese un numero");
            Numero = int.Parse(Console.ReadLine());

            if (Numero >= 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }

            Console.ReadKey();
        }
    }
}
