int Fac(int n) => (n==1) ? 1 : n * Fac(n-1);

Console.WriteLine(Fac(5));

Console.ReadKey();