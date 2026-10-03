namespace Suma_de_dos_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, suma;

            Console.Write("Ingrese el primer número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            suma = numero1 + numero2;

            Console.WriteLine("La suma de los dos números es: " + suma);
        }
    }
}
