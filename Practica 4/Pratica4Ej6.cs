using Teoria2;

try
{
    new Ecuacion2(2,5,-7).ImprimirRaices();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();

