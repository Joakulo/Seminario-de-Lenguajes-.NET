﻿int sum = 0;
int i = 1;
while (i <= 10)
{
sum += i++;
Console.WriteLine(sum);
}

Console.WriteLine(i);


Console.ReadKey();