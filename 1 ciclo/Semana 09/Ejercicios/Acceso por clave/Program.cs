namespace Acceso_por_clave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contraseñacorrecta, conraseñaingresada;

            contraseñacorrecta = "abcd123"; //Toda definición de string tiene que seguir con comillas

            Console.WriteLine("Ingrese la contraseña:");
            conraseñaingresada = Console.ReadLine();

            if (contraseñacorrecta == conraseñaingresada)
            {
                Console.WriteLine("La contraseña esta correcta");
            }
        }
    }
}
