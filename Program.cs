int numero = 1;
int contador = 0;
do
{
    Console.WriteLine(numero);
    contador++;
    numero++;
} while (numero <= 50);
Console.WriteLine("La cantidad total de números es de: " + contador);