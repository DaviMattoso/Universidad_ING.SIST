using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("==============================================");
            Console.WriteLine("     PRÁCTICA - CONDICIONAL MÚLTIPLE");
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("1. Día de la semana");
            Console.WriteLine("2. Operaciones matemáticas");
            Console.WriteLine("3. Mes del año");
            Console.WriteLine("4. Clasificación de notas");
            Console.WriteLine("5. Calculadora de áreas");
            Console.WriteLine("6. Tipo de usuario");
            Console.WriteLine("7. Conversor de unidades");
            Console.WriteLine("8. Tienda");
            Console.WriteLine("9. Sistema de transporte");
            Console.WriteLine("10. Cajero automático");
            Console.WriteLine("0. Salir");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Ejercicio1();
                    break;

                case 2:
                    Ejercicio2();
                    break;

                case 3:
                    Ejercicio3();
                    break;

                case 4:
                    Ejercicio4();
                    break;

                case 5:
                    Ejercicio5();
                    break;

                case 6:
                    Ejercicio6();
                    break;

                case 7:
                    Ejercicio7();
                    break;

                case 8:
                    Ejercicio8();
                    break;

                case 9:
                    Ejercicio9();
                    break;

                case 10:
                    Ejercicio10();
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para volver al menú...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }


    // =========================================================
    // EJERCICIO 1
    // DÍA DE LA SEMANA
    // =========================================================

    static void Ejercicio1()
    {
        Console.WriteLine("EJERCICIO 1 - DÍA DE LA SEMANA");
        Console.WriteLine();

        Console.Write("Ingrese un número del 1 al 7: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;

            case 2:
                Console.WriteLine("Martes");
                break;

            case 3:
                Console.WriteLine("Miércoles");
                break;

            case 4:
                Console.WriteLine("Jueves");
                break;

            case 5:
                Console.WriteLine("Viernes");
                break;

            case 6:
                Console.WriteLine("Sábado");
                break;

            case 7:
                Console.WriteLine("Domingo");
                break;

            default:
                Console.WriteLine("Día no válido.");
                break;
        }
    }


    // =========================================================
    // EJERCICIO 2
    // OPERACIONES MATEMÁTICAS
    // =========================================================

    static void Ejercicio2()
    {
        Console.WriteLine("EJERCICIO 2 - OPERACIONES MATEMÁTICAS");
        Console.WriteLine();

        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");

        Console.WriteLine();
        Console.Write("Seleccione una operación: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Resultado: {numero1 + numero2}");
                break;

            case 2:
                Console.WriteLine($"Resultado: {numero1 - numero2}");
                break;

            case 3:
                Console.WriteLine($"Resultado: {numero1 * numero2}");
                break;

            case 4:

                if (numero2 != 0)
                {
                    Console.WriteLine($"Resultado: {numero1 / numero2}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                }

                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }


    // =========================================================
    // EJERCICIO 3
    // MES DEL AÑO
    // =========================================================

    static void Ejercicio3()
    {
        Console.WriteLine("EJERCICIO 3 - MES DEL AÑO");
        Console.WriteLine();

        Console.Write("Ingrese un número del 1 al 12: ");
        int mes = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("Enero");
                break;

            case 2:
                Console.WriteLine("Febrero");
                break;

            case 3:
                Console.WriteLine("Marzo");
                break;

            case 4:
                Console.WriteLine("Abril");
                break;

            case 5:
                Console.WriteLine("Mayo");
                break;

            case 6:
                Console.WriteLine("Junio");
                break;

            case 7:
                Console.WriteLine("Julio");
                break;

            case 8:
                Console.WriteLine("Agosto");
                break;

            case 9:
                Console.WriteLine("Septiembre");
                break;

            case 10:
                Console.WriteLine("Octubre");
                break;

            case 11:
                Console.WriteLine("Noviembre");
                break;

            case 12:
                Console.WriteLine("Diciembre");
                break;

            default:
                Console.WriteLine("Mes no válido.");
                break;
        }
    }


    // =========================================================
    // EJERCICIO 4
    // CLASIFICACIÓN DE NOTAS
    // =========================================================

    static void Ejercicio4()
    {
        Console.WriteLine("EJERCICIO 4 - CLASIFICACIÓN DE NOTAS");
        Console.WriteLine();

        Console.Write("Ingrese una calificación (A, B, C, D o F): ");

        string nota = Console.ReadLine().ToUpper();

        switch (nota)
        {
            case "A":
                Console.WriteLine("Excelente");
                break;

            case "B":
                Console.WriteLine("Muy bueno");
                break;

            case "C":
                Console.WriteLine("Bueno");
                break;

            case "D":
                Console.WriteLine("Debe mejorar");
                break;

            case "F":
                Console.WriteLine("Reprobado");
                break;

            default:
                Console.WriteLine("Calificación no reconocida.");
                break;
        }
    }


    // =========================================================
    // EJERCICIO 5
    // CALCULADORA DE ÁREAS
    // =========================================================

    static void Ejercicio5()
    {
        Console.WriteLine("EJERCICIO 5 - CALCULADORA DE ÁREAS");
        Console.WriteLine();

        Console.WriteLine("1. Cuadrado");
        Console.WriteLine("2. Rectángulo");
        Console.WriteLine("3. Triángulo");
        Console.WriteLine("4. Círculo");

        Console.WriteLine();
        Console.Write("Seleccione una figura: ");

        int opcion = Convert.ToInt32(Console.ReadLine());

        double area;

        switch (opcion)
        {
            case 1:

                Console.Write("Ingrese el lado: ");
                double lado = Convert.ToDouble(Console.ReadLine());

                area = lado * lado;

                Console.WriteLine($"Área del cuadrado: {area}");

                break;


            case 2:

                Console.Write("Ingrese la base: ");
                double baseRectangulo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la altura: ");
                double alturaRectangulo = Convert.ToDouble(Console.ReadLine());

                area = baseRectangulo * alturaRectangulo;

                Console.WriteLine($"Área del rectángulo: {area}");

                break;


            case 3:

                Console.Write("Ingrese la base: ");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la altura: ");
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

                area = (baseTriangulo * alturaTriangulo) / 2;

                Console.WriteLine($"Área del triángulo: {area}");

                break;


            case 4:

                Console.Write("Ingrese el radio: ");
                double radio = Convert.ToDouble(Console.ReadLine());

                area = Math.PI * radio * radio;

                Console.WriteLine($"Área del círculo: {area:F2}");

                break;


            default:

                Console.WriteLine("Opción no válida.");

                break;
        }
    }


    // =========================================================
    // EJERCICIO 6
    // TIPO DE USUARIO
    // =========================================================

    static void Ejercicio6()
    {
        Console.WriteLine("EJERCICIO 6 - TIPO DE USUARIO");
        Console.WriteLine();

        Console.WriteLine("1. Administrador");
        Console.WriteLine("2. Empleado");
        Console.WriteLine("3. Cliente");
        Console.WriteLine("4. Invitado");

        Console.WriteLine();
        Console.Write("Seleccione un tipo de usuario: ");

        int usuario = Convert.ToInt32(Console.ReadLine());

        switch (usuario)
        {
            case 1:

                Console.WriteLine();
                Console.WriteLine("ROL: Administrador");
                Console.WriteLine("Permisos:");
                Console.WriteLine("- Gestionar usuarios");
                Console.WriteLine("- Gestionar productos");
                Console.WriteLine("- Consultar información");
                Console.WriteLine("- Modificar información");

                break;


            case 2:

                Console.WriteLine();
                Console.WriteLine("ROL: Empleado");
                Console.WriteLine("Permisos:");
                Console.WriteLine("- Gestionar productos");
                Console.WriteLine("- Registrar ventas");
                Console.WriteLine("- Consultar información");

                break;


            case 3:

                Console.WriteLine();
                Console.WriteLine("ROL: Cliente");
                Console.WriteLine("Permisos:");
                Console.WriteLine("- Consultar productos");
                Console.WriteLine("- Realizar compras");
                Console.WriteLine("- Consultar sus pedidos");

                break;


            case 4:

                Console.WriteLine();
                Console.WriteLine("ROL: Invitado");
                Console.WriteLine("Permisos:");
                Console.WriteLine("- Consultar información");

                break;


            default:

                Console.WriteLine("Tipo de usuario no válido.");

                break;
        }
    }


    // =========================================================
    // EJERCICIO 7
    // CONVERSOR DE UNIDADES
    // =========================================================

    static void Ejercicio7()
    {
        Console.WriteLine("EJERCICIO 7 - CONVERSOR DE UNIDADES");
        Console.WriteLine();

        Console.WriteLine("1. Kilómetros a metros");
        Console.WriteLine("2. Metros a centímetros");
        Console.WriteLine("3. Kilogramos a gramos");
        Console.WriteLine("4. Horas a minutos");

        Console.WriteLine();
        Console.Write("Seleccione una conversión: ");

        int opcion = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el valor: ");

        double valor = Convert.ToDouble(Console.ReadLine());

        switch (opcion)
        {
            case 1:

                Console.WriteLine(
                    $"{valor} kilómetros = {valor * 1000} metros"
                );

                break;


            case 2:

                Console.WriteLine(
                    $"{valor} metros = {valor * 100} centímetros"
                );

                break;


            case 3:

                Console.WriteLine(
                    $"{valor} kilogramos = {valor * 1000} gramos"
                );

                break;


            case 4:

                Console.WriteLine(
                    $"{valor} horas = {valor * 60} minutos"
                );

                break;


            default:

                Console.WriteLine("Opción no válida.");

                break;
        }
    }


    // =========================================================
    // EJERCICIO 8
    // TIENDA
    // =========================================================

    static void Ejercicio8()
    {
        Console.WriteLine("EJERCICIO 8 - TIENDA");
        Console.WriteLine();

        Console.WriteLine("1. Laptop      - S/ 2500");
        Console.WriteLine("2. Teclado     - S/ 120");
        Console.WriteLine("3. Mouse       - S/ 60");
        Console.WriteLine("4. Monitor     - S/ 800");
        Console.WriteLine("5. Audífonos   - S/ 150");

        Console.WriteLine();
        Console.Write("Seleccione un producto: ");

        int producto = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cantidad: ");

        int cantidad = Convert.ToInt32(Console.ReadLine());

        string nombre = "";
        double precio = 0;

        switch (producto)
        {
            case 1:

                nombre = "Laptop";
                precio = 2500;

                break;


            case 2:

                nombre = "Teclado";
                precio = 120;

                break;


            case 3:

                nombre = "Mouse";
                precio = 60;

                break;


            case 4:

                nombre = "Monitor";
                precio = 800;

                break;


            case 5:

                nombre = "Audífonos";
                precio = 150;

                break;


            default:

                Console.WriteLine("Producto no válido.");

                break;
        }


        if (precio != 0)
        {
            double total = precio * cantidad;

            Console.WriteLine();
            Console.WriteLine("----- RESUMEN DE COMPRA -----");
            Console.WriteLine($"Producto: {nombre}");
            Console.WriteLine($"Precio unitario: S/ {precio}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Total: S/ {total}");
        }
    }


    // =========================================================
    // EJERCICIO 9
    // SISTEMA DE TRANSPORTE
    // =========================================================

    static void Ejercicio9()
    {
        Console.WriteLine("EJERCICIO 9 - SISTEMA DE TRANSPORTE");
        Console.WriteLine();

        Console.WriteLine("1. Bus");
        Console.WriteLine("2. Taxi");
        Console.WriteLine("3. Bicicleta");
        Console.WriteLine("4. Metro");
        Console.WriteLine("5. Caminando");

        Console.WriteLine();
        Console.Write("Seleccione un medio de transporte: ");

        int transporte = Convert.ToInt32(Console.ReadLine());

        switch (transporte)
        {
            case 1:

                Console.WriteLine();
                Console.WriteLine("Transporte: Bus");
                Console.WriteLine("Costo: Bajo");
                Console.WriteLine("Velocidad: Media");

                break;


            case 2:

                Console.WriteLine();
                Console.WriteLine("Transporte: Taxi");
                Console.WriteLine("Costo: Alto");
                Console.WriteLine("Velocidad: Alta");

                break;


            case 3:

                Console.WriteLine();
                Console.WriteLine("Transporte: Bicicleta");
                Console.WriteLine("Costo: Muy bajo");
                Console.WriteLine("Impacto ambiental: Muy bajo");

                break;


            case 4:

                Console.WriteLine();
                Console.WriteLine("Transporte: Metro");
                Console.WriteLine("Costo: Medio");
                Console.WriteLine("Velocidad: Alta");

                break;


            case 5:

                Console.WriteLine();
                Console.WriteLine("Transporte: Caminando");
                Console.WriteLine("Costo: Gratis");
                Console.WriteLine("Impacto ambiental: Ninguno");

                break;


            default:

                Console.WriteLine("Transporte no disponible.");

                break;
        }
    }


    // =========================================================
    // EJERCICIO 10
    // CAJERO AUTOMÁTICO
    // =========================================================

    static void Ejercicio10()
    {
        double saldo = 1000;

        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("         CAJERO AUTOMÁTICO");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Datos de la cuenta");
            Console.WriteLine("5. Salir");

            Console.WriteLine();
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (opcion)
            {
                case 1:

                    Console.WriteLine($"Saldo actual: S/ {saldo:F2}");

                    break;


                case 2:

                    Console.Write("Ingrese el monto a depositar: S/ ");

                    double deposito =
                        Convert.ToDouble(Console.ReadLine());

                    if (deposito > 0)
                    {
                        saldo = saldo + deposito;

                        Console.WriteLine("Depósito realizado correctamente.");
                        Console.WriteLine($"Nuevo saldo: S/ {saldo:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Monto no válido.");
                    }

                    break;


                case 3:

                    Console.Write("Ingrese el monto a retirar: S/ ");

                    double retiro =
                        Convert.ToDouble(Console.ReadLine());

                    if (retiro <= 0)
                    {
                        Console.WriteLine("Monto no válido.");
                    }
                    else if (retiro <= saldo)
                    {
                        saldo = saldo - retiro;

                        Console.WriteLine("Retiro realizado correctamente.");
                        Console.WriteLine($"Saldo restante: S/ {saldo:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente.");
                    }

                    break;


                case 4:

                    Console.WriteLine("----- DATOS DE LA CUENTA -----");
                    Console.WriteLine("Banco: Banco Universitario");
                    Console.WriteLine("Tipo: Cuenta de ahorros");
                    Console.WriteLine($"Saldo: S/ {saldo:F2}");

                    break;


                case 5:

                    Console.WriteLine("Saliendo del cajero...");

                    break;


                default:

                    Console.WriteLine("Opción no válida.");

                    break;
            }


            if (opcion != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 5);
    }
}