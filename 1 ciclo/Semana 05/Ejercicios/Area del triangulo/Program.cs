using System;

class Program
{
    static void Main(string[] args)
    {
        double basetriangulo, altura, area;

        Console.WriteLine("Ingrese la base del triangulo:");
        basetriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triangulo:");
        altura = double.Parse(Console.ReadLine());

        area = (basetriangulo * altura);

        Console.WriteLine($"La area del triangulo es de: `{area}");

    }
}
