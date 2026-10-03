namespace Cuadrado_do_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Ingrese un número: ");
            numero = double.Parse(Console.ReadLine());

            Console.WriteLine("Cuadrado: " + Math.Pow(numero, 2)); //Math.Pow(numero, x) es el "simbolo" de potencia
            Console.WriteLine("Cubo: " + Math.Pow(numero, 3)); //Math.Pow(numero, x) es el "simbolo" de potencia
        }
    }
}
