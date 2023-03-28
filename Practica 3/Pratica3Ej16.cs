int num;
int suma = 0;
bool ok = true;
string aux;

while (ok)
{
    Console.Write("Ingrese un numero: ");
    aux = Console.ReadLine();
    if (aux == "")
    {
        ok = false;
    }
    else
    {
        try
        {
            num = int.Parse(aux);
            suma += num;
            Console.WriteLine($"Suma acumulada: {suma}. \n");
        }
        catch (FormatException)
        {
            Console.WriteLine("El valor ingresado no es un numero.");
        }
    }
}

Console.ReadKey();