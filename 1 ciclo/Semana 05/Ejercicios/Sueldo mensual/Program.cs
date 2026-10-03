using System;

class Program
{
    static void Main(string[] args)
    {
        double Horastrabajadas, ValorporHora, SueldoTotal;

        Console.WriteLine("Ingresa las horas trabajadas:");
        Horastrabajadas = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el valor que se gana por horas trabajadas:");
        ValorporHora = double.Parse(Console.ReadLine());

        SueldoTotal = Horastrabajadas * ValorporHora;

        Console.WriteLine($"El sueldo total a recibir es de: {SueldoTotal}");
        { }
    }
}
