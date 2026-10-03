namespace División_por_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Ingrese un numero:");
            num = double.Parse(Console.ReadLine());

            if (num % 5 == 0)  ////Si el ersto de la divisiondeun numero entre 5 es 0, entonces...
            {
                Console.WriteLine("El numero es divisible por 5");
            }
        }
    }
}
