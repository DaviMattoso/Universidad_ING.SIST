namespace Mayor_edad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Ingrese la edad:");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18) 
            {
                Console.WriteLine("Eres mayor de edad");
            }
        }
    }
}
