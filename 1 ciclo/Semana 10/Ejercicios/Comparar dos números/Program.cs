namespace Comparar_dos_números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Num1, Num2;

            Console.WriteLine("Ingrese el primer numero");
            Num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segun numero");
            Num2 = double.Parse(Console.ReadLine());

            if (Num1 > Num2)
            {
                Console.WriteLine(Num1 + " es mayor que " + Num2);
            }
            else
            {
                Console.WriteLine(Num1 + " es menor que " + Num2);
            }

            Console.ReadKey();
        }
    }
}
