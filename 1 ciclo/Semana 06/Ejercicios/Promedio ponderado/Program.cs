namespace Promedio_ponderado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, peso1, peso2, peso3, promediop;

            Console.Write("Ingrese la primera nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el peso de la primera nota: ");
            peso1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el peso de la segunda nota: ");
            peso2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el peso de la tercera nota: ");
            peso3 = double.Parse(Console.ReadLine());

            promediop = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / (peso1 + peso2 + peso3);

            Console.WriteLine("El promedio ponderado es de: " + promediop);
        }
    }
}
