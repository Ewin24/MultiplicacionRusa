static int MultiplicacionRusa(int multiplicando, int multiplicador)
{
    int suma = 0;

    while (multiplicador > 0)
    {
        if (multiplicador % 2 != 0)
        {
            suma += multiplicando;
        }

        multiplicando *= 2;
        multiplicador /= 2;
    }

    return suma;
}


Console.WriteLine("Ingrese multiplicador: ");
int multiplicador = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingrese multiplicando: ");
int multiplicando = Int32.Parse(Console.ReadLine());

int resultado = MultiplicacionRusa(multiplicando, multiplicador);

Console.WriteLine($"Resultado: {resultado}");