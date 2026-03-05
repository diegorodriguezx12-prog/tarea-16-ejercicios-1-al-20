int numero;
int mayor = 0;
bool primerNumero = true;
do
{
    Console.WriteLine("ingrese un número (Ingrese 0 para salir)");
    numero = int.Parse(Console.ReadLine());
    if (numero != 0)
    {
       if (primerNumero || numero>mayor)
        {
            mayor = numero;
            primerNumero = false;
        }
    }
} while (numero != 0);
if (!primerNumero)
{
    Console.WriteLine("El número mayor ingresado fué: "+mayor);
}