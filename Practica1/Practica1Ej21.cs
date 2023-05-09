int i = 1;
Console.WriteLine(i);
if (--i == 0)           //Resta, despues compara
{
Console.WriteLine(i);
Console.WriteLine("cero");
Console.WriteLine(i);
}
Console.WriteLine(i);
if (i++ == 0)           //Compara, despues suma
{
Console.WriteLine(i);
Console.WriteLine("cero");
Console.WriteLine(i);
}
Console.WriteLine(i);
Console.WriteLine(i);