namespace Volumen_del_Cilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio, altura, volumen;

            Console.Write("Ingrese radio: ");
            radio = double.Parse(Console.ReadLine());

            Console.Write("Ingrese altura: ");
            altura = double.Parse(Console.ReadLine());

            volumen = Math.PI * Math.Pow(radio, 2) * altura;

            Console.WriteLine("Volumen del cilindro: " + volumen);
        }
    }
}
