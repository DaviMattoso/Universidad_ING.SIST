namespace Nota_de_aprobación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota;

            Console.WriteLine("Ingrese la nota");
            Nota = double.Parse(Console.ReadLine());

            if (Nota >= 12)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Desaprobado");
            }

            Console.ReadKey();
        }
    }
}
