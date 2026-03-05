int numero = 1;
int cuadrado;
do
{
    cuadrado = numero * numero;
    Console.WriteLine($"{numero}=="+cuadrado);
    numero++;
} while (numero <= 10);