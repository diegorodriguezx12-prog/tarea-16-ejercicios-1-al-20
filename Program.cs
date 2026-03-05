int numero;
int contador = 0;
do
{
    Console.WriteLine("Ingrese un número (0 para salir)");
    numero = int.Parse(Console.ReadLine());
    if (numero != 0 && numero % 2 == 0)
    {
        contador++;
    }
} while (numero != 0);
Console.WriteLine("El total de números pares es de: " + contador);