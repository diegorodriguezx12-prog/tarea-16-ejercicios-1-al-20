int opcion;
do
{
    Console.WriteLine("----- MENÚ DE OPCIONES -----");
    Console.WriteLine("1. Saludar");
    Console.WriteLine("2. Ver fecha y hora");
    Console.WriteLine("3. Salir");
    Console.WriteLine("Seleccione una opción: ");

    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine("¡Hola! Espero que tengas un gran día.");
    }
    else if (opcion == 2)
    {
        Console.WriteLine("La fecha actual es: " + DateTime.Now);
    }
    else if (opcion == 3)
    {
        Console.WriteLine("Saliendo del programa...");
    }
    else
    {
        Console.WriteLine("Opción no válida, intenta de nuevo.");
    }
    Console.WriteLine();
} while (opcion != 3);
Console.WriteLine("Programa finalizado correctamente.");