namespace Descuento_por_compra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Valor, ValorDesc;

            Console.WriteLine("Ingrese el valor de la compra");
            Valor = double.Parse(Console.ReadLine());

            if (Valor >= 100)
            {
                Console.WriteLine("El valor es de 100 soles o mas, por eso se aplica un valor de 10%");
                ValorDesc = Valor - (Valor * 0.10); // 0.10 = 10% (valor - 10%)
                Console.WriteLine("El valor final de la compra es de: " + ValorDesc);
            }
            else
            {
                Console.WriteLine("El valor es menor que 100 soles, no aplica descuento");
            }
        }
    }
}
