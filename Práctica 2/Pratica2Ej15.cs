﻿Console.WriteLine(Fib(10));

int Fib(int n) 
{
    if (n <= 2) 
    {
        return 1;
    } else {
        return Fib(n - 1) + Fib(n - 2);
    }
}

Console.ReadKey();