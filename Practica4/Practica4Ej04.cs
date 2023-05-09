using Teoria2;

try
{
    Hora h = new Hora(23, 30, 15);
    h.Imprimir();

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();

