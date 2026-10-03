namespace Datos_correctos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = "davi";
            string contraseña = "1234";
            string ingUsuario, ingContraseña;

            
            Console.Write("Ingrese el usuario: ");
            ingUsuario = Console.ReadLine();

            Console.Write("Ingrese la contraseña: ");
            ingContraseña = Console.ReadLine();
            
            if (usuario == ingUsuario && contraseña == ingContraseña)
            {
                Console.WriteLine("Bienvenido al sistema.");
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrectos.");
            }

            Console.ReadKey();
        }
    }
}
