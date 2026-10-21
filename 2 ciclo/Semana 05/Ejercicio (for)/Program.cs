using System;

class Program
{
    static void Main()
    {
        // ---------------------------------------------------------
        // VARIABLES PRINCIPALES
        // ---------------------------------------------------------

        // Guardará cuántos registros de minerales vamos a realizar.
        int cantidadMinerales;

        // Guardará la cantidad ingresada en cada repetición.
        int mineralEncontrado;

        // Acumulará todos los minerales encontrados.
        int totalMinerales = 0;


        Console.WriteLine("========================================");
        Console.WriteLine("       SISTEMA DE MINERÍA");
        Console.WriteLine("========================================");
        Console.WriteLine();

        Console.Write("¿Cuántos registros de minerales desea realizar?: ");
        cantidadMinerales = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();


        // =========================================================
        // ESTRUCTURA REPETITIVA PARA - FOR
        // =========================================================
        //
        // El FOR está dividido en 3 partes:
        //
        // for (VALOR INICIAL; CONDICIÓN; INCREMENTO)
        //
        // En este ejercicio:
        //
        // for (int i = 1; i <= cantidadMinerales; i++)
        //
        //             ↓              ↓                ↓
        //       VALOR INICIAL    CONDICIÓN       INCREMENTO
        //
        // =========================================================

        for (int i = 1; i <= cantidadMinerales; i++)
        {
            // -----------------------------------------------------
            // 1. VALOR INICIAL -> int i = 1
            // -----------------------------------------------------
            //
            // Creamos una variable llamada "i".
            //
            // Esta variable funciona como CONTADOR.
            //
            // Empieza con el valor 1 porque queremos que el
            // primer registro aparezca como:
            //
            // Mineral 1
            //
            // Después será:
            //
            // Mineral 2
            // Mineral 3
            // Mineral 4...
            //
            // Esta parte SOLO se ejecuta una vez:
            // cuando comienza el for.


            // -----------------------------------------------------
            // 2. CONDICIÓN -> i <= cantidadMinerales
            // -----------------------------------------------------
            //
            // Antes de realizar cada repetición, el programa
            // pregunta:
            //
            // ¿i sigue siendo menor o igual a cantidadMinerales?
            //
            // Ejemplo:
            //
            // cantidadMinerales = 3
            //
            // i = 1 -> 1 <= 3 -> TRUE  -> ejecuta
            // i = 2 -> 2 <= 3 -> TRUE  -> ejecuta
            // i = 3 -> 3 <= 3 -> TRUE  -> ejecuta
            // i = 4 -> 4 <= 3 -> FALSE -> termina el for
            //
            // Mientras la condición sea TRUE, el bloque se repite.


            Console.Write($"Ingrese la cantidad encontrada en el registro {i}: ");

            mineralEncontrado =
                Convert.ToInt32(Console.ReadLine());

            totalMinerales += mineralEncontrado;


            Console.WriteLine(
                $"Registro {i} completado correctamente."
            );

            Console.WriteLine();


            // -----------------------------------------------------
            // 3. INCREMENTO -> i++
            // -----------------------------------------------------
            //
            // Esta parte ocurre AUTOMÁTICAMENTE al terminar
            // todo el bloque del for.
            //
            // i++ significa:
            //
            // i = i + 1;
            //
            // Es decir, aumenta el contador en una unidad.
            //
            // Ejemplo:
            //
            // i = 1
            // i++  ->  i = 2
            //
            // siguiente repetición:
            //
            // i = 2
            // i++  ->  i = 3
            //
            // siguiente:
            //
            // i = 3
            // i++  ->  i = 4
            //
            // Cuando i ya no cumple la condición,
            // el for termina.
        }


        // =========================================================
        // RESULTADOS
        // =========================================================

        Console.WriteLine("========================================");
        Console.WriteLine("           RESULTADO FINAL");
        Console.WriteLine("========================================");

        Console.WriteLine();
        Console.WriteLine(
            $"Cantidad de registros: {cantidadMinerales}"
        );

        Console.WriteLine(
            $"Total de minerales encontrados: {totalMinerales}"
        );


        // Evitamos dividir entre cero.
        if (cantidadMinerales > 0)
        {
            double promedio =
                (double)totalMinerales / cantidadMinerales;

            Console.WriteLine(
                $"Promedio por registro: {promedio:F2}"
            );
        }
        else
        {
            Console.WriteLine(
                "No se realizaron registros."
            );
        }


        Console.WriteLine();
        Console.WriteLine("Fin de la expedición minera.");

        Console.ReadKey();
    }
}