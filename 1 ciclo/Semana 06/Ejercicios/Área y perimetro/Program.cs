namespace Área_y_perimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio, perimetro, area;

            Console.Write("Ingrese el radio del círculo: ");
            radio = double.Parse(Console.ReadLine());

            perimetro = 2 * Math.PI * radio;
            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El área es de: " + area);
            Console.WriteLine("El perímetro es de: " + perimetro);
        }
    }
}
