string pass;
do
{
    Console.WriteLine("Ingrese la contraseña");
    pass = Console.ReadLine();
    if (pass == "1234")
    {
        Console.WriteLine("Contraseña correcta");
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta");
    }
} while (pass != "1234");