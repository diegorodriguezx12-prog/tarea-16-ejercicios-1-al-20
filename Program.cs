int numero;
int cantidadnumeros = 0;

do
{
    Console.WriteLine("ingrese un número (Ingrese 0 para salir)");
    numero = int.Parse(Console.ReadLine());
    if (numero !=0)
    {
        cantidadnumeros++;
    }
} while (numero != 0);
Console.WriteLine("Ingresaste un total de "+cantidadnumeros+ " números");