int numero;
int subtotal = 0;

do
{
    Console.WriteLine("ingrese un número (Ingrese 0 para terminar)");
    numero = int.Parse(Console.ReadLine());
    subtotal=subtotal + numero;
} while (numero != 0);
Console.WriteLine("La suma total es de: " + subtotal);