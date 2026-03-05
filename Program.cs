int intentos = 0;
int suma = 0;
int numerosingresados;
do
{
    Console.WriteLine("Ingrese el número:");
    numerosingresados = int.Parse(Console.ReadLine());
    suma = suma + numerosingresados;
    intentos++;
} while (intentos < 5);
Console.WriteLine("La suma total es de: " + suma);