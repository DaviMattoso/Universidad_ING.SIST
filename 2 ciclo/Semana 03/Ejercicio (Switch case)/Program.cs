using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("         SISTEMA ACADÉMICO UPN");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.WriteLine("1. Programación I");
            Console.WriteLine("2. Matemática");
            Console.WriteLine("3. Base de Datos");
            Console.WriteLine("4. Redes");
            Console.WriteLine("5. Ingeniería de Software");
            Console.WriteLine("0. Salir");

            Console.WriteLine();
            Console.Write("Seleccione una asignatura: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            // ESTRUCTURA CONDICIONAL MÚLTIPLE

            switch (opcion)
            {
                case 1:

                    Console.WriteLine("PROGRAMACIÓN I");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Créditos: 4");
                    Console.WriteLine("Modalidad: Presencial");
                    Console.WriteLine(
                        "Descripción: Fundamentos de programación y C#."
                    );

                    MenuCurso("Programación I");

                    break;


                case 2:

                    Console.WriteLine("MATEMÁTICA");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Créditos: 4");
                    Console.WriteLine("Modalidad: Presencial");
                    Console.WriteLine(
                        "Descripción: Desarrollo del razonamiento matemático."
                    );

                    MenuCurso("Matemática");

                    break;


                case 3:

                    Console.WriteLine("BASE DE DATOS");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Créditos: 3");
                    Console.WriteLine("Modalidad: Virtual");
                    Console.WriteLine(
                        "Descripción: Diseño y gestión de bases de datos."
                    );

                    MenuCurso("Base de Datos");

                    break;


                case 4:

                    Console.WriteLine("REDES");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Créditos: 3");
                    Console.WriteLine("Modalidad: Presencial");
                    Console.WriteLine(
                        "Descripción: Fundamentos de redes y comunicación."
                    );

                    MenuCurso("Redes");

                    break;


                case 5:

                    Console.WriteLine("INGENIERÍA DE SOFTWARE");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Créditos: 4");
                    Console.WriteLine("Modalidad: Híbrida");
                    Console.WriteLine(
                        "Descripción: Diseño y desarrollo de sistemas."
                    );

                    MenuCurso("Ingeniería de Software");

                    break;


                case 0:

                    Console.WriteLine("Cerrando el sistema...");
                    Console.WriteLine("Hasta pronto.");

                    break;


                default:

                    Console.WriteLine(
                        "La opción seleccionada no existe."
                    );

                    break;
            }


            if (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Presione una tecla para regresar al menú principal..."
                );

                Console.ReadKey();
            }

        } while (opcion != 0);
    }


    // =========================================================
    // SEGUNDO MENÚ
    // OTRO SWITCH
    // =========================================================

    static void MenuCurso(string curso)
    {
        Console.WriteLine();
        Console.WriteLine("==============================");
        Console.WriteLine($"        MENÚ DE {curso}");
        Console.WriteLine("==============================");

        Console.WriteLine();

        Console.WriteLine("1. Ver información");
        Console.WriteLine("2. Ver número de créditos");
        Console.WriteLine("3. Simular matrícula");
        Console.WriteLine("4. Regresar");

        Console.WriteLine();
        Console.Write("Seleccione una opción: ");

        int opcionCurso =
            Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();


        switch (opcionCurso)
        {
            case 1:

                Console.WriteLine(
                    $"Ha seleccionado información de {curso}."
                );

                break;


            case 2:

                Console.WriteLine(
                    $"Consultando créditos de {curso}..."
                );

                break;


            case 3:

                Console.WriteLine(
                    $"Iniciando matrícula para {curso}..."
                );

                Console.WriteLine(
                    "Matrícula simulada correctamente."
                );

                break;


            case 4:

                Console.WriteLine(
                    "Regresando al menú principal..."
                );

                break;


            default:

                Console.WriteLine(
                    "Opción del curso no válida."
                );

                break;
        }
    }
}