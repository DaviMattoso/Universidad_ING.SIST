using System;

class Program
{
    static void Main()
    {
        int largo, ancho, area; // Definir variables como entero

        Console.WriteLine("Ingrese el largo del rectangulo"); // Ingresar la variable largo
        largo = int.Parse(Console.ReadLine()); // Leer la variablre largo

        Console.WriteLine("Ingrese el ancho del rectangulo"); //Ingresar la variable ancho
        ancho = int.Parse(Console.ReadLine()); // Leer la variable ancho

        area = largo * ancho; // Operación para calcular área

        Console.WriteLine($"El area del rectangulo es: {area}"); // Salida del resultado
    }
}
