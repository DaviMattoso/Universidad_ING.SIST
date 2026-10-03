namespace Celsius_a_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Celcius, Fahrenheit;
            Console.WriteLine("Ingrese la temperatura en grados Celcius:");
            Celcius = double.Parse(Console.ReadLine());

            Fahrenheit = Celcius * 1.8 + 32;

            Console.WriteLine($"La temperatura en Fahrenheit es de: {Fahrenheit}");
        }
    }
}
