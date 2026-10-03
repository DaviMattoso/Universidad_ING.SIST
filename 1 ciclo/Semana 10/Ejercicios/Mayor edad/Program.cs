namespace Mayor_edad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Ingrese la edad de la persona");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Esta persona es de mayor edad");
            }
            else
            {
                Console.WriteLine("Esta persona es de menor edad");
            }

            Console.ReadKey();
        }
    }
}
