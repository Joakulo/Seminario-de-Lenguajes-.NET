bool EsPrimo(int n)
{
    bool ok=true;
    int i=2;
    while ((ok) & (i<=Math.Sqrt(n)))
    {
        ok = !(n % i == 0);
        i++;
    }
    return ok;
}

for (int i=1; i<int.Parse(args[0]) ; i++)
{
    if (EsPrimo(i)) Console.WriteLine(i);
}

Console.ReadKey();