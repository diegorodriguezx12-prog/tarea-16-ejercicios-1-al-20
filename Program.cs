int tabla;
int i = 1;
Console.WriteLine("¿Qué tabla de multiplicar desea ver?");
tabla = int.Parse(Console.ReadLine());
do
{
    int resultado = tabla * i;
    Console.WriteLine(tabla + " * " + i + " = " + resultado);
    i++;
} while (i <= 10);
Console.WriteLine("Fin de la tabla del " + tabla);