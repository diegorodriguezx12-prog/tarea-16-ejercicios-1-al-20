int numero;
do
{
    Console.WriteLine("Ingrese el número:");
    numero = int.Parse(Console.ReadLine());
    if(numero<=0)
    {
        Console.WriteLine("El número tiene que ser mayor a 0");
    }
} while (numero <= 0);
Console.WriteLine("Número correcto: " + numero);