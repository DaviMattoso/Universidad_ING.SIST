namespace Número_dentro_de_un_rango
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Num;

            Console.WriteLine("Ingrese un numero");
            Num = double.Parse(Console.ReadLine());

            if (Num >= 10 && Num <= 50)
            {
                Console.WriteLine("El numero esta dentro del rango de 10 y 50");
            }
            else
            {
                Console.WriteLine("El numero esta fuera del rango de 10 y 50");
            }

            // podriamos hacer que el programa dijera si esta antes del 10 o despues del 50, pero utilizando condicionales anilladas

            Console.ReadKey();
        }
    }
}
