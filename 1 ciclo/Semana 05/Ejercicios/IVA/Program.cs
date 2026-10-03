namespace IVA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal costo, costofinal;
            decimal IVA;
            IVA = 0.18M; //0.18 = 18%

            Console.WriteLine("Ingrese el precio total de la compra: ");
            costo = decimal.Parse(Console.ReadLine());

            costofinal = costo + (costo * IVA);

            Console.WriteLine($"El costo final del producto es de {costofinal}");
        }
    }
}
