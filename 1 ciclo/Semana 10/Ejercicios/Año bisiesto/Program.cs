namespace Año_bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;

            Console.Write("Ingrese un año: ");
            año = int.Parse(Console.ReadLine());

            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            // año % 4 -> que la resta de la division del año por 4 sea 0
            // && -> Y (OTRA CONDICION QUE SE TIENE QUE CUMPLIR JUNTO CON LA PRIMERA
            // año % 100 != 0 -> la resta de la division del año por 100 NO PUEDE SER 0 (! ES NOT)
            // || -> al menos UNA DE LAS CONDICIONES TIENE QUE SER VERDADERA 
            // año % 400 == 0 -> la resta del año por 400 TIENE QUE SER 0
            {
                Console.WriteLine("El año" +año "es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año " +año "no es bisiesto.");
            }

            Console.ReadKey();
        }
    }
}
