int a = 5;
int b = 10;

Console.WriteLine($"Previo al Swap: a={a}, b={b}");

Swap(ref a, ref b);

Console.WriteLine($"Post Swap: a={a}, b={b}");

void Swap(ref int a, ref int b)
{
    int aux = a;
    a = b;
    b = aux;
}

Console.ReadKey();