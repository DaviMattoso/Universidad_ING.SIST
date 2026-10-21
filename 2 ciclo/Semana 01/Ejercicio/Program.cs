using System;

class Program
{
    static void Main()
    {
        // =====================================================
        // VARIABLES PRINCIPALES
        // =====================================================

        string nombre = "";
        int edad = 0;
        int ciclo = 0;

        double nota1 = 0;
        double nota2 = 0;
        double nota3 = 0;
        double promedio = 0;

        double asistencia = 0;

        string tipoEstudiante = "";
        bool estudianteRegistrado = false;

        int opcion;


        // =====================================================
        // MENÚ PRINCIPAL
        // ESTRUCTURA CONDICIONAL MÚLTIPLE
        // =====================================================

        do
        {
            Console.Clear();

            Console.WriteLine("===========================================");
            Console.WriteLine("          SISTEMA ACADÉMICO UPN");
            Console.WriteLine("===========================================");
            Console.WriteLine();

            Console.WriteLine("1. Registrar estudiante");
            Console.WriteLine("2. Calcular promedio");
            Console.WriteLine("3. Consultar situación académica");
            Console.WriteLine("4. Clasificar rendimiento");
            Console.WriteLine("5. Evaluar beneficio académico");
            Console.WriteLine("6. Simular pago de matrícula");
            Console.WriteLine("7. Mostrar resumen del estudiante");
            Console.WriteLine("0. Salir");

            Console.WriteLine();
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            switch (opcion)
            {

                // =====================================================
                // OPCIÓN 1
                // ENTRADA DE DATOS + VARIABLES
                // =====================================================

                case 1:

                    Console.WriteLine("===========================================");
                    Console.WriteLine("        REGISTRO DEL ESTUDIANTE");
                    Console.WriteLine("===========================================");
                    Console.WriteLine();

                    Console.Write("Nombre del estudiante: ");
                    nombre = Console.ReadLine();

                    Console.Write("Edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ciclo actual: ");
                    ciclo = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine();
                    Console.WriteLine("Tipo de estudiante:");
                    Console.WriteLine("1. Regular");
                    Console.WriteLine("2. Becado");
                    Console.WriteLine("3. Convenio");

                    Console.WriteLine();
                    Console.Write("Seleccione: ");

                    int tipo = Convert.ToInt32(Console.ReadLine());


                    // SWITCH DENTRO DEL SISTEMA

                    switch (tipo)
                    {
                        case 1:
                            tipoEstudiante = "Regular";
                            break;

                        case 2:
                            tipoEstudiante = "Becado";
                            break;

                        case 3:
                            tipoEstudiante = "Convenio";
                            break;

                        default:
                            tipoEstudiante = "No definido";
                            break;
                    }


                    Console.WriteLine();
                    Console.WriteLine("Ingrese las tres notas (0 - 20).");

                    Console.Write("Nota 1: ");
                    nota1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nota 2: ");
                    nota2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nota 3: ");
                    nota3 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Porcentaje de asistencia: ");
                    asistencia = Convert.ToDouble(Console.ReadLine());


                    estudianteRegistrado = true;


                    Console.WriteLine();
                    Console.WriteLine("Estudiante registrado correctamente.");

                    break;



                // =====================================================
                // OPCIÓN 2
                // OPERADORES ARITMÉTICOS
                // =====================================================

                case 2:

                    Console.WriteLine("===========================================");
                    Console.WriteLine("            CÁLCULO DE PROMEDIO");
                    Console.WriteLine("===========================================");
                    Console.WriteLine();


                    if (estudianteRegistrado)
                    {
                        promedio = (nota1 + nota2 + nota3) / 3;


                        Console.WriteLine($"Nota 1: {nota1}");
                        Console.WriteLine($"Nota 2: {nota2}");
                        Console.WriteLine($"Nota 3: {nota3}");

                        Console.WriteLine();

                        Console.WriteLine($"Promedio: {promedio:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Primero debe registrar un estudiante.");
                    }

                    break;



                // =====================================================
                // OPCIÓN 3
                // CONDICIONAL SIMPLE + DOBLE + OPERADORES LÓGICOS
                // =====================================================

                case 3:

                    Console.WriteLine("===========================================");
                    Console.WriteLine("          SITUACIÓN ACADÉMICA");
                    Console.WriteLine("===========================================");
                    Console.WriteLine();


                    if (estudianteRegistrado)
                    {
                        promedio = (nota1 + nota2 + nota3) / 3;


                        // OPERADOR LÓGICO &&
                        // Ambas condiciones deben cumplirse

                        if (promedio >= 11 && asistencia >= 70)
                        {
                            Console.WriteLine("Estado: APROBADO");
                        }
                        else
                        {
                            Console.WriteLine("Estado: REPROBADO");
                        }


                        Console.WriteLine();


                        // CONDICIONAL SIMPLE

                        if (asistencia < 70)
                        {
                            Console.WriteLine(
                                "Observación: asistencia insuficiente."
                            );
                        }


                        if (promedio < 11)
                        {
                            Console.WriteLine(
                                "Observación: promedio insuficiente."
                            );
                        }
                    }
                    else
                    {
                        Console.WriteLine("Primero debe registrar un estudiante.");
                    }

                    break;



                // =====================================================
                // OPCIÓN 4
                // ESTRUCTURA CONDICIONAL ANIDADA
                // =====================================================

                case 4:

                    Console.WriteLine("===========================================");
                    Console.WriteLine("       CLASIFICACIÓN DEL RENDIMIENTO");
                    Console.WriteLine("===========================================");
                    Console.WriteLine();


                    if (estudianteRegistrado)
                    {
                        promedio = (nota1 + nota2 + nota3) / 3;


                        if (promedio >= 11)
                        {

                            if (promedio >= 18)
                            {
                                Console.WriteLine(
                                    "Rendimiento: EXCELENTE"
                                );
                            }
                            else
                            {

                                if (promedio >= 15)
                                {
                                    Console.WriteLine(
                                        "Rendimiento: MUY BUENO"
                                    );
                                }
                                else
                                {

                                    if (promedio >= 13)
                                    {
                                        Console.WriteLine(
                                            "Rendimiento: BUENO"
                                        );
                                    }
                                    else
                                    {
                                        Console.WriteLine(
                                            "Rendimiento: APROBADO"
                                        );
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(
                                "Rendimiento: REPROBADO"
                            );
                        }


                        Console.WriteLine(
                            $"Promedio obtenido: {promedio:F2}"
                        );
                    }
                    else
                    {
                        Console.WriteLine(
                            "Primero debe registrar un estudiante."
                        );
                    }

                    break;



                // =====================================================
                // OPCIÓN 5
                // CONDICIONES ANIDADAS + && + ||
                // =====================================================

                case 5:

                    Console.WriteLine("===========================================");
                    Console.WriteLine("        BENEFICIO ACADÉMICO");
                    Console.WriteLine("===========================================");
                    Console.WriteLine();


                    if (estudianteRegistrado)
                    {
                        promedio = (nota1 + nota2 + nota3) / 3;


                        if (promedio >= 18 && asistencia >= 90)
                        {
                            Console.WriteLine(
                                "Beneficio: Beca académica del 50%"
                            );
                        }
                        else
                        {

                            if (promedio >= 16 && asistencia >= 80)
                            {
                                Console.WriteLine(
                                    "Beneficio: Descuento académico del 25%"
                                );
                            }
                            else
                            {

                                // EJEMPLO DEL OPERADOR OR

                                if (tipoEstudiante == "Becado" ||
                                    tipoEstudiante == "Convenio")
                                {
                                    Console.WriteLine(
                                        "Beneficio según modalidad del estudiante."
                                    );
                                }
                                else
                                {
                                    Console.WriteLine(
                                        "No posee beneficios académicos."
                                    );
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(
                            "Primero debe registrar un estudiante."
                        );
                    }

                    break;



                // =====================================================
                // OPCIÓN 6
                // OPERACIONES + SWITCH + CONDICIONES
                // =====================================================

                case 6:

                    Console.WriteLine("===========================================");
                    Console.WriteLine("       SIMULADOR DE MATRÍCULA");
                    Console.WriteLine("===========================================");
                    Console.WriteLine();


                    if (estudianteRegistrado)
                    {
                        double matricula = 1000;
                        double descuento = 0;


                        promedio = (nota1 + nota2 + nota3) / 3;


                        // DESCUENTO SEGÚN TIPO

                        switch (tipoEstudiante)
                        {
                            case "Regular":

                                descuento = 0;

                                break;


                            case "Becado":

                                descuento = 0.50;

                                break;


                            case "Convenio":

                                descuento = 0.20;

                                break;
                        }


                        // BENEFICIO POR EXCELENCIA

                        if (promedio >= 18 && asistencia >= 90)
                        {
                            descuento = 0.50;
                        }


                        double montoDescuento =
                            matricula * descuento;

                        double total =
                            matricula - montoDescuento;


                        Console.WriteLine(
                            $"Matrícula original: S/ {matricula:F2}"
                        );

                        Console.WriteLine(
                            $"Descuento: {descuento * 100}%"
                        );

                        Console.WriteLine(
                            $"Monto descontado: S/ {montoDescuento:F2}"
                        );

                        Console.WriteLine();

                        Console.WriteLine(
                            $"TOTAL A PAGAR: S/ {total:F2}"
                        );
                    }
                    else
                    {
                        Console.WriteLine(
                            "Primero debe registrar un estudiante."
                        );
                    }

                    break;



                // =====================================================
                // OPCIÓN 7
                // INTEGRACIÓN DE TODO EL SISTEMA
                // =====================================================

                case 7:

                    Console.WriteLine("===========================================");
                    Console.WriteLine("       RESUMEN DEL ESTUDIANTE");
                    Console.WriteLine("===========================================");
                    Console.WriteLine();


                    if (estudianteRegistrado)
                    {
                        promedio = (nota1 + nota2 + nota3) / 3;


                        Console.WriteLine($"Nombre: {nombre}");
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Ciclo: {ciclo}");
                        Console.WriteLine($"Tipo: {tipoEstudiante}");

                        Console.WriteLine();

                        Console.WriteLine($"Nota 1: {nota1}");
                        Console.WriteLine($"Nota 2: {nota2}");
                        Console.WriteLine($"Nota 3: {nota3}");

                        Console.WriteLine();

                        Console.WriteLine(
                            $"Promedio: {promedio:F2}"
                        );

                        Console.WriteLine(
                            $"Asistencia: {asistencia}%"
                        );


                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------");


                        // CONDICIÓN DOBLE

                        if (promedio >= 11 && asistencia >= 70)
                        {
                            Console.WriteLine(
                                "Situación: APROBADO"
                            );
                        }
                        else
                        {
                            Console.WriteLine(
                                "Situación: REPROBADO"
                            );
                        }


                        // CONDICIONES ANIDADAS

                        if (promedio >= 18)
                        {
                            Console.WriteLine(
                                "Rendimiento: Excelente"
                            );
                        }
                        else
                        {
                            if (promedio >= 15)
                            {
                                Console.WriteLine(
                                    "Rendimiento: Muy bueno"
                                );
                            }
                            else
                            {
                                if (promedio >= 13)
                                {
                                    Console.WriteLine(
                                        "Rendimiento: Bueno"
                                    );
                                }
                                else
                                {
                                    if (promedio >= 11)
                                    {
                                        Console.WriteLine(
                                            "Rendimiento: Aprobado"
                                        );
                                    }
                                    else
                                    {
                                        Console.WriteLine(
                                            "Rendimiento: Reprobado"
                                        );
                                    }
                                }
                            }
                        }


                        Console.WriteLine("-----------------------------------");
                    }
                    else
                    {
                        Console.WriteLine(
                            "No existe un estudiante registrado."
                        );
                    }

                    break;



                // =====================================================
                // SALIR
                // =====================================================

                case 0:

                    Console.WriteLine(
                        "Finalizando el Sistema Académico UPN..."
                    );

                    break;



                // =====================================================
                // OPCIÓN INCORRECTA
                // =====================================================

                default:

                    Console.WriteLine(
                        "La opción seleccionada no es válida."
                    );

                    break;
            }


            if (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Presione una tecla para volver al menú..."
                );

                Console.ReadKey();
            }

        } while (opcion != 0);
    }
}