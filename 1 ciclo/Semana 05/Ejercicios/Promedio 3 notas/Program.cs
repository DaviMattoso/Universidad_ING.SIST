namespace Promedio_3_notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, promedio;

            Console.WriteLine("Ingrese la nota 1:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2:");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 3:");
            nota3 = double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"El promedio es de {promedio}");
        }
    }
}
