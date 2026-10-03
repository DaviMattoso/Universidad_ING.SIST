namespace Soles_a_dolares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soles, tipo_cambio, dolares;

            Console.Write("Ingrese cantidad en soles: ");
            soles = double.Parse(Console.ReadLine());

            Console.Write("Ingrese tipo de cambio (soles por dólar): ");
            tipo_cambio = double.Parse(Console.ReadLine());

            if (tipo_cambio == 0) //ningun numero puede ser divisible por 0
            {
                Console.WriteLine("Error: El tipo de cambio no puede ser cero.");
                return;
            }

            dolares = soles / tipo_cambio;

            Console.WriteLine(soles + " soles son " + dolares + " dólares.");
        }
    }
}
