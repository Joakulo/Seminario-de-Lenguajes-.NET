void Fac(int n, out int f)
{
    if (n==0)
    {
        f = 1;
    } else {
        Fac(n-1, out int temp);
        f = n* temp;
    }
}

int f;
Fac(int.Parse(args[0]), out f);
Console.WriteLine(f);

Console.ReadKey();