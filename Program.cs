int numero;
int sumaTotal = 0;
int contador = 0;
double promedio = 0;
do
{
    Console.WriteLine("Ingrese un número (0 para finalizar): ");
    numero = int.Parse(Console.ReadLine());

    if (numero != 0)
    {
        sumaTotal = sumaTotal + numero;
        contador++;
    }

} while (numero != 0);
if (contador > 0)
{
    promedio = (double)sumaTotal / contador;

    Console.WriteLine("Suma total: " + sumaTotal);
    Console.WriteLine("Cantidad de números: " + contador);
    Console.WriteLine("Promedio: " + promedio);
}
else
{
    Console.WriteLine("No se ingresaron números para calcular.");
}