using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("====================================================");
            Console.WriteLine("   SEMANA 14 - CONDICIONAL MULTIPLE Y ANIDADA");
            Console.WriteLine("====================================================");
            Console.WriteLine();

            Console.WriteLine("1. Clasificación de estudiante");
            Console.WriteLine("2. Sistema de acceso");
            Console.WriteLine("3. Cajero automático");
            Console.WriteLine("4. Tienda y descuentos");
            Console.WriteLine("5. Venta de entradas de cine");
            Console.WriteLine("6. Sistema de transporte");
            Console.WriteLine("7. Bonificación de empleados");
            Console.WriteLine("8. Restaurante");
            Console.WriteLine("9. Clasificación de jugador");
            Console.WriteLine("10. Sistema de usuarios");
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
    // CLASIFICACIÓN DE ESTUDIANTE
    // =========================================================

    static void Ejercicio1()
    {
        Console.WriteLine("EJERCICIO 1 - CLASIFICACIÓN DE ESTUDIANTE");
        Console.WriteLine();

        Console.Write("Ingrese la nota del estudiante (0 - 20): ");
        double nota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el porcentaje de asistencia: ");
        double asistencia = Convert.ToDouble(Console.ReadLine());

        if (nota >= 0 && nota <= 20)
        {
            if (asistencia >= 70)
            {
                if (nota >= 18)
                {
                    Console.WriteLine("Resultado: Excelente.");
                }
                else
                {
                    if (nota >= 14)
                    {
                        Console.WriteLine("Resultado: Aprobado.");
                    }
                    else
                    {
                        if (nota >= 11)
                        {
                            Console.WriteLine("Resultado: Aprobado con nota mínima.");
                        }
                        else
                        {
                            Console.WriteLine("Resultado: Reprobado por nota.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Resultado: Reprobado por falta de asistencia.");
            }
        }
        else
        {
            Console.WriteLine("La nota ingresada no es válida.");
        }
    }


    // =========================================================
    // EJERCICIO 2
    // SISTEMA DE ACCESO
    // =========================================================

    static void Ejercicio2()
    {
        Console.WriteLine("EJERCICIO 2 - SISTEMA DE ACCESO");
        Console.WriteLine();

        Console.WriteLine("Tipos de usuario:");
        Console.WriteLine("1. Administrador");
        Console.WriteLine("2. Profesor");
        Console.WriteLine("3. Estudiante");

        Console.WriteLine();
        Console.Write("Seleccione el tipo de usuario: ");
        int tipo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la contraseña: ");
        string contraseña = Console.ReadLine();

        switch (tipo)
        {
            case 1:

                if (contraseña == "admin123")
                {
                    Console.WriteLine("Acceso concedido.");
                    Console.WriteLine("Bienvenido, Administrador.");
                    Console.WriteLine("Permisos completos.");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta.");
                }

                break;


            case 2:

                if (contraseña == "profesor123")
                {
                    Console.WriteLine("Acceso concedido.");
                    Console.WriteLine("Bienvenido, Profesor.");
                    Console.WriteLine("Puede gestionar cursos y notas.");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta.");
                }

                break;


            case 3:

                if (contraseña == "alumno123")
                {
                    Console.WriteLine("Acceso concedido.");
                    Console.WriteLine("Bienvenido, Estudiante.");
                    Console.WriteLine("Puede consultar cursos y notas.");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta.");
                }

                break;


            default:
                Console.WriteLine("Tipo de usuario no válido.");
                break;
        }
    }


    // =========================================================
    // EJERCICIO 3
    // CAJERO AUTOMÁTICO
    // =========================================================

    static void Ejercicio3()
    {
        Console.WriteLine("EJERCICIO 3 - CAJERO AUTOMÁTICO");
        Console.WriteLine();

        double saldo = 1500;

        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Retirar dinero");
        Console.WriteLine("3. Depositar dinero");

        Console.WriteLine();
        Console.Write("Seleccione una operación: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:

                Console.WriteLine($"Saldo disponible: S/ {saldo:F2}");

                break;


            case 2:

                Console.Write("Ingrese el monto a retirar: S/ ");
                double retiro = Convert.ToDouble(Console.ReadLine());

                if (retiro > 0)
                {
                    if (retiro <= saldo)
                    {
                        saldo = saldo - retiro;

                        Console.WriteLine("Retiro realizado correctamente.");
                        Console.WriteLine($"Saldo restante: S/ {saldo:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente.");
                    }
                }
                else
                {
                    Console.WriteLine("El monto debe ser mayor que cero.");
                }

                break;


            case 3:

                Console.Write("Ingrese el monto a depositar: S/ ");
                double deposito = Convert.ToDouble(Console.ReadLine());

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


            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    }


    // =========================================================
    // EJERCICIO 4
    // TIENDA Y DESCUENTOS
    // =========================================================

    static void Ejercicio4()
    {
        Console.WriteLine("EJERCICIO 4 - TIENDA Y DESCUENTOS");
        Console.WriteLine();

        Console.WriteLine("1. Laptop      - S/ 2500");
        Console.WriteLine("2. Monitor     - S/ 800");
        Console.WriteLine("3. Teclado     - S/ 150");
        Console.WriteLine("4. Mouse       - S/ 80");

        Console.WriteLine();
        Console.Write("Seleccione un producto: ");
        int producto = Convert.ToInt32(Console.ReadLine());

        double precio = 0;
        string nombre = "";

        switch (producto)
        {
            case 1:
                nombre = "Laptop";
                precio = 2500;
                break;

            case 2:
                nombre = "Monitor";
                precio = 800;
                break;

            case 3:
                nombre = "Teclado";
                precio = 150;
                break;

            case 4:
                nombre = "Mouse";
                precio = 80;
                break;

            default:
                Console.WriteLine("Producto no válido.");
                return;
        }

        Console.Write("Ingrese la cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        if (cantidad > 0)
        {
            double total = precio * cantidad;

            Console.Write("¿Es cliente frecuente? (S/N): ");
            string frecuente = Console.ReadLine().ToUpper();

            if (frecuente == "S")
            {
                if (total >= 1000)
                {
                    total = total * 0.85;

                    Console.WriteLine("Descuento aplicado: 15%");
                }
                else
                {
                    total = total * 0.95;

                    Console.WriteLine("Descuento aplicado: 5%");
                }
            }
            else
            {
                if (total >= 3000)
                {
                    total = total * 0.90;

                    Console.WriteLine("Descuento aplicado: 10%");
                }
            }

            Console.WriteLine();
            Console.WriteLine("----- RESUMEN -----");
            Console.WriteLine($"Producto: {nombre}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Total: S/ {total:F2}");
        }
        else
        {
            Console.WriteLine("Cantidad no válida.");
        }
    }


    // =========================================================
    // EJERCICIO 5
    // VENTA DE ENTRADAS DE CINE
    // =========================================================

    static void Ejercicio5()
    {
        Console.WriteLine("EJERCICIO 5 - VENTA DE ENTRADAS DE CINE");
        Console.WriteLine();

        Console.WriteLine("1. Película infantil");
        Console.WriteLine("2. Película de acción");
        Console.WriteLine("3. Película de terror");

        Console.WriteLine();
        Console.Write("Seleccione una película: ");
        int pelicula = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        switch (pelicula)
        {
            case 1:

                Console.WriteLine("Entrada permitida.");

                if (edad <= 12)
                {
                    Console.WriteLine("Precio especial infantil: S/ 10");
                }
                else
                {
                    Console.WriteLine("Precio normal: S/ 18");
                }

                break;


            case 2:

                if (edad >= 14)
                {
                    Console.WriteLine("Entrada permitida.");

                    if (edad < 18)
                    {
                        Console.WriteLine("Menor de edad: se recomienda supervisión.");
                    }
                }
                else
                {
                    Console.WriteLine("No cumple con la edad mínima.");
                }

                break;


            case 3:

                if (edad >= 18)
                {
                    Console.WriteLine("Entrada permitida.");
                    Console.WriteLine("Película exclusiva para mayores de edad.");
                }
                else
                {
                    Console.WriteLine("Entrada denegada.");
                    Console.WriteLine("Debe ser mayor de 18 años.");
                }

                break;


            default:
                Console.WriteLine("Película no válida.");
                break;
        }
    }


    // =========================================================
    // EJERCICIO 6
    // SISTEMA DE TRANSPORTE
    // =========================================================

    static void Ejercicio6()
    {
        Console.WriteLine("EJERCICIO 6 - SISTEMA DE TRANSPORTE");
        Console.WriteLine();

        Console.WriteLine("1. Bus");
        Console.WriteLine("2. Metro");
        Console.WriteLine("3. Taxi");

        Console.WriteLine();
        Console.Write("Seleccione un transporte: ");
        int transporte = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿Es estudiante? (S/N): ");
        string estudiante = Console.ReadLine().ToUpper();

        double precio = 0;

        switch (transporte)
        {
            case 1:
                precio = 3.00;
                break;

            case 2:
                precio = 4.00;
                break;

            case 3:
                precio = 12.00;
                break;

            default:
                Console.WriteLine("Transporte no válido.");
                return;
        }

        if (edad < 12)
        {
            precio = precio * 0.50;

            Console.WriteLine("Descuento infantil aplicado.");
        }
        else
        {
            if (edad >= 65)
            {
                precio = precio * 0.50;

                Console.WriteLine("Descuento para adulto mayor aplicado.");
            }
            else
            {
                if (estudiante == "S")
                {
                    precio = precio * 0.80;

                    Console.WriteLine("Descuento de estudiante aplicado.");
                }
            }
        }

        Console.WriteLine($"Precio final: S/ {precio:F2}");
    }


    // =========================================================
    // EJERCICIO 7
    // BONIFICACIÓN DE EMPLEADOS
    // =========================================================

    static void Ejercicio7()
    {
        Console.WriteLine("EJERCICIO 7 - BONIFICACIÓN DE EMPLEADOS");
        Console.WriteLine();

        Console.WriteLine("1. Administración");
        Console.WriteLine("2. Tecnología");
        Console.WriteLine("3. Ventas");

        Console.WriteLine();
        Console.Write("Seleccione el departamento: ");
        int departamento = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el salario actual: S/ ");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese los años de servicio: ");
        int años = Convert.ToInt32(Console.ReadLine());

        double porcentaje = 0;

        switch (departamento)
        {
            case 1:
                porcentaje = 0.05;
                break;

            case 2:
                porcentaje = 0.08;
                break;

            case 3:
                porcentaje = 0.10;
                break;

            default:
                Console.WriteLine("Departamento no válido.");
                return;
        }

        if (años >= 5)
        {
            if (años >= 10)
            {
                porcentaje = porcentaje + 0.10;
            }
            else
            {
                porcentaje = porcentaje + 0.05;
            }
        }

        double bono = salario * porcentaje;
        double salarioFinal = salario + bono;

        Console.WriteLine();
        Console.WriteLine($"Bonificación: S/ {bono:F2}");
        Console.WriteLine($"Salario final: S/ {salarioFinal:F2}");
    }


    // =========================================================
    // EJERCICIO 8
    // RESTAURANTE
    // =========================================================

    static void Ejercicio8()
    {
        Console.WriteLine("EJERCICIO 8 - RESTAURANTE");
        Console.WriteLine();

        Console.WriteLine("1. Hamburguesa - S/ 15");
        Console.WriteLine("2. Pizza       - S/ 25");
        Console.WriteLine("3. Pollo       - S/ 20");
        Console.WriteLine("4. Ensalada    - S/ 12");

        Console.WriteLine();
        Console.Write("Seleccione un plato: ");
        int plato = Convert.ToInt32(Console.ReadLine());

        double precio = 0;
        string nombre = "";

        switch (plato)
        {
            case 1:
                nombre = "Hamburguesa";
                precio = 15;
                break;

            case 2:
                nombre = "Pizza";
                precio = 25;
                break;

            case 3:
                nombre = "Pollo";
                precio = 20;
                break;

            case 4:
                nombre = "Ensalada";
                precio = 12;
                break;

            default:
                Console.WriteLine("Plato no válido.");
                return;
        }

        Console.Write("Ingrese la cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        if (cantidad > 0)
        {
            double total = precio * cantidad;

            if (cantidad >= 5)
            {
                if (total >= 100)
                {
                    total = total * 0.85;

                    Console.WriteLine("Descuento especial del 15%.");
                }
                else
                {
                    total = total * 0.90;

                    Console.WriteLine("Descuento del 10%.");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Plato: {nombre}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Total: S/ {total:F2}");
        }
        else
        {
            Console.WriteLine("Cantidad no válida.");
        }
    }


    // =========================================================
    // EJERCICIO 9
    // CLASIFICACIÓN DE JUGADOR
    // =========================================================

    static void Ejercicio9()
    {
        Console.WriteLine("EJERCICIO 9 - CLASIFICACIÓN DE JUGADOR");
        Console.WriteLine();

        Console.WriteLine("Nivel de dificultad:");
        Console.WriteLine("1. Fácil");
        Console.WriteLine("2. Normal");
        Console.WriteLine("3. Difícil");

        Console.WriteLine();
        Console.Write("Seleccione dificultad: ");
        int dificultad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la puntuación obtenida: ");
        int puntos = Convert.ToInt32(Console.ReadLine());

        switch (dificultad)
        {
            case 1:

                Console.WriteLine("Dificultad: Fácil");

                if (puntos >= 1000)
                {
                    Console.WriteLine("Clasificación: Maestro.");
                }
                else
                {
                    Console.WriteLine("Clasificación: Principiante.");
                }

                break;


            case 2:

                Console.WriteLine("Dificultad: Normal");

                if (puntos >= 2000)
                {
                    if (puntos >= 5000)
                    {
                        Console.WriteLine("Clasificación: Experto.");
                    }
                    else
                    {
                        Console.WriteLine("Clasificación: Avanzado.");
                    }
                }
                else
                {
                    Console.WriteLine("Clasificación: Intermedio.");
                }

                break;


            case 3:

                Console.WriteLine("Dificultad: Difícil");

                if (puntos >= 5000)
                {
                    if (puntos >= 10000)
                    {
                        Console.WriteLine("Clasificación: Leyenda.");
                    }
                    else
                    {
                        Console.WriteLine("Clasificación: Profesional.");
                    }
                }
                else
                {
                    Console.WriteLine("Clasificación: Aspirante.");
                }

                break;


            default:
                Console.WriteLine("Dificultad no válida.");
                break;
        }
    }


    // =========================================================
    // EJERCICIO 10
    // SISTEMA DE USUARIOS
    // =========================================================

    static void Ejercicio10()
    {
        Console.WriteLine("EJERCICIO 10 - SISTEMA DE USUARIOS");
        Console.WriteLine();

        Console.WriteLine("1. Administrador");
        Console.WriteLine("2. Empleado");
        Console.WriteLine("3. Cliente");

        Console.WriteLine();
        Console.Write("Seleccione su tipo de usuario: ");
        int usuario = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿La cuenta está activa? (S/N): ");
        string activa = Console.ReadLine().ToUpper();

        switch (usuario)
        {
            case 1:

                if (activa == "S")
                {
                    Console.Write("Ingrese el código de administrador: ");
                    string codigo = Console.ReadLine();

                    if (codigo == "ADM2026")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Acceso total concedido.");
                        Console.WriteLine("- Gestionar usuarios");
                        Console.WriteLine("- Gestionar productos");
                        Console.WriteLine("- Gestionar ventas");
                        Console.WriteLine("- Consultar reportes");
                    }
                    else
                    {
                        Console.WriteLine("Código de administrador incorrecto.");
                    }
                }
                else
                {
                    Console.WriteLine("La cuenta está desactivada.");
                }

                break;


            case 2:

                if (activa == "S")
                {
                    Console.WriteLine();
                    Console.WriteLine("Acceso de empleado concedido.");
                    Console.WriteLine("- Registrar ventas");
                    Console.WriteLine("- Consultar productos");
                    Console.WriteLine("- Consultar clientes");
                }
                else
                {
                    Console.WriteLine("La cuenta está desactivada.");
                }

                break;


            case 3:

                if (activa == "S")
                {
                    Console.WriteLine();
                    Console.WriteLine("Acceso de cliente concedido.");
                    Console.WriteLine("- Consultar productos");
                    Console.WriteLine("- Realizar compras");
                }
                else
                {
                    Console.WriteLine("La cuenta está desactivada.");
                }

                break;


            default:
                Console.WriteLine("Tipo de usuario no válido.");
                break;
        }
    }
}