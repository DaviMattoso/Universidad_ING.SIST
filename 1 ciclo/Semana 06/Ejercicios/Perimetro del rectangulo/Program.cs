namespace Perimetro_del_rectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double perimetro, baseRectangulo, altura;

            Console.Write("Ingrese la base del rectángulo: ");
            baseRectangulo = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del rectángulo: ");
            altura = double.Parse(Console.ReadLine());

            perimetro = 2 * (baseRectangulo + altura);

            Console.WriteLine("El perímetro del rectángulo es de: " + perimetro);
        }
    }
}
