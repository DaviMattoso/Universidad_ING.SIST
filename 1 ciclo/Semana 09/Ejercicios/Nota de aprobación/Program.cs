namespace Nota_de_aprobación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota;

            Console.WriteLine("Ingrese la nota (hasta maximo 20)");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 11)
            {
                Console.WriteLine("Aprobado");
            }
        }
    }
}
