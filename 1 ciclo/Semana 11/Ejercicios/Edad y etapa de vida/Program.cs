namespace Edad_y_etapa_de_vida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                if (edad >= 60)
                {
                    Console.WriteLine("Eres un adulto mayor");
                }
                else
                {
                    Console.WriteLine("Eres un adulto");
                }
                    
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }

        }
    }
}
