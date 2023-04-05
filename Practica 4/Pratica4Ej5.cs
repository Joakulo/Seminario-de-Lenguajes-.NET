using Teoria2;

try
{
    new Hora(23, 30, 15).Imprimir();
    new Hora(14.43).Imprimir();
    new Hora(14.45).Imprimir();
    new Hora(14.45114).Imprimir();


}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();

